
// Formulas ==========

double CelFar(double value) => (value * (9.0 / 5.0)) + 32.0;

double CelKel(double value) => value + 273.15;

double FarCel(double value) => (value - 32.0) * (5.0 / 9.0);

double FarKel(double value) => (value - 32.0) * (5.0 / 9.0) + 273.15;

double KelCel(double value) => value - 273.15;

double KelFar(double value) => (value - 273.15) * (9.0 / 5.0) + 32.0;

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
                case 1: { Console.WriteLine($"{value}°C = {CelFar(value)}°F"); break; }
                case 2: { Console.WriteLine($"{value}°C = {CelKel(value)}°K"); break; }
                default: { ErrPage(); break; }
            }
            break;
        case 2:
            switch (secondChoise)
            {
                case 1: { Console.WriteLine($"{value}°F = {FarCel(value)}°C"); break; }
                case 2: { Console.WriteLine($"{value}°F = {FarKel(value)}°K"); break; }
                default: { ErrPage(); break; }
            }
            break;
        case 3:
            switch (secondChoise)
            {
                case 1: { Console.WriteLine($"{value}°K = {KelCel(value)}°C"); break; }
                case 2: { Console.WriteLine($"{value}°K = {KelFar(value)}°F"); break; }
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

int CheckerInput(int left, int right) // 1 - choise, 0 - value
{
    int value;

    if (!int.TryParse(Console.ReadLine(), out value) || !RangeCheck(value, left, right))
    { return value; }
    else
    { value = 0; return value; }
}

// Main ==========

int firstChoise, secondChoise;
double value;

FromPage();

if (CheckerInput(1, 3) == 0)
{ ErrPage(); return; }
else
{ firstChoise = CheckerInput(1, 3); }

EnterPage();

if (!double.TryParse(Console.ReadLine(), out value))
{ ErrPage(); return; }

ToPage(firstChoise);

if (CheckerInput(1, 2) == 0)
{ ErrPage(); return; }
else
{ secondChoise = CheckerInput(1, 2); }

Switcher(value, firstChoise, secondChoise);

Console.ReadLine();
