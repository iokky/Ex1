class Programm
{
    static void Main(string[] args)
    {
        string[] testArray = { "1234", "1567", "-2", "computer cience" };
        string[] data = StringArrayCreator(testArray);
        foreach (string item in data)
        {
            Console.WriteLine(item);
        }
    }

    static string[] StringArrayCreator(string[] array) => array.Select(x => x).Where(x => x.Length < 4).ToArray();

}