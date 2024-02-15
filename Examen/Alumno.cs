
using System;

public abstract class Alumno
{
    public string Nombre { get; set; }
    public string NumeroCuenta { get; set; }
    public string Email { get; set; }

    public abstract void Imprimir();
}
