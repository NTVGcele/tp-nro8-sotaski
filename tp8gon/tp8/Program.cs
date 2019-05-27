using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp8
{
    class Program
    {
        enum Nombre { Fabio, Alex, Fede, silvia }
        enum Apellido { Soto, Cordoba, Perez, Mamani }
        enum Trabajo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }
        enum Estado { casado, soltero }
        enum Genero { femenino, masculino }


        static void Main(string[] args)
        {
            List<Empleado> Personal = new List<Empleado>();
            Console.Write("Ingrese la cantidad de empleados");
            int cant = int.Parse(Console.ReadLine());
            for(int i = 0; i < cant; i++)
            {
                Empleado nuev = new Empleado();
                nuev.llenar();
                Personal.Add(nuev);
            }
            int numero=1;
            foreach(Empleado mostrar in Personal)
            {
                Console.Write("\n******************************");
                Console.Write("\n\n PERSONA: " + numero);
                Console.Write("\n Nombre: {0}",  mostrar.nombre);
                Console.Write("\n Apellido: {0} ", mostrar.apellido);
                Console.Write("\n Fecha de nacimiento: " + mostrar.nacimiento);
                Console.Write("\n Estado Civil: " + mostrar.civil);
                Console.Write("\n Sexo: " + mostrar.sexo);
                Console.Write("\n Fecha de ingreso a la empresa: " + mostrar.ingreso);
                Console.Write("\n Sueldo basico: " + mostrar.salarioB);
                Console.Write("\n Cargo: " + mostrar.cargo);
                Console.Write("\n Edad: " + mostrar.edad);
                Console.Write("\n Antiguedad: " + mostrar.antiguedad);
                Console.Write("\n Salario: " + mostrar.salarioT);
                numero = numero + 1;
            }

            


            Console.ReadKey();
            
        }


    }
}
