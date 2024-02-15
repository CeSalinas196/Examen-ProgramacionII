
using System;

public class Nota : INota
{
    private double notaParcial1;
    private double notaParcial2;
    private double notaParcial3;

    public Nota(double nota1, double nota2, double nota3)
    {
        if (nota1 > 30 || nota2 > 30 || nota3 > 40)
        {
            throw new ArgumentException("Notas parciales fuera de rango. El primer y segundo parcial no deben superar el 30%, y el tercer parcial no debe superar el 40%.");
        }

        notaParcial1 = nota1;
        notaParcial2 = nota2;
        notaParcial3 = nota3;
    }

    public Nota()
    {
      
    }

    public double CalcularNotaFinal(double notaParcial1, double notaParcial2, double notaParcial3)
    {
        return notaParcial1 + notaParcial2 + notaParcial3;
    }

    public string MensajeNota(double notaFinal)
    {
        if (notaFinal >= 0 && notaFinal < 60)
        {
            return "Reprobado";
        }
        else if (notaFinal >= 60 && notaFinal < 80)
        {
            return "Bueno";
        }
        else if (notaFinal >= 80 && notaFinal < 90)
        {
            return "Muy Bueno";
        }
        else if (notaFinal >= 90 && notaFinal <= 100)
        {
            return "Sobresaliente";
        }
        else
        {
            return "Nota fuera de rango";
        }
    }
}
