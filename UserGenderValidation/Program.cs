// See https://aka.ms/new-console-template for more information


//rakendus kysib kasutaja sugu
//rakendus kysib kasutajalt nime
//lahtudes valikust rakendus tervitab kasutajat:
//"Welcome,Mr.[kasutaja perekonnanimi]/"Welcome ms. {kasutaja perekonnanimi]"



Console.WriteLine("Please selest your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome,Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
