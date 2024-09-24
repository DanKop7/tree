int bookPages = int.Parse(Console.ReadLine());  
int hourPages  = int.Parse(Console.ReadLine());
int daysToFinish = int.Parse(Console.ReadLine());

int readingTime = bookPages / hourPages;
int hoursPerDays = readingTime / daysToFinish;

Console.WriteLine(hoursPerDays);