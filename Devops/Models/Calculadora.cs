namespace Devops.Models;

public class Calculadora
{
    public int A { get; set; }
    public int B { get; set; }

    public static int Soma(int A, int B) => A + B;
}
