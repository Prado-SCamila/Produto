using System;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[4];
            string produto= "";
            float valor;
            int quantidade;
            float valorFinal;
            float percentage;

            Console.WriteLine("Escolha um produto dentre os listados abaixo");
            produtos[0] = "Azeite";
            produtos[1] = "Trigo";
            produtos[2] = "Gergelim";
            produtos[3] = "Cerveja";
            

            Console.WriteLine(produtos[0]);
            Console.WriteLine(produtos[1]);
            Console.WriteLine(produtos[2]);
            Console.WriteLine(produtos[3]);
           
            produto = Console.ReadLine();
            
            switch(produto.ToLower()){

                case "azeite":
                     valor = 18.5f;
                     Console.WriteLine(valor+" reais");
                       Console.WriteLine("Digite a quantidade");
            quantidade = int.Parse(Console.ReadLine());

            if(quantidade <=5){
                percentage = 0.02f;
                 valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);
            }else if(quantidade >5 || quantidade <=10){
                percentage = 0.03f;
               valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);
            }else if(quantidade>10){
                percentage = 0.05f;
                 valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);
            }
                break;

                case "trigo":
                    valor = 2;
                    Console.WriteLine(valor+" reais");
                      Console.WriteLine("Digite a quantidade");
            quantidade = int.Parse(Console.ReadLine());

            if(quantidade <=5){
                percentage = 0.02f;
                 valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);
            }else if(quantidade >5 || quantidade <=10){
                percentage = 0.03f;
                 valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);
            }else if(quantidade>10){
                percentage = 0.05f;
                valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);
            }
                break;

                case "gergelim":
                     valor = 4.15f;
                     Console.WriteLine(valor+" reais");
                       Console.WriteLine("Digite a quantidade");
                       quantidade = int.Parse(Console.ReadLine());

            if(quantidade <=5){
                percentage = 0.02f;
                valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);
            }else if(quantidade >5 || quantidade <=10){
                percentage = 0.03f;
                 valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);
            }else if(quantidade>10){
                percentage = 0.05f;
             valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);
            }
                break;

                case "cerveja":
                    valor = 3.8f;
                    Console.WriteLine(valor+ "reais");
                      Console.WriteLine("Digite a quantidade");
            quantidade = int.Parse(Console.ReadLine());

            if(quantidade <=5){
                percentage = 0.02f;
                 valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);

            }else if(quantidade >5 || quantidade <=10){
                percentage = 0.03f;
            valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);

            }else if(quantidade>10){
                percentage = 0.05f;
               valorFinal = (valor *quantidade) - ((valor *quantidade)* percentage);
                Console.WriteLine("Total a pagar:"+valorFinal);
            }
                break;

                default:
                Console.WriteLine("Este produto não está disponível");

                break;
            }
          
            }
            
        }
    }

