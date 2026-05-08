class Computadora
{
    public string CPU;
    public string RAM;
}

class ComputadoraBuilder
{
    private Computadora pc = new Computadora();

    public ComputadoraBuilder AgregarCPU(string cpu)
    {
        pc.CPU = cpu;
        return this;
    }

    public ComputadoraBuilder AgregarRAM(string ram)
    {
        pc.RAM = ram;
        return this;
    }

    public Computadora Build()
    {
        return pc;
    }
}