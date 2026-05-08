class SistemaViejo
{
    public void EjecutarViejo()
    {
        Console.WriteLine("Sistema viejo");
    }
}

class Adaptador
{
    private SistemaViejo viejo = new SistemaViejo();

    public void Ejecutar()
    {
        viejo.EjecutarViejo();
    }
}