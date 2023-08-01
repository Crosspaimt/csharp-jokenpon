




public class jokenpon
{

    static void Main()
    {

        Console.WriteLine("1 = pedra");
        Console.WriteLine("2 = papel");
        Console.WriteLine("3 = tesoura");

        Console.WriteLine("bota o numero");
        int num = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int num2 = random.Next(1, 4);
        Console.WriteLine(num2);


        if (num == num2)
        { 

            Console.WriteLine("empate");
       
        }
        else { Console.WriteLine("perdeu"); }
        
        if (num2 == 2)
        {

            if (num == 3)
            {

                Console.WriteLine("ganhou");
            }
        }
        if (num2 == 3)
        {

            if (num == 2)
            {

                Console.WriteLine("ganhou");
            }
        }
       
        if (num2 == 1)
        {

            if (num == 2)
            {

                Console.WriteLine("ganhou");
            }          
        }



    }
}
