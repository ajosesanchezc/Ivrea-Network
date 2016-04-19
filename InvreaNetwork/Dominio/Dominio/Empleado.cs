using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
     public class Empleado
    {
        private String nombre;
        private String apellido;
        private DateTime fechaIngreso;
        private String cargo;
        private long CI;
        private float costo;
        private DateTime fechaNac;

        public override string ToString()
        {
            String cadena = "Nombre: " + nombre + " Apell " + apellido + " CI " + CI + "car " + cargo;
            return cadena;
        }

        public Empleado()
        { }

        public Empleado(String nombre, String apellido, DateTime fechaIngreso, String cargo, long CI, float costo, DateTime fechaNac)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaIngreso = fechaIngreso;
            this.cargo = cargo;
            this.CI = CI;
            this.costo = costo;
            this.fechaNac = fechaNac;
        }


        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
       
        public float Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        
        public long CI1
        {
            get { return CI; }
            set { CI = value; }
        }
       
        public String Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }


        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
       
        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        

    }
}
