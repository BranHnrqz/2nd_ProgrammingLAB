/* Autores: José Miguel Guardado Quintanilla
            Brandon Rodrigo Henríquez Mejía
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket_SecondLAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supermarket supermarket = new Supermarket();
            User[] user = new User[2];

            //Crear usuarios
            user[0] = new User(1, "SU", "Tomatito123", 22, "Admin", supermarket);
            user[1] = new User(2, "Bob", "1234", 25, "Vendedor", supermarket);

            Console.WriteLine("Bienvenido, inicie sesion");
            Console.WriteLine("Nombre de usuario");
            string User = Console.ReadLine();
            Console.WriteLine("Contraseña");
            string Pass = Console.ReadLine();

            int Level = 0;
            for (int i = 0; i < user.Length; i++)
            {
                if (User == user[i].UserName && Pass == user[i].Password)
                {
                    if (user[i].Level == "Admin")
                    {
                        Level = 1;
                    }
                    if (user[i].Level == "Vendedor")
                    {
                        Level = 2;
                    }
                }
            }

            if (Level == 1)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("¨1) Agregar categoria");
                Console.WriteLine("¨2) Agregar categoria");
                Console.WriteLine("¨3) Crear categoria");
                Console.WriteLine("¿Qué desea hacer?");
            }
            Console.WriteLine(Level);
            Console.ReadLine();
        }
    }
}
