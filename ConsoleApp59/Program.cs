double uahToUsd = 0.024;
double uahToEur = 0.022;

double usdToUah = 41.5;
double usdToEur = 0.92;

double eurToUah = 45.0;
double eurToUsd = 1.08;

Console.Write("Введіть суму: ");
double amount = Convert.ToDouble(Console.ReadLine());

Console.Write("З якої валюти (UAH, USD, EUR): ");
string from = Console.ReadLine().ToUpper();

Console.Write("У яку валюту (UAH, USD, EUR): ");
string to = Console.ReadLine().ToUpper();

double result = ConvertCurrency(amount, from, to);

Console.WriteLine("Результат: " + result + " " + to);

double ConvertCurrency(double sum, string src, string target)
{
    if (src == target) return sum;

    if (src == "UAH" && target == "USD") return sum * uahToUsd;
    if (src == "UAH" && target == "EUR") return sum * uahToEur;

    if (src == "USD" && target == "UAH") return sum * usdToUah;
    if (src == "USD" && target == "EUR") return sum * usdToEur;

    if (src == "EUR" && target == "UAH") return sum * eurToUah;
    if (src == "EUR" && target == "USD") return sum * eurToUsd;

    Console.WriteLine("Невідома валюта!");
    return 0;
}