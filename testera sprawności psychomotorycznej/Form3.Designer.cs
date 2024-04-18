using System.Drawing;     // Dla zmiennej typu Color

namespace testera_sprawności_psychomotorycznej
{
    partial class Monitoring
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Glowny_Program OknoRodzic1;
        public Response Okno_wyskakujace;
        public Event_Form Okno_komunikatow;
        private Color KolorTla_1;
        private Color KolorTla_2;
        private Color KolorTla_3;
        private OknoInfo OknoHelp;
        private bool zatrzask = false;
        public ProductionLineSimulator Symulacja;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_diag = new System.Windows.Forms.Timer(this.components);
            this.symulacja_czasomierz = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.06289F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.9371F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1009, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "uruchomienie zaworu bezpieczeństwa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.Przycisk_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.Przycisk_MouseHover);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(250, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(507, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Komunikaty";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(763, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "zmniejszenie mocy silnika ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.Przycisk_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.Przycisk_MouseHover);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(6, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(234, 172);
            this.button4.TabIndex = 3;
            this.button4.Text = "włączyć dodatkowy wentylator";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.Przycisk_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.Przycisk_MouseHover);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(763, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(243, 176);
            this.button5.TabIndex = 4;
            this.button5.Text = "zwolnić tempo pracy linii produkcyjnej";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseLeave += new System.EventHandler(this.Przycisk_MouseLeave);
            this.button5.MouseHover += new System.EventHandler(this.Przycisk_MouseHover);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(3, 531);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(241, 66);
            this.button6.TabIndex = 5;
            this.button6.Text = "uruchomienie systemów gaśniczych";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseLeave += new System.EventHandler(this.Przycisk_MouseLeave);
            this.button6.MouseHover += new System.EventHandler(this.Przycisk_MouseHover);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(250, 531);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(507, 66);
            this.button7.TabIndex = 6;
            this.button7.Text = "Powrot";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(763, 531);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(243, 66);
            this.button8.TabIndex = 7;
            this.button8.Text = "zatrzymanie maszyny do czasu uzupełnienia oleju";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseLeave += new System.EventHandler(this.Przycisk_MouseLeave);
            this.button8.MouseHover += new System.EventHandler(this.Przycisk_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(250, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 469);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // timer_diag
            // 
            this.timer_diag.Interval = 30000;
            this.timer_diag.Tick += new System.EventHandler(this.timer_diag_Tick);
            // 
            // symulacja_czasomierz
            // 
            this.symulacja_czasomierz.Interval = 500;
            this.symulacja_czasomierz.Tick += new System.EventHandler(this.symulacja_czasomierz_Tick);
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Monitoring";
            this.Text = "Panel Monitorowania";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer_diag;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer symulacja_czasomierz;
    }
}