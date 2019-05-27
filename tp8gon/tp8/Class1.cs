using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp8
{
    public class Empleado
    {
        public enum Nombre { Fabio, Alex, Fede, silvia, Humberto, Susana, Emmanuel, Raul, Ismael, Matias}
        public enum Apellido { Soto, Cordoba, Mamani }
        public enum Trabajo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }
        public enum Estado { casado, soltero }
        public enum Genero { femenino, masculino }

        public Nombre nombre;
        public Apellido apellido; 
        public DateTime nacimiento;//fecha de nacimiento
        public Estado civil;
        public Genero sexo;
        public DateTime ingreso; //fecha de ingreso a la empresa
        public double salarioB;   // sueldo basico
        public Trabajo cargo;
        public int antiguedad;
        public int edad;
        public int jubilacion;
        public double salarioT; //salario a pagar
        /*
        DateTime nacimiento = new DateTime(1998, 5, 22); //Fecha de nacimiento
        int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
        Console.Write(edad);
        */
        public void llenar()
        {
            Random aleatorio = new Random();
            nombre = (Nombre)aleatorio.Next(0, 10);
            apellido = (Apellido)aleatorio.Next(0, 3);
            DateTime start = new DateTime(1995, 1, 1);
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            nacimiento = start.AddDays(aleatorio.Next(range));
            civil = (Estado)aleatorio.Next(0, 2);
            sexo = (Genero)aleatorio.Next(0, 2);
            ingreso = start.AddDays(aleatorio.Next(range));
            salarioB = aleatorio.Next(0, 5000);
            cargo = (Trabajo)aleatorio.Next(0, 5);
            antiguedad = DateTime.Today.AddTicks(-ingreso.Ticks).Year;
            edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            switch (sexo)
            {
                case 0: jubilacion = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 60; break;
                case (Genero)1: jubilacion = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 65; break;
            }
            //CALCULO EL SALARIO
            double adicional;
            if (antiguedad < 21)
            {

                adicional = ((salarioB * 0.02) * (antiguedad));
                switch (cargo)
                {
                    case (Trabajo)2:
                    case (Trabajo)3: adicional = +(adicional * 0.5); break;
                        //default:;break;
                }
                switch (civil)
                {
                    case (Estado)0: adicional = +50000; break;
                }
                salarioT = salarioB + adicional;
            }
            else
            {
                adicional = (salarioB * 0.25);
                salarioT = adicional + salarioB;
            }
        }
        //public void CalcularAntig(DateTime _ingreso) {
        //    antiguedad = DateTime.Today.AddTicks(-_ingreso.Ticks).Year - 1;
        //}

        //public void CalcularEdad(DateTime _nacimiento) {
        //    edad = DateTime.Today.AddTicks(-_nacimiento.Ticks).Year - 1;
        //}

        //public void AnioJu(int _edad, Genero _sexo)
        //{
        //    switch (_sexo)
        //    {
        //        case 0: jubilacion= _edad - 60; break;
        //        case (Genero)1: jubilacion= 65 - _edad; break;
        //    }
        //}

        //public void TotalSalario( double _sueldoB, int _antiguedad)
        //{

        //    if (_antiguedad < 21)
        //    {
        //        double adicional = ((_sueldoB * 0.02) * _antiguedad);
        //        switch (cargo)
        //        {
        //            case (Trabajo)2:
        //            case (Trabajo)3: adicional = +(adicional * 0.5); break;
        //                //default:;break;
        //        }
        //        switch (civil)
        //        {
        //            case (Estado)0: adicional = +50000; break;
        //        }
        //         double salario = _sueldoB + adicional;
        //        salarioT = salarioT + salario;
        //    }
        //    else
        //    {
        //       double  adicional = (_sueldoB * 0.25);
        //       double salario = adicional + _sueldoB;
        //        salarioT = salarioT + salario;
        //    }
        //}

    }
}
