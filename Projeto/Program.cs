using System;

class Forca
{
    private string palavra;
    private char[] letrasDigitadas;
    private char[] letrasCertas;
    private int cont = 6;

    public Forca(string palavra)
    {
        this.palavra = palavra;
        this.letrasDigitadas = new char[palavra.Length];
        this.letrasCertas = new char[palavra.Length];

    }

    public int getCont()
    {
        return cont;
    }


    public void VerificarLetra(char letra)
    {
        if (palavra.Contains(letra))
        {
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    letrasCertas[i] = letra;
                    letrasDigitadas[i] = letra;
                }
            }
        }
        else
        {


            cont--;
        }
    }
    public void ImprimePalavraCorreta()
    {
        Console.WriteLine("A palavra correta era::");
        Console.WriteLine(palavra);
    }

    public void ImprimeLetrasDigitadas()
    {

        Console.WriteLine(letrasDigitadas);
    }

    public bool Ganhou()
    {
        int resultadoComparacao = palavra.CompareTo(new string(letrasCertas));

        if (resultadoComparacao == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DesenharForca(int cont)
    {
        switch (cont)
        {
            case 6:
                Console.WriteLine("-------");
                Console.WriteLine("|     |");
                Console.WriteLine("|   -----");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("\n");
                break;

            case 5:
                Console.WriteLine("-------");
                Console.WriteLine("|     |");
                Console.WriteLine("|   -----");
                Console.WriteLine("|   (o_o)");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("\n");

                break;
            case 4:
                Console.WriteLine("-------");
                Console.WriteLine("|     |");
                Console.WriteLine("|   -----");
                Console.WriteLine("|   (o_o)");
                Console.WriteLine("|     |");
                Console.WriteLine("|     |");
                Console.WriteLine("|     |");
                Console.WriteLine("\n");

                break;
            case 3:
                Console.WriteLine("-------");
                Console.WriteLine("|     |");
                Console.WriteLine("|   -----");
                Console.WriteLine("|   (o_o)");
                Console.WriteLine("| ____|");
                Console.WriteLine("|     |");
                Console.WriteLine("|     |");
                Console.WriteLine("\n");

                break;
            case 2:
                Console.WriteLine("-------");
                Console.WriteLine("|     |");
                Console.WriteLine("|   -----");
                Console.WriteLine("|   (o_o)");
                Console.WriteLine("| ____|____");
                Console.WriteLine("|     |");
                Console.WriteLine("|     |");
                Console.WriteLine("\n");

                break;
            case 1:
                Console.WriteLine("-------");
                Console.WriteLine("|     |");
                Console.WriteLine("|   -----");
                Console.WriteLine("|   (o_o)");
                Console.WriteLine("| ____|____");
                Console.WriteLine("|     |");
                Console.WriteLine("|   __|");
                Console.WriteLine("|   | ");
                Console.WriteLine("|   | ");
                Console.WriteLine("\n");

                break;
            case 0:
                Console.WriteLine("-------");
                Console.WriteLine("|     |");
                Console.WriteLine("|   -----");
                Console.WriteLine("|   (x-x)");
                Console.WriteLine("| ____|____");
                Console.WriteLine("|     |");
                Console.WriteLine("|   __|__");
                Console.WriteLine("|   |    |");
                Console.WriteLine("|   |    |");
                Console.WriteLine("\n");
                Console.WriteLine("\n");

                break;
        }

    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string palavra;
        char letra;
        Console.WriteLine("Bem vindo ao Jogo da Forca\n");
        Console.WriteLine("Digite a palavra: ");
        palavra = Console.ReadLine();
        Forca forca = new Forca(palavra);



        while (forca.getCont() > 0)
        {
            


            Console.WriteLine("Digite uma letra:\n");
            letra = char.Parse(Console.ReadLine());
            forca.VerificarLetra(letra);
            forca.DesenharForca(forca.getCont());
            forca.ImprimeLetrasDigitadas();
            Console.WriteLine("Tentativas Restantes:" + forca.getCont());

            if (forca.Ganhou())
            {
                Console.WriteLine("Parabens voce ganhou!");

                break;
            }

        }

        if (forca.getCont() == 0)
        {
            Console.WriteLine("Que pena, voce perdeu");
            forca.ImprimePalavraCorreta();
        }

    }


}

