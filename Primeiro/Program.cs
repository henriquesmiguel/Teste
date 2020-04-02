using System;
using System.Globalization;

namespace PrimeiroBase
{
    class Program
    {
        string globalString;
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            TimeSpan t1 = new TimeSpan(900000000);
            TimeSpan t2 = new TimeSpan(700000000);

            Console.WriteLine("Time: " + t1);

            double preco1 = 2100.0, preco2 = 650.50, medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2.ToString("F2")}");
            Console.WriteLine();
            Console.WriteLine("Registo: {0} anos de idade, código {1} e género: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais {0:F8}", medida);
            Console.WriteLine("Arredondado (3 casas decimais) {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));


            int myInt = 1000;
            char myChr = 'T';
            string myStr = "O meu texto";
            sbyte x = 127;
            double myDec = 4.567;
            bool myBool = true;
            int n4;

            n4 = 75;
            x++;
            myInt = myInt + 256;

            if (!myBool)
            {
                Console.WriteLine("Hello World! " + x + myInt);
                Console.WriteLine(myChr);
                Console.WriteLine(myStr.Length);
            }
            else Console.WriteLine("ok é o else");

            double desconto;

            if (n4 > 10) desconto = 100;
            else desconto = 200;

            Console.WriteLine(desconto);

            while (n4 > 50)
            {
                n4--;
                Run(1);
            }

            for (int i = n4; i > 50; i--)
            {
                Run(1);
            }

            Triangle T1 = new Triangle();
            Triangle T2 = new Triangle();

            T1.LadoA = 3.50;

            double areaT1 = T1.Area();
            Console.WriteLine("Area = " + areaT1);

            double? nullD = null;
            double double2 = nullD ?? 15;
            Console.WriteLine("Resultado " + nullD + " :: " + double2 + " THE END!");

            double[] vect = new double[3];
            vect[1] = 3.5;
            Console.WriteLine("Tamanho = " + vect.Length);
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine("nova posição: " + i + " -> " + vect[i]);
            }
            foreach (double val in vect)
            {
                if (val > 0)
                {
                    Console.WriteLine("valor: " + val);
                }
            }

            Course.Produto[] myProducts = new Course.Produto[2];
            myProducts[0] = new Course.Produto("TV", 900.0, 0);

            ProgramMatriz.Run();

        }

        static void Run(int p1)
        {
            Console.WriteLine("Hello World!");
        }

    }
}
