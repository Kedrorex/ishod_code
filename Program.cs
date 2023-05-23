using System.IO;

void GudStringTender (string path, string text)
{
    
    if (File.Exists(path))
    {
        File.AppendAllText(path, text);
    }
    else
    {
        Console.WriteLine("No fale");
    }

}

Console.WriteLine("Введите компанию: ");
string company =  Convert.ToString(Console.ReadLine());

string trak = @"C:\Users\Айдар\Desktop\1\C#\Ishod_code\123\catalog\tender.txt";
string tols = "\nИсходящий №";

int numberLine = System.IO.File.ReadAllLines(trak).Length + 1;



tols = tols + " " + numberLine + " " + "от " + DateTime.Now + " " + "\"" + company + "\"" ;
Console.WriteLine(DateTime.Now);




// Console.WriteLine(NumberLine(trak));
GudStringTender(trak, tols);
Console.WriteLine("Добавлена новая запись: ");
Console.WriteLine(tols);