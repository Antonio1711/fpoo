using System;

namespace Cs
{
    class Ex5
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x0, x1, x2;

            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            x0 = -b + Math.Sqrt(delta);
            x1 = (-b + Math.Sqrt(delta) / (2 * a));
            x2 = (-b - Math.Sqrt(delta) / (2 * a));

            if(delta > 0){
                Console.WriteLine("Seu X1 é igual a " + x1);
                Console.WriteLine("Seu X2 é igual a " + x2);
            }
            else if(delta < 0){
                Console.WriteLine("A operação não possui raiz. Então o resultado é igual a delta, que é: " + delta);
            }
            else{
                Console.WriteLine("O resultado é " + x0);
            }
        }   
    }
}