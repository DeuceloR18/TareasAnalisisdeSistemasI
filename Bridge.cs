interface IDibujo
{
    void Dibujar();
}

class Circulo : IDibujo
{
    public void Dibujar()
    {
        Console.WriteLine("Dibujando círculo");
    }
}