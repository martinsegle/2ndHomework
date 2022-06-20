// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8;

// 1.uzdevums

Console.WriteLine("Sveiks, kā Tevi sauc?");
string userName = Console.ReadLine();

Console.WriteLine($"Sveiks, {userName}!");

Console.WriteLine();
Console.WriteLine("=======================");
Console.WriteLine();

// 2.uzdevums

Console.WriteLine("Cik Tev ir gadu?");
string userAgeText = Console.ReadLine();

int userAge = int.Parse(userAgeText);

int nextYear = userAge + 1;

string adult = String.Format("Tu esi pilngadīgs");

if (userAge >= 18)
{
    Console.WriteLine($"Nākamgad Tev paliks {nextYear}. {adult}.");
}
else
{
    Console.WriteLine($"Nākamgad Tev paliks {nextYear}.");
}

     
Console.WriteLine();
Console.WriteLine("=======================");
Console.WriteLine();

// 3.uzdevums

