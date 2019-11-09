using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DixonBriones3A_Trabajo3.Clases;
namespace DixonBriones3A_Trabajo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int gaso = 0;
            Cliente cliente = new Cliente();
            Gasolina gasolina = new Gasolina();
            Console.WriteLine("Ingrese la cedula");
            cliente.Cedula =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido");
            cliente.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su dirección");
            cliente.Direccion = Console.ReadLine();
            do
            {
                Console.WriteLine("Escoja el tipo de gasolina \n" +
                                   "1.Extra\n" +
                                   "2.Super");
                gaso = int.Parse(Console.ReadLine());
                switch (gaso)
                {
                    case 1:
                        gasolina.Tipo = "Extra";
                        break;
                    case 2:
                        gasolina.Tipo = "Super";
                        break;
                    default:
                        Console.WriteLine("No existe gasolina con el numero ingresado");
                        break;

                }
            } while (gaso!=1 && gaso!=2);
            Console.WriteLine("Ingrese la cantidad de gasolina en galones");
            gasolina.Cantidad = int.Parse(Console.ReadLine());
            float subtotal =gasolina.Precio * gasolina.Cantidad;
            Console.WriteLine("Apellido y Nombre: " + cliente.Apellido + " " + cliente.Nombre + "\nCedula: "+cliente.Cedula+ "\nDireccion: "+cliente.Direccion
                              + "\nTipo de gasolina: " + gasolina.Tipo+ "\nPrecio de gasolina por galon: "+gasolina.Precio+ "\nCantidad de galones"+gasolina.Cantidad+
                              "\nSUBTOTAL: "+subtotal+ "\nIVA: "+(subtotal*0.12)+ "\nTOTAL A PAGAR: "+(subtotal+(subtotal*0.12)));
            Console.ReadKey();
        }
    }
}
