using System;
using System.Globalization;
namespace aula {
    class Promgram {
        static void Main(string[] args) {
            // int age = 44;
            // double countS = 10.5555;
            // string name = "Wint";
            // Console.WriteLine($"A {name} tem {age} anos e tem saldo igual a {countS} reais");
            // int acontes = 1;
            // acontes %= 2;
            // Console.WriteLine(acontes);
            // string S = "ABC";
            // Console.WriteLine(S);
            // S += "DEF";
            // Console.WriteLine(S);
            // int de = 1;
            // de++;
            // Console.WriteLine(de);
            // float imp = 4.5f; 
            // int aimp = (int)imp;
            // Console.WriteLine(aimp);


            try    // utilizando o comando SPLIT [VETORES]
            {
                string[] vetores = Console.ReadLine().Split(' ');
                String posicao1 = vetores[0];
                String posicao2 = vetores[1];
                string posicao3 = vetores[2];
                string posicao4 = vetores[3];
            
                Console.WriteLine($"Nomes: {posicao1} {posicao2} {posicao3} {posicao4}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Informar texto separando com espaços !");                
            }

            // utilizando Parse nos comandos SPLIT [VETORES]
            String[] vetoriz = Console.ReadLine().Split(' ');
            
            string namePerson = vetoriz[0];
            char Sexo = char.Parse(vetoriz[1]);
            int age = int.Parse(vetoriz[2]);
            double altura = double.Parse(vetoriz[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"{namePerson} :");
            Console.WriteLine($"seu Sexo: {Sexo}");
            Console.WriteLine($"Sua Idade: {age}");
            Console.WriteLine($"Sua Altura: {altura.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}