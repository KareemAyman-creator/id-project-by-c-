Console.Write("Enter your id :");
long id = Convert.ToInt64(Console.ReadLine());
long gendar = (id % 100) / 10;
String place;

if (gendar == 1)
{
    Console.WriteLine("the gendar is  :  male ");
}
else
{
    Console.WriteLine("the gendar is : female");
}

long birthDate = (id / 10000000) % 1000000;
Console.WriteLine($"The birthDate of this person = {birthDate}");

long GovernmentBirth = (id % 10000000) / 100000;

switch (GovernmentBirth)
{
    case 1:
        place = "cairo";
        break;
    case 2:
        place = "Alex";
        break;
    case 3:
        place = "portsaid";
        break;
    case 4:
        place = "suez";
        break;
    case 11:
        place = "damietta";
        break;
    case 12:
        place = "Dakhalia";
        break;
    case 13:
        place = "Sharqia";
        break;
    case 14:
        place = "Qualyubia";
        break;
    case 15:
        place = "Kafr elsheikh";
        break;
    case 16:
        place = "Gharbia";
        break;
    case 17:
        place = "Monufia";
        break;
    case 18:
        place = "Beheria";
        break;
    case 19:
        place = "Ismalia";
        break;
    case 21:
        place = "Giza";
        break;
    case 22:
        place = "Beni suef";
        break;
    case 23:
        place = "Faiyum";
        break;
    case 24:
        place = "Minya";
        break;
    case 25:
        place = "Assuit";
        break;
    case 26:
        place = "Sohag";
        break;
    case 27:
        place = "qena";
        break;
    case 28:
        place = "aswan";
        break;
    case 29:
        place = "luxor";
        break;
    case 31:
        place = "read sea";
        break;
    case 32:
        place = "new wady";
        break;
    case 33:
        place = "Matrouh";
        break;
    case 34:
        place = "North sinai";
        break;
    case 35:
        place = "south sinai";
        break;
    default:
        place = "outside of republic";
        break;
}

Console.WriteLine($" The birth place is : {place}");

long serialNumber = (id % 10000) / 100;
Console.WriteLine($" The serial number is : {serialNumber}");

long moe = id % 10;
Console.WriteLine($" The moe identifcation is : {moe}");
