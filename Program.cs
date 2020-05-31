using System;

namespace Prueba_Programación_Avanzada_Rodrigo_Morales
{
    class Program
    {
        private class auto
        {
            public int numChasis { get; set; }
            public int cilindrada { get; set; }
            public double precio { get; set; }
            public string tipoAuto { get; set; }
            public int tipoTraccion { get; set; }
            public int version { get; set; }
            
        
        }

        static void Main(string[] args)
        {
            int respuesta = 0;
            do
            {
                Console.WriteLine("Bienvenido al Registro de venta de Automóviles de FranceCar!");
                Console.WriteLine("############################################################################");
                Console.WriteLine("Por Favor ingrese que desea hacer, seleccionando el número correspondiente: ");
                Console.WriteLine("1) Agregar un nuevo Auto");
                Console.WriteLine("2) Mostrar todos los Autos");
                Console.WriteLine("4) Mostrar cantidad Autos Costosos");
                Console.WriteLine("5) Elimiar auto");
                Console.WriteLine("6) Salir de la aplicación");
                Console.WriteLine("############################################################################");
                respuesta = int.Parse(Console.ReadLine());
            } while (respuesta < 0 && respuesta > 6);

        }
    }
}
/*
 Desde la clase que contiene el main debe:
• Agregar un Auto Suv y un Auto Sedán a la colección.
• Debe mostrar el total final para el Auto Suv.
• Obtener la cantidad de Autos caros.
• Eliminar un Auto
 */

/*
 Validar todas las opciones en el despliegue tipo menú o similar
* Uso de Colecciones obligatorio, al menos 1.
 */
