
using System;

class Program
{
    static void Main()
    {
        try {

            // Ingresar datos del alumno
            Console.WriteLine("Ingrese los datos del alumno:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Número de Cuenta: ");
            string numeroCuenta = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("--------------------------------------------------");

            // Ingresar datos de la asignatura
            Console.WriteLine("\nIngrese los datos de la asignatura:");
            Console.Write("Nombre de la Asignatura: ");
            string nombreAsignatura = Console.ReadLine();
            Console.Write("Horario: ");
            string horario = Console.ReadLine();
            Console.Write("Docente: ");
            string docente = Console.ReadLine();
            Console.Write("--------------------------------------------------");

            // Crear objeto de la clase Asignatura y asignar valores
            Asignatura asignatura = new Asignatura
            {
                Nombre = nombre,
                NumeroCuenta = numeroCuenta,
                Email = email,
                NombreAsignatura = nombreAsignatura,
                Horario = horario,
                Docente = docente
            };


            // Ingresar notas parciales
            Console.WriteLine("\nIngrese las notas parciales:");
            Console.Write("Nota Parcial 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota Parcial 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota Parcial 3: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            // Crear objeto de la clase Nota y asignar valores
            Nota notas = new Nota(nota1, nota2, nota3);

            // Imprimir datos del alumno y la asignatura
            asignatura.Imprimir();


            // Calcular la nota final
            double notaFinal = notas.CalcularNotaFinal(nota1, nota2, nota3);

            // Mostrar mensaje de la nota final
            Console.WriteLine($"\nSu Nota Final: {notaFinal}%  ({notas.MensajeNota(notaFinal)})");
            Console.Write("**************************************************");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
