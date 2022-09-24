using ConsoleApp9;


FileALALA[] files = new FileALALA[]
{
    new FileALALA("ala", "txt", 1024, new DateTime(2022, 09, 17)),
    new FileALALA("alaxua", "jpg", 1000, DateTime.Now),
    new FileALALA("alaua", "txt", 5569, new DateTime(2022, 08, 17)),
    new FileALALA("alal", "png", 124747124, new DateTime(2022, 07, 17)),
    new FileALALA("alakar", "rar", 134413, new DateTime(2022, 06, 17)),
};
//0
Console.WriteLine(files[4].NextSize());
Console.WriteLine();
//1
foreach(FileALALA file in files)
{
    if(file.Extension == "txt")
    {
        Console.WriteLine(file);
    }
}
Console.WriteLine();
//2
foreach (FileALALA file in files)
{
    if (file.Name.Contains("ua"))
    {
        Console.WriteLine(file);
    }
}
Console.WriteLine();
//3
foreach (FileALALA file in files)
{
    if (file.Date < new DateTime(2022, 09, 17))
    {
        Console.WriteLine(file);
    }
}
