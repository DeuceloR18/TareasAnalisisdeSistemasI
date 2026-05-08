using System.Collections.Generic;

class Nodo
{
    public string Nombre;
    public List<Nodo> Hijos = new List<Nodo>();

    public void Agregar(Nodo nodo)
    {
        Hijos.Add(nodo);
    }
}