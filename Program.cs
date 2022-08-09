
// Formulas ==========

double CelToFar(double value) => (value * (9.0 / 5.0)) + 32.0;

double CelToKel(double value) => value + 273.15;

double FarToCel(double value) => (value - 32.0) * (5.0 / 9.0);

double FarToKel(double value) => (value - 32.0) * (5.0 / 9.0) + 273.15;

double KelToCel(double value) => value - 273.15;

double KelToFar(double value) => (value - 273.15) * (9.0 / 5.0) + 32.0;

// Pages ==========

void FromPage()
{
    Console.Clear();
    Console.WriteLine("From\n\n1 - °C\n2 - °F\n3 - °K\n");
}

void EnterPage()
{
    Console.Clear();
    Console.Write("Enter a value: ");
}

void ToPage(int firstchoise)
{
    Console.Clear();

    switch (firstchoise)
    {
        case 1: { Console.WriteLine("To\n\n1 - °F\n2 - °K\n"); break; }
        case 2: { Console.WriteLine("To\n\n1 - °C\n2 - °K\n"); break; }
        case 3: { Console.WriteLine("To\n\n1 - °C\n2 - °F\n"); break; }
    }
}

void ErrPage()
{
    Console.Clear();
    Console.WriteLine("Incorrect input format");
    Console.ReadLine();
    StartProgram();
}

// Scripts ==========

void Switcher(double value, int firstChoise, int secondChoise)
{
    Console.Clear();

    switch (firstChoise)
    {
        case 1:
            switch (secondChoise)
            {
                case 1: { Console.WriteLine($"{value}°C = {CelToFar(value)}°F"); break; }
                case 2: { Console.WriteLine($"{value}°C = {CelToKel(value)}°K"); break; }
                default: { ErrPage(); break; }
            }
            break;
        case 2:
            switch (secondChoise)
            {
                case 1: { Console.WriteLine($"{value}°F = {FarToCel(value)}°C"); break; }
                case 2: { Console.WriteLine($"{value}°F = {FarToKel(value)}°K"); break; }
                default: { ErrPage(); break; }
            }
            break;
        case 3:
            switch (secondChoise)
            {
                case 1: { Console.WriteLine($"{value}°K = {KelToCel(value)}°C"); break; }
                case 2: { Console.WriteLine($"{value}°K = {KelToFar(value)}°F"); break; }
                default: { ErrPage(); break; }
            }
            break;
        default:
            ErrPage();
            break;
    }
}

bool RangeCheck(int value, int left, int right)
{
    if (value >= left && value <= right) return true;
    else return false;
}

// Program ==========

void StartProgram()
{
    int firstChoise, secondChoise;
    double value;

    FromPage();

    if (!int.TryParse(Console.ReadLine(), out firstChoise) || !RangeCheck(firstChoise, 1, 3))
    { ErrPage(); }

    EnterPage();

    if (!double.TryParse(Console.ReadLine(), out value))
    { ErrPage(); }

    ToPage(firstChoise);

    if (!int.TryParse(Console.ReadLine(), out secondChoise) || !RangeCheck(secondChoise, 1, 2))
    { ErrPage(); }

    Switcher(value, firstChoise, secondChoise);

    Console.ReadLine();

    StartProgram();
}

// Main ==========

StartProgram();
