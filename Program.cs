using System;

namespace Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string nome;
            int idade;
            float salario;
            string estadoCivil;

            do{
                Console.Write("Digite o seu nome: ");
                nome = Console.ReadLine();
                if(nome == ""){
                    Console.WriteLine("Erro! Digite seu nome completo");
                }

            } while(nome == "");

            do{
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                if(idade <0 || idade>150){
                    Console.WriteLine("Erro. A idade deve ser entre 0 e 150 anos.");
                } 
            }while(idade <0 || idade>150);

            do{
                Console.Write("Digite seu salário: ");
                salario = float.Parse(Console.ReadLine());
                if(salario == 0){
                    Console.WriteLine("Error! O seu salário deve ser maior que zero.");
                }
            }while(salario == 0);

            do{
                Console.Write("Me informe seu estado civil:\r\nSolteiro, casado, divorciado, viuvo: ");
                estadoCivil = Console.ReadLine();
                if(estadoCivil == "S) Solteiro, C) Casado, D) Divorciado, V) Viuvo"){
                    Console.WriteLine("Error! Por favor, selecione seu status civil.");
                }
            }while(estadoCivil == "S) Solteiro, C) Casado, D) Divorciado, V) Viuvo: ");

            Console.WriteLine("Nome: " + nome );
                Console.WriteLine("Idade: " +idade + " anos");
                Console.WriteLine("Salário: " + salario + " reais");
                Console.WriteLine("Estado civil: " + estadoCivil);
        

}   

    }
}
