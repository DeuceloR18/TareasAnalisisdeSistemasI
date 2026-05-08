class Persona
{
    public string Nombre;

    public Persona Clonar()
    {
        return (Persona)this.MemberwiseClone();
    }
}