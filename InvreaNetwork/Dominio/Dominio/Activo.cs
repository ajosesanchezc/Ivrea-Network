using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Activo
    {
        private String codigo;
        private String nombre;
        private int cantidad;
        private float precio;

        public Activo() { }

        public override string ToString()
        {
            String cadena = "Nombre: " + nombre + " Cod " + codigo;
            return cadena;
        }

        public Activo(String codigo, String nombre, int cantidad, float precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad
         {
           get { return cantidad; }
           set { cantidad = value; }
          }

         public String Nombre
         {
           get { return nombre; }
           set { nombre = value; }
         }

         public String Codigo
         {
           get { return codigo; }
           set { codigo = value; }
          }

    }
}
