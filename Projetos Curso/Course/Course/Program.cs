using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {//Using System é importante para abrangir maior gama de comandos, como o SByte que é um comando .net
         //enquanto o sbyte é um comando genérico exclusivo C#

               bool completo = false;
               Console.WriteLine(completo);
               char genero = 'F';
               Console.WriteLine(genero);
               char letra = '\u0041';//Letra A em Unicode,código entre aspas simples, precedido por barra invertida
               Console.WriteLine(letra);

               sbyte x = 100; //1 byte com sinal
               byte n1 = 126; //1 byte sem sinal
               int n2 = 1000; //4 bytes com sinal
               int n3 = 2147483647;
               long n4 = 2147483648L; //8 bytes com sinal
               float n5 = 4.5F;//A letra F se faz necessária para indicar explicitamente que se trata de um valor Float
               double n6 = 4.8;
               string nome = "Taynara Veloso";//Quando é um único caractere, usa-se aspas simples, em caso de palavras e frases
                                              //usa=se String e aspas duplas.
                                              //String se trata de uma cadeia de caracteres Unicode imutáveis. Uma vez declarados não podem ser alterados.
               object obj1 = "Ao Ghast";
               object obj2 = 19f;
               //Classe Object tem seus valores genéricos, podendo ser atribuída qualquer valor de quaisquer outras classes.

               Console.WriteLine(n1);
               Console.WriteLine(n2);
               Console.WriteLine(n3);
               Console.WriteLine(n4);
               Console.WriteLine(n5);
               Console.WriteLine(n6);
               Console.WriteLine(nome);
               Console.WriteLine(obj1);
               Console.WriteLine(obj2);
               Console.WriteLine(x);

            int idade = 21;
            int saldo = 100;
            string pessoa = "Pretinha";
            Console.WriteLine("{0} tem {1} anos e {2} reais no banco", pessoa, idade, saldo);
            //As chaves são "Placeholders", elas reservam o espaço para inserir a variável posteriormente.
            Console.WriteLine($"{pessoa} tem {idade} anos e {saldo} reais no banco");
            //Começando com o Cifrão, usa-se a interpolação.
            Console.WriteLine(pessoa + " tem " + idade + " anos e " + saldo + " reais no banco");
            //Concatenação simples

/*
            int n1 = int.MaxValue;
            sbyte n2 = sbyte.MaxValue;
            object n3 = n2 + n1; //não resolvido
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);*/
        }

    }
}
