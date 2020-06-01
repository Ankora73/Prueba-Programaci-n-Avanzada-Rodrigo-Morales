using System;
using System.Collections.Generic;
using System.Linq;

namespace Prueba_Programación_Avanzada_Rodrigo_Morales
{
    class Auto
    {
        private int numChasis, traccion;
        private double precio, cilindrada;
        private string tipoAuto, versionSedan;
        public int NumChasis
        {
            get { return numChasis; }
            set { numChasis = value; }
        }
        public double Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }
        
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Traccion
        {
            get { return traccion; }
            set { traccion = value; }
        }
        public string TipoAuto
        {
            get { return tipoAuto; }
            set { tipoAuto = value; }
        }
        public string VersionSedan
        {
            get { return versionSedan; }
            set { versionSedan = value; }
        }
    }
    class Program
    {
        public static List<Auto> listadoAutos = new List<Auto>();

        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();

        }

        private static void menu()
        {
            var respuesta = "0";
            Console.WriteLine("Bienvenido al Registro de venta de Automóviles de FranceCar!");
            Console.WriteLine("############################################################################");
            Console.WriteLine("Por Favor ingrese que desea hacer, seleccionando el número correspondiente: ");
            Console.WriteLine("1) Agregar un nuevo Auto");
            Console.WriteLine("2) Mostrar todos los Autos");
            Console.WriteLine("3) Mostrar cantidad Autos Costosos");
            Console.WriteLine("4) Elimiar Auto");
            Console.WriteLine("5) Salir de la aplicación");
            Console.WriteLine("############################################################################");
            respuesta = Console.ReadLine();
            switch (respuesta)
            {
                case "1":
                    Console.Clear();
                    agregarNuevoAuto();
                    break;
                case "2":
                    Console.Clear();
                    mostrarTodos();
                    break;
                case "3":
                    Console.Clear();
                    mostrarCantidadAutosCostosos();
                    break;
                case "4":
                    Console.Clear();
                    eliminarAuto();
                    break;
                case "5": Environment.Exit(0);
                    break;
                default:Console.WriteLine("Debe ingresar una opción valida, presione una tecla para continuar");
                    Console.ReadLine();
                    respuesta = "0";
                    Console.Clear();
                    menu();
                    break;
            }

        }
        private static void agregarNuevoAuto()
        {
            Auto auto = new Auto();
            string lane="";
            int numChasis = 0;
            double cilindrada = 0;
            double precio = 0;
            Boolean exist=true;
            Console.WriteLine("###########################################################");
            Console.WriteLine("                   INGRESO DE AUTOMÓVIL                    ");
            Console.WriteLine("###########################################################"+"\n");
            do
            {
                Console.Clear();
                Console.WriteLine("#####################################################");
                Console.WriteLine("             Ingrese número de Chasis");
                Console.WriteLine("#####################################################");
                try
                {
                    exist = false;
                    numChasis = int.Parse(Console.ReadLine());
                    for (int i = 0; i < listadoAutos.Count(); i++)
                    {
                        if (listadoAutos[i].NumChasis==numChasis)
                        {
                            Console.WriteLine("Ya existe un registro con ese número de chasis, ["+i+"] presione una tecla para continuar...");
                            Console.ReadLine();
                            exist = true;
                            break;
                        }
                    }
                    if (exist==false)
                    {
                        auto.NumChasis = numChasis;
                    }
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("ha ingresado un valor incorrecto, presione una tecla para continuar");
                    Console.ReadLine();
                }
                Console.Clear();
            } while (numChasis!=0&&exist==true);
            do
            {
                Console.WriteLine("#####################################################");
                Console.WriteLine("             Ingrese cilindrada del Auto");
                Console.WriteLine("#####################################################");
                try
                {
                    cilindrada = double.Parse(Console.ReadLine());
                    auto.Cilindrada = cilindrada;
                }
                catch (Exception)
                {
                    Console.WriteLine("ha ingresado un valor incorrecto, presione una tecla para continuar");
                    Console.ReadLine();
                    cilindrada = 0;
                }
                Console.Clear();
            } while (cilindrada == 0);
            do
            {
                Console.WriteLine("#####################################################");
                Console.WriteLine("                Ingrese precio del Auto");
                Console.WriteLine("#####################################################");
                try
                {
                    precio = double.Parse(Console.ReadLine());
                    auto.Precio = precio;
                }
                catch (Exception)
                {
                    Console.WriteLine("ha ingresado un valor incorrecto, presione una tecla para continuar");
                    Console.ReadLine();
                }
                Console.Clear();
            } while (precio == 0);
            do
            {
                Console.WriteLine("#####################################################");
                Console.WriteLine("                 ¿Qué tipo de Auto es?             \n");

                Console.WriteLine("     A) Suv                      B) Sedán            ");
                Console.WriteLine("#####################################################");
                lane = Console.ReadLine();
                if (lane.ToUpper().Equals("A"))
                {
                    auto.TipoAuto = "Suv";
                    int traccion = 0;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("#####################################################");
                        Console.WriteLine("         ¿Qué tipo de tracción tiene  2 ó 4 ?        ");
                        Console.WriteLine("#####################################################");
                        try
                        {
                            traccion = int.Parse(Console.ReadLine().Trim());
                            if (traccion==2)
                            {
                                auto.Traccion = traccion;
                            }
                            else if (traccion==4)
                            {
                                auto.Traccion = traccion;
                            }
                            else
                            {
                                Console.WriteLine("ha ingresado un valor incorrecto");
                                traccion = 0;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("ha ingresado un valor incorrecto, presione una tecla para continuar");
                            Console.ReadLine();
                            traccion = 0;
                        }
                        
                    } while (traccion==0);
                }
                else if (lane.ToUpper().Equals("B"))
                {
                    auto.TipoAuto = "Sedán";
                    string tipo = "";
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("#####################################################");
                        Console.WriteLine("             ¿Qué versión de Sedán es A, B, C?       ");
                        Console.WriteLine("#####################################################");
                        tipo = Console.ReadLine();
                        switch (tipo.ToUpper())
                        {
                            case "A": 
                                auto.VersionSedan = tipo.ToUpper().Trim();
                                break;
                            case "B":
                                auto.VersionSedan = tipo.ToUpper().Trim();
                                break;
                            case "C":
                                auto.VersionSedan = tipo.ToUpper().Trim();
                                break;
                            default:
                                Console.WriteLine("Debe ingresar una opción valida, presione una tecla para continuar");
                                Console.ReadLine();
                                tipo = "";
                                Console.Clear();
                                break;
                        }

                    } while (!tipo.ToUpper().Equals("A")&&!tipo.ToUpper().Equals("B")&&!tipo.ToUpper().Equals("C"));

                }
                else
                {
                    Console.WriteLine("ha ingresado un valor incorrecto, presione una tecla para continuar");
                    Console.ReadLine();
                    lane = "";
                }
                Console.Clear();
            } while (lane.ToUpper()!="A"&&lane.ToUpper()!="B");
            Console.Clear();
            listadoAutos.Add(auto);
            Console.WriteLine("Se ha agregado un nuevo auto satisfactoriamente!");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();
            Console.Clear();
            menu();

        }
        private static void mostrarTodos()
        {
            Console.WriteLine("###############################################");
            Console.WriteLine("############ LISTA TOTAL DE AUTOS #############");
            Console.WriteLine("###############################################\n");
            for (int i = 0; i < listadoAutos.Count(); i++)
            {
                Console.WriteLine("###############################################");
                Console.WriteLine("Número de Chasis:    " + listadoAutos[i].NumChasis);
                Console.WriteLine("Cilindrada:          " + listadoAutos[i].Cilindrada);
                Console.WriteLine("Precio:              " + listadoAutos[i].Precio);
                Console.WriteLine("Tipo de Auto:        " + listadoAutos[i].TipoAuto);
                if (listadoAutos[i].TipoAuto.ToUpper().Equals("SUV"))
                {
                    Console.WriteLine("Tracción:            " + listadoAutos[i].Traccion);
                }
                if (listadoAutos[i].TipoAuto.ToUpper().Equals("SEDÁN"))
                {
                    Console.WriteLine("Versión Sedán:       " + listadoAutos[i].VersionSedan);
                }
                Console.WriteLine("###############################################\n");

            }
            Console.WriteLine("\n\n Presione una tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
            menu();
        }
        private static void mostrarCantidadAutosCostosos()
        {
            Console.WriteLine("###############################################");
            Console.WriteLine("########### Total de autos costosos ###########");
            Console.WriteLine("###############################################\n");
            int CantAutosCostosos;
            CantAutosCostosos = 0;
            for (int i = 0; i < listadoAutos.Count(); i++)
            {
                if (listadoAutos[i].Precio > 15000000)
                {
                    CantAutosCostosos = CantAutosCostosos + 1;
                }

            }
            Console.WriteLine("Total: " + CantAutosCostosos);
            Console.WriteLine("\n\n Presione una tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
            menu();

        }
        private static void eliminarAuto()
        {
            int chasis, autosEli;

            chasis = 0;
            autosEli = 0;
            Console.WriteLine("###############################################");
            Console.WriteLine("## Ingrese el numero de chasis a eliminar: ####");
            Console.WriteLine("###############################################\n");
            try
            {
                chasis = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < listadoAutos.Count(); i++)
                {
                    if (listadoAutos[i].NumChasis == chasis)
                    {
                        autosEli = autosEli + 1;
                        listadoAutos.RemoveAt(i);
                        Console.WriteLine("Auto Eliminado");
                        Console.WriteLine("\n\n Presione una tecla para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        menu();
                    }

                }
                if (autosEli == 0)
                {
                    Console.WriteLine("No se encontro un auto con ese chasis");
                    Console.WriteLine("\n\n Presione una tecla para continuar...");
                    Console.ReadLine();
                }
                Console.Clear();
                menu();
            }
            catch (Exception)
            {
                Console.WriteLine("El valor ingresado es incorrecto, presione enter para continuar");
                Console.ReadKey();
                Console.Clear();
                eliminarAuto();

            }
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
