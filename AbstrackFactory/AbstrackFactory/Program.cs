using AbstrackFactory;

internal class Program
{
    private static void Main(string[] args)
    {
        ContinentFactory europa = new EuropeFactory();
        ContinentFactory america = new AmericaFactory();

        GenerateCenter generate1 = new GenerateCenter(europa);
        GenerateCenter generate2 = new GenerateCenter(america);

        generate1.ShowMassage();
        generate2.ShowMassage();
    }
}