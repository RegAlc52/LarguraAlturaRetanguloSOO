using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a largura do retângulo:");
        double largura;
        while (!double.TryParse(Console.ReadLine(), out largura) || largura <= 0)
        {
            Console.WriteLine("Valor inválido. Digite novamente a largura do retângulo:");
        }

        Console.WriteLine("Digite a altura do retângulo:");
        double altura;
        while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
        {
            Console.WriteLine("Valor inválido. Digite novamente a altura do retângulo:");
        }

        double area = largura * altura;
        double perimetro = 2 * (largura + altura); 
        double diagonal = Math.Sqrt(largura * largura + altura * altura); //Math.Sqrt apliquei p/ calcular a raiz

        Console.WriteLine($"Área: {area}");
        Console.WriteLine($"Perímetro: {perimetro}");
        Console.WriteLine($"Diagonal: {diagonal}");
    }
}


//Faça um programa que leia os valores 
//a largura de um retângulo = double
//a altura de um retangulo = double
//Em seguida, mostrar na tela o valor de 
//sua área, perímetro e diagonal. 
//Informe se o valor é valido ou inválido
//Solicite novamente a largura do retângulo
//Solicite novamente a altura do retângulo
// OBs:Verificar os calculos.
// Um triangulo tem 
//CalcularArea() : double, 
//CalcularPerimetro: double
//CalcularDiagonal(): double
//conter os Métodossing System;using System;
//Sem Orientação a Objetos