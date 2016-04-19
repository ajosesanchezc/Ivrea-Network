using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;



namespace AccesoDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADI adi = new ADI();
            //adi.insertarActivo("Efg2", "Escritotio", 8, 10000);
            //adi.insertarActivo("M2pi", "Mueble", 8, 10000);
            //adi.insertarActivo("ferrari", "carro", 8, 10000);
            ////LUEGO DE PRUEBAS ELIMINAR REFERENCIA "Logica"
            ////RECORDAR MANEJAR EXCEPCION O VALIDAR DE ARCHIVO CUANDO EL PATH NO EXISTE
            //Txt txt = new Txt();
            //txt.guardarListaInventario(adi.ListaInventario);
            //List<Activo> listaInv = txt.cargarListaInventario();

            //Console.WriteLine("Lista leida desde archivo");
            //foreach (Activo activo in listaInv)
            //    Console.WriteLine(activo.Nombre);
            //Console.ReadKey();


            Txt txt = new Txt();


            List<Usuario> lista = new List<Usuario>();
            Usuario usuar = new Usuario("tony","123","RRH");
            lista.Add(usuar);

            Usuario usar1 = new Usuario("tony", "312", "gp");
            lista.Add(usar1);

            Usuario usar2 = new Usuario("nelly", "d12", "ADI");
            lista.Add(usar2);
            Usuario usar3 = new Usuario("paty", "353", "rrh");
            lista.Add(usar3);


            txt.guardarListaUsuario(lista);


            Console.ReadKey();

        }
    }
}
