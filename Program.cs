
double CelFar(double value) => (value * (9.0 / 5.0)) + 32.0;

double CelKel(double value) => value + 273.15;

double FarCel(double value) => (value - 32.0) * (5.0 / 9.0);

double FarKel(double value) => (value - 32.0) * (5.0 / 9.0) + 273.15;

double KelCel(double value) => value - 273.15;

double KelFar(double value) => (value - 273.15) * (9.0 / 5.0) + 32.0;

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

void InPage(int firstchoise)
{
    Console.Clear();

    switch (firstchoise)
    {
        case 1:
            Console.WriteLine("In\n\n1 - °F\n2 - °K\n");
            break;
        case 2:
            Console.WriteLine("In\n\n1 - °C\n2 - °K\n");
            break;
        case 3:
            Console.WriteLine("In\n\n1 - °C\n2 - °F\n");
            break;
    }
}

void Switcher(double value, int firstChoise, int secondChoise)
{
    Console.Clear();

    switch (firstChoise)
    {
        case 1:
            switch (secondChoise)
            {
                case 1:
                    Console.WriteLine($"{value}°C = {CelFar(value)}°F");
                    break;
                case 2:
                    Console.WriteLine($"{value}°C = {CelKel(value)}°K");
                    break;
                default:
                    Err();
                    break;
            }
            break;
        case 2:
            switch (secondChoise)
            {
                case 1:
                    Console.WriteLine($"{value}°F = {FarCel(value)}°C");
                    break;
                case 2:
                    Console.WriteLine($"{value}°F = {FarKel(value)}°K");
                    break;
                default:
                    Err();
                    break;
            }
            break;
        case 3:
            switch (secondChoise)
            {
                case 1:
                    Console.WriteLine($"{value}°K = {KelCel(value)}°C");
                    break;
                case 2:
                    Console.WriteLine($"{value}°K = {KelFar(value)}°F");
                    break;
                default:
                    Err();
                    break;
            }
            break;
        default:
            Err();
            break;
    }
}

void Err()
{
    Console.Clear();
    Console.WriteLine("Incorrect input format");
    Console.ReadLine();
    return;
}

//========

int firstChoise, secondChoise, value;

FromPage();

firstChoise = int.Parse(Console.ReadLine());

EnterPage();

value = int.Parse(Console.ReadLine());

InPage(firstChoise);

secondChoise = int.Parse(Console.ReadLine());

Switcher(value, firstChoise, secondChoise);

Console.ReadLine();

