# Symulator Stanowiska Dyspozytorskiego

## Cel Aplikacji

Aplikacja "Symulator Stanowiska Dyspozytorskiego" została stworzona w celu symulowania rzeczywistych warunków pracy na stanowisku dyspozytorskim. Jej głównym celem jest monitorowanie procesu produkcyjnego oraz aktywności operatora. Operator ma za zadanie nadzorować proces produkcyjny i podejmować odpowiednie działania w przypadku awarii lub przekroczenia granicznych wartości parametrów.

## Parametry do Monitorowania

Aplikacja monitoruje następujące parametry:
- Temperatura procesora: Monitorowanie temperatury rdzenia procesora w celu zapobiegania przegrzaniu.
- Obciążenie procesora: Śledzenie obciążenia procesora w celu monitorowania wydajności systemu.
- Prędkość wentylatorów: Monitorowanie prędkości obrotowych wentylatorów w celu zapewnienia odpowiedniego chłodzenia.

## Symulacja Procesu Produkcyjnego

Aplikacja symuluje proces produkcyjny poprzez:
- Generowanie losowych wartości parametrów: Wykorzystuje generatora liczb losowych do symulowania różnych parametrów procesu produkcyjnego, takich jak temperatura, obciążenie itp.
- Obsługę awarii i przekroczeń granicznych wartości: Implementuje mechanizmy symulujące losowe awarie oraz przekroczenia granicznych wartości parametrów. Na przykład, symulacja przegrzania procesora lub nagłego wzrostu obciążenia, co wymaga odpowiedniej reakcji ze strony operatora.

## Obsługa Awarii i Przekroczeń Granicznych Wartości

Aplikacja obsługuje awarie i przekroczenia granicznych wartości poprzez:
- Wyświetlanie komunikatów i ostrzeżeń: Informuje operatora o wykrytych awariach lub przekroczeniach granicznych wartości parametrów.
- Pozwala operatorowi podejmować działania w celu rozwiązania problemu, na przykład zmiana prędkości wentylatorów lub zatrzymanie procesu produkcyjnego.

## Implementacja

Aplikacja została zaimplementowana w języku C# przy użyciu technologii Windows Forms. Interfejs użytkownika składa się z okna logowania oraz panelu monitorującego. Dodatkowo, aplikacja zawiera mechanizm autodiagnostyczny, który okresowo sprawdza aktywność operatora poprzez wciśnięcie klawisza.

## Używanie Aplikacji

1. Uruchom aplikację.
2. Zaloguj się używając swojego konta.
3. Monitoruj parametry procesu produkcyjnego na panelu monitorującym.
4. W razie awarii lub przekroczenia granicznych wartości parametrów, podejmij odpowiednie działania.

## Autor

Aplikacja została stworzona przez Michał Zarzycki 184856. Kewin Trochowski.

---
© 2024 Michał Zarzycki 184856. Kewin Trochowski.
