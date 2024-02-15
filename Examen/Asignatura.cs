
using System;

public class Asignatura : Alumno
{
    public string NombreAsignatura { get; set; }
    public string Horario { get; set; }
    public string Docente { get; set; }

    public override void Imprimir()
    {
        Console.Write("**************************************************\n");
        Console.WriteLine($"Nombre del estudiante: {Nombre}");
        Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Nombre de la clase: {NombreAsignatura}");
        Console.WriteLine($"Horario: {Horario}");
        Console.WriteLine($"Nombre del docente: {Docente}");
    }
}
