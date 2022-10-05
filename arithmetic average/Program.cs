internal class Program
{
    static void Main(string[] args)
    {
        float inputValue;
        float suma = 0;
        int i = 0;

        do
        {
            Console.WriteLine("Insert the number: ");
            inputValue = float.Parse(Console.ReadLine());
            if (inputValue == 0)
            {
                break;
            }
            suma += inputValue;
            i++;
        } while (inputValue != 0);

        Console.WriteLine("average it: {0}", Math.Round(suma / i, 2));
    }
}