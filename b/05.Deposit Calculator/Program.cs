double depositAmount = double.Parse(Console.ReadLine());
int termDeposit = int.Parse(Console.ReadLine());
double deannualRate = double.Parse(Console.ReadLine()) / 100;


double amount = depositAmount + termDeposit * (depositAmount * deannualRate) / 12;

Console.WriteLine($"{amount:F2}");


