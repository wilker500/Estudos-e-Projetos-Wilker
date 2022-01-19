using System;

namespace Revisao
{
    class Program 
    {
        // Imprimindo menu de opções ao usuário
        static void Main(string[]args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            // ToUpper usado para comparar X maisculo com  X minúsculo

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        // corrigindo o erro abaixo  Não é possível converter implicitamente tipo "string" em "int" [Revisao]

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                        aluno.Nota = nota;
                        }
                        else 
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");

                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                                          


                        break;

                    case "2":
                        //TODO: Listar alunos
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                
                                Console.WriteLine($"Aluno: {a.Nome} - Nota {a.Nota}");

                            }
                            
                        }
                        break;

                    case "3":
                        //Calcular média geral
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for (int i =0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome)) 
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }

                        }

                        var mediaGeral = notaTotal/nrAlunos;
                        Conceito conceitoGeral;

                        if(mediaGeral < 2) 
                        {
                          conceitoGeral = Conceito.E;
                        }
                        else if (mediaGeral <4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if (mediaGeral <6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                         else if (mediaGeral <8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else 
                        {
                            conceitoGeral = Conceito.A;
                        }
                    

                        Console.WriteLine($"Média Geral: {mediaGeral} - CONCEITO: {conceitoGeral}");


                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                        // throw new ArgumentOutOfRangeException (); aqui ele informa que se ele enviar algo diferente de opções 1,2,3 ou 4 esta fora do padrão.


                }

                 opcaoUsuario = ObterOpcaoUsuario();







            }


        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}