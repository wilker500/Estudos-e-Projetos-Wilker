using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }

        //Posso declarar variáveis.
        //No exemplo acima declarei inteiro a =1, inteiro b como 2, inteiro c como 3.
        // O resultado final é 10 com a soma do WriteLine.
        // const indica uma constante ou seja ele não vai mudar esse valor que no caso acima é 4.


        static void InstrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        // String é do tipo texto.
        // array é uma lista.
        //args é o argumentos.
        //arg.lenght == 0 indica que se o argumento for 0 ele irá printar nenhum argumento.
        //atalho comentar ctrl + k +C 


        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }

        //  int numeroDeArgumentos = args.Length; isso estou pegando um array e atribuindo a ele valor inteiro.
        // case 0 , case 1 , default são cada um dos casos do switch.
        // break permite ele sair do switch.

        static void InstrucaoWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        // while estrutura de repetição. (enquanto certa coisa é verdade ele continua a executar)
        // tenho um array de string
        //   while (i < args.Length) enquanto o i for menor que o número de argumentos que tenho vou imprimindo os argumentos de i
        //  i++; equivale a mesma coisa = i = i + 1;
        // while você pode passar algo sem ser executado


        static void InstrucaoDo(string[] args)
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }

        // ele faz a verificação no final
        //  com o do pelo menos uma vez será executado
        // } while (!string.IsNullOrEmpty(texto)); enquanto que o texto não for nulo ou vazio
        // string.IsNullOrEmpty(texto)) sem o ponto de exclamação se o texto for nulo ou vazio.
        // ! ele nega.

        static void InstrucaoFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        // for é o para que executa
        // for (int i = 0; 1ª parte
        // i < args.Length; 2ª parte enquanto i for menor que numero de argumentos executar o for
        // i++) sempre acrescento o i.


        static void InstrucaoForeach(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        // ele executa um for mas a forma de escrever ele é mais simples
        // trabalha com objetos com o foreach
        // foreach (string s in args) para cada string s de cada argumento vou dar um writeline.


        static void InstrucaoBreak(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s))
                {
                    break;
                }

                Console.WriteLine(s);
            }
        }

        // quero executar algo eternamente 
        //  while (true) enquanto for verdadeiro
        //  string s = Console.ReadLine(); ele le algo que o usuario irá preencher
        // if (string.IsNullOrEmpty(s)) se o s for nulo ou vazio ele para o while e sai dele.


        static void InstrucaoContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                {
                    continue;
                }
                
                Console.WriteLine(args[i]);
            }
        }

        // laço de repetição dado alguma situação não quero que ele execute o que esta dentro do for.
        // uso o continue
        // if (args[i].StartsWith("/")) se o i começar com / ele continua vou pro próximo


        static void InstrucaoReturn(string[] args)
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));
            return;
        }

        // int Somar(int a, int b) aqui eu passo um valor para a e b e somo
        // void executa e não retorna nada por isso coloco o Int e ele vai me retornar um valor inteiro 
        // if (args.Length ==0) {return;} ele para a execução do método ele caso vosse colocado antes do console. writeline(1, 2)

        static void InstrucoesTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }

            //   throw new DivideByZeroException(); aqui eu coloquei essa excessão por zero pois não se pode dividir pelo zero.


            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }

            // o que está dentro do try será feito e se der algum erro tenhos os catchs.
            //     double x = double.Parse(args[0]); se for digitado texto ele daria uma excessão.
            
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro genérico: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Até breve!");
            }
        }

        // finally se deu certo quero que ele imprima até breve e se deu errado quero que ele imprimia até breve


        static void InstrucaoUsing(string[] args)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }

        // leitura de arquivos, banco de dados, são do tipo não gerenciável e ao final do uso ele deve descartar da memória.
        // após o using ele elimina o objeto w da minha memória.
    }
}
