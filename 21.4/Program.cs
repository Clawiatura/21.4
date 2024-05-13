using System.Diagnostics.Contracts;

Console.WriteLine("Что вы хотите удалить? 1 - файл, 2 - папку. ");
string option = Console.ReadLine();
Console.WriteLine("Вы уверены, что хотите удалить файл или папку? Y/N");
string optionUser = Console.ReadLine();
if (optionUser == "Y")
{
    if (option == "1")
    {
        Console.WriteLine("Укажите путь к файлу: ");
        string path = Console.ReadLine();



        if (File.Exists(path))
        {
            FileInfo file = new FileInfo(path);
            file.Delete();
            Console.WriteLine("Файл успешно удален ");
        }
        else
        {

            Console.WriteLine("Файл не найден");

        }
    }
}
else if (option == "2")
{
    Console.WriteLine("Введете путь к папке");
    string path = Console.ReadLine();

    if (Directory.Exists(path))
    {
        DirectoryInfo folder = new DirectoryInfo(path);
        Directory.Delete(path, true);
        Console.WriteLine("Папка удалена ");
    }
    else
    {
        Console.WriteLine("Папка не найдена");

    }
}
else
{
    Console.WriteLine("bb");
}