using System;

interface IBoton
{
    void Crear();
}

class BotonWindows : IBoton
{
    public void Crear()
    {
        Console.WriteLine("Botón Windows");
    }
}

class BotonLinux : IBoton
{
    public void Crear()
    {
        Console.WriteLine("Botón Linux");
    }
}

class Program
{
    static void Main()
    {
        IBoton boton1 = new BotonWindows();
        boton1.Crear();

        IBoton boton2 = new BotonLinux();
        boton2.Crear();
    }
}