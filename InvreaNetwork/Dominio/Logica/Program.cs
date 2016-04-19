using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {
           // ADI adi = new ADI();
           // GP gp = new GP();
           // RRHH rrhh = new RRHH();

           //// ANTONIO List<Proyecto> listaPro = gp.ListaProyecto;
           // adi.insertarActivo("neny", "nelly", 8, 10000);
           // adi.insertarActivo("tony", "Mueble", 8, 10000);
           // adi.insertarActivo("ferrari", "carro", 8, 10000);
           // DateTime f1 = new DateTime();
           // DateTime f2 = new DateTime();
           // gp.insertarProyecto("bonita", "neny", f1, f2, 10000);
           // gp.insertarProyecto("cosita", "tony", f1, f2, 10000);
           // gp.insertarProyecto("loco", "coco", f1, f2, 10000);
           // gp.insertarProyecto("loco", "coquito", f1, f2, 10000);
           // rrhh.insertarEmpleado("nelly", "fernandez", f1, "gerente", 18223442, 100000, f2);
           // rrhh.insertarEmpleado("antonio", "Sanchez", f1, "obrero", 18223441, 100000, f2);
           // rrhh.insertarEmpleado("luisana", "fernandez", f1, "secretaria", 18223440, 100000, f2);

           // Console.WriteLine("PROYECTOS:");
           // foreach (Proyecto proyecto in gp.ListaProyecto)
           // {
           //     Console.WriteLine(proyecto);
           // }

           // Console.WriteLine("\n");

           // Console.WriteLine("Inventario");
           // foreach (Activo proyecto in adi.ListaInventario)
           // {
           //     Console.WriteLine(proyecto);
           // }
           // Console.WriteLine("\n");
           // Console.WriteLine("Empleados:");
           // foreach (Empleado proyecto in rrhh.ListaEmpleado)
           // {
           //     Console.WriteLine(proyecto);
           // }
           // gp.eliminarProyecto("bonitota");
           // rrhh.eliminarEmpleado(18223449);
           // adi.eliminarActivo("ferrauigyi");
           // Console.WriteLine("sin bonita, luisana, ferrari");
           // Console.WriteLine("PROYECTOS:");
           // foreach (Proyecto proyecto in gp.ListaProyecto)
           // {
           //     Console.WriteLine(proyecto);
           // }

           // Console.WriteLine("\n");

           // Console.WriteLine("Inventario");
           // foreach (Activo proyecto in adi.ListaInventario)
           // {
           //     Console.WriteLine(proyecto);
           // }
           // Console.WriteLine("\n");
           // Console.WriteLine("Empleados:");
           // foreach (Empleado proyecto in rrhh.ListaEmpleado)
           // {
           //     Console.WriteLine(proyecto);
           // }


            Servidor servidor = new Servidor();
            servidor.encender();
            servidor.escuchar();

            Console.ReadKey();


        }
    }
}
