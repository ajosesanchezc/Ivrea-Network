using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Proyecto
    {
        private String codigo;
        private float presupuesto;
        private String nombre;
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public Proyecto() { }


        public override string ToString()
        {
            String cadena = "Nombre: " + nombre + " Codig " + codigo;
            return cadena;
        }

        public Proyecto(String codigo, String nombre, DateTime fechaInicio, DateTime fechaFin, float presupuesto)
        {
           this.codigo = codigo;
           this.nombre = nombre;
           this.fechaFin = fechaFin;
           this.fechaInicio = fechaInicio;
           this.presupuesto = presupuesto;
        }
        
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
       

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        

        public float Presupuesto
        {
            get { return presupuesto; }
            set { presupuesto = value; }
        }


    }
}
