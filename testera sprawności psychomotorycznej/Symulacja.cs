using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Management;
using System.Diagnostics;

namespace testera_sprawności_psychomotorycznej
{
    public class SystemMonitor
    {
        public int FanSpeed { get; private set; }
        public int GpuTemperature { get; private set; }
        public int CpuUsage { get; private set; }
        public int RamUsage { get; private set; }

        public void UpdateSystemMetrics()
        {
            FanSpeed = GetFanSpeed();
            GpuTemperature = GetGpuTemperature();
            CpuUsage = GetCurrentCpuUsage();
            RamUsage = GetRamUsage();
        }

        private int GetFanSpeed()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("\\root\\WMI", "SELECT * FROM Win32_Fan");
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj["DesiredSpeed"] != null)
                        return Convert.ToInt32(obj["DesiredSpeed"]);
                }
            }
            catch (Exception e)
            {

            }
            return 0;
        }

        private int GetGpuTemperature()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("\\root\\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj["CurrentTemperature"] != null)
                        return Convert.ToInt32(obj["CurrentTemperature"]) / 10 - 273;  // Konwertuj z Kelwinów na stopnie Celsiusza
                }
            }
            catch (Exception e)
            {

            }
            return 0;
        }

        private int GetCurrentCpuUsage()
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            return (int)cpuCounter.NextValue();
        }

        private int GetRamUsage()
        {
            var ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            return (int)ramCounter.NextValue();
        }
    }
    public class ProductionLineSimulator
    {
        private Random _random = new Random();
        private SystemMonitor _systemMonitor = new SystemMonitor(); 

        // Parametry symulacji
        public double ProcessorTemperature { get; private set; } = 50;  // temperatura rdzenia procesora w °C
        public double ProcessorUsage { get; private set; } = 10;        // użycie procesora w %
        public int FanSpeed { get; private set; } = 1000;               // prędkość wentylatora w RPM
        public double OilLevel { get; private set; } = 75;              // poziom oleju w %
        public double HydraulicPressure { get; private set; } = 100;   // ciśnienie w układzie hydraulicznym w psi

        // Progi alarmowe
        private const double MaxTemp = 85.0;
        private const double MaxUsage = 95.0;
        private const int MaxFanSpeed = 3000;
        private const double MinOilLevel = 25.0;
        private const double MaxHydraulicPressure = 200.0;

        // Tekstowe opisy stanów
        public string TemperatureStatus => $"Current CPU Temperature: {ProcessorTemperature}°C";
        public string UsageStatus => $"Current CPU Usage: {ProcessorUsage}%";
        public string FanSpeedStatus => $"Current Fan Speed: {FanSpeed} RPM";
        public string OilLevelStatus => $"Current Oil Level: {OilLevel}%";
        public string HydraulicPressureStatus => $"Current Hydraulic Pressure: {HydraulicPressure} psi";


        public bool IsTemperatureAlert { get; private set; } = false;
        public bool IsEngineAlert { get; private set; } = false;
        public bool IsOilAlert { get; private set; } = false;
        public bool IsHydraulicAlert { get; private set; } = false;

        public ProductionLineSimulator()
        {
            
        }

        public void OnTimerElapsed()
        {
            SimulateParameters();
            CheckForAlarms();
        }

        private void SimulateParameters()
        {
            this._systemMonitor.UpdateSystemMetrics();

            ProcessorTemperature += _random.NextDouble() * 4 - 2;
            ProcessorUsage += _random.NextDouble() * 10 - 5;
            FanSpeed += _random.Next(100) + (this._systemMonitor.FanSpeed / 100);
            OilLevel += _random.NextDouble() * 10 - 5;
            HydraulicPressure += _random.NextDouble() * 20 - 10;

            ProcessorTemperature = Math.Max(0, Math.Min(MaxTemp, ProcessorTemperature));
            ProcessorUsage = Math.Max(0, Math.Min(MaxUsage, ProcessorUsage));
            FanSpeed = Math.Max(0, Math.Min(MaxFanSpeed, FanSpeed));
            OilLevel = Math.Max(0, Math.Min(100, OilLevel));
            HydraulicPressure = Math.Max(0, Math.Min(MaxHydraulicPressure, HydraulicPressure));
        }

        private void CheckForAlarms()
        {
            IsTemperatureAlert = ProcessorTemperature > 75;
            IsEngineAlert = FanSpeed > 2500;
            IsOilAlert = OilLevel < MinOilLevel;
            IsHydraulicAlert = HydraulicPressure > 180;
        }
        // Methods to reset alarms
        public void ResetTemperatureAlert()
        {
            IsTemperatureAlert = false;
            ProcessorTemperature = 50;
        }

        public void ResetEngineAlert()
        {
            IsEngineAlert = false;
            FanSpeed = 1000;
        }

        public void ResetOilAlert()
        {
            IsOilAlert = false;
            OilLevel = 50;
        }

        public void ResetHydraulicAlert()
        {
            IsHydraulicAlert = false;
            HydraulicPressure = 10;
        }
    }
}
