using System;

namespace Elefante
{
    class Program
    {
        static void Main(string[] args)
        {

            int qnt;
            int cont1 = 0;
            int cont2;
            
            string flexao;

            Console.Write("Quantos elefantes: ");
            qnt = Convert.ToInt32(Console.ReadLine());

            cont2 = qnt;

            while (cont2 > 1)
            {
                cont1++;
                
                

                if(cont1 > 1){

                flexao = "elefantes";
                }else{
                    flexao = "elefante";
                }

                Console.Write($"{cont1} {flexao} incomoda muita gente\n{cont1 + 1} {flexao} ");

                while (qnt > 1)
                {
                    qnt--;
                    qnt--;
                     Console.Write("incomodam ");
                }
                        
                qnt = cont1;
                Console.WriteLine("muito mais");
                cont2--;
                
            }

            

            
        }
    }
}
