using System; 

class URI {

    public static int Fatorial(int num)
    {
        var result = 1;
        if(num > 1)
        {
            result = num * Fatorial(num - 1);
        }
        return result;
    }

    public static void Main(string[] args)
    {
        var value = Convert.ToInt32(Console.ReadLine());
        var result = Fatorial(value);
        Console.WriteLine(result);
    }

}
