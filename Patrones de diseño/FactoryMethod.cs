using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño
{
    using System;

    interface IVehiculo
    {
        void Mostrar();
    }

    class Carro : IVehiculo
    {
        public void Mostrar()
        {
            Console.WriteLine("Se creó un carro");
        }
    }

    class Moto : IVehiculo
    {
        public void Mostrar()
        {
            Console.WriteLine("Se creó una moto");
        }
    }

    class FabricaVehiculo
    {
        public static IVehiculo Crear(string tipo)
        {
            if (tipo == "carro")
                return new Carro();

            return new Moto();
        }
    }
}
