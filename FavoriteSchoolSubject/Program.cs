Console.Write("What was your favorite subject in school? ");
var favSubject = Console.ReadLine();
string firstletterofstring = favSubject.Substring(0, 1).ToUpper() + favSubject.Substring(1);
favSubject = firstletterofstring;

switch (favSubject)
{
    case "Math":
        Console.WriteLine("Your favorite subject in school was Math");
        break;

    case "English":
    case "ELA":
        Console.WriteLine("Your favorite subject in school was English/ELA");
        break;

    case "Gym":
        Console.WriteLine("Your favorite subject in school was Gym");
        break;

    case "Science":
        Console.WriteLine("Your favorite subject in school was Science");
        break;

    case "Foregin Language":
    case "Spanish":
    case "French":
        Console.WriteLine("Your favorite subject in school was a Foregin Language");
        break;

    default:
        Console.WriteLine($"Your favorite subject in school was {favSubject}");
        break;
}