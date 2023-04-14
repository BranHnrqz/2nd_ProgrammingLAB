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


            int Level = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido, inicie sesion");
                Console.WriteLine("Nombre de usuario");
                string User = Console.ReadLine();
                Console.WriteLine("Contraseña");
                string Pass = Console.ReadLine();
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
            } while (Level == 0);

            if (Level == 1)
            {
                do
                {
                    int opc = 0;
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("¿Qué desea hacer?");
                    Console.WriteLine("1) Agregar categoria");
                    Console.WriteLine("2) Eliminar categoria");
                    Console.WriteLine("3) Ver categorias");
                    Console.WriteLine("4) Agregar producto");
                    Console.WriteLine("5) Eliminar producto");
                    Console.WriteLine("6) Ver productos");
                    Console.WriteLine("0) Salir");
                    opc = Convert.ToInt32(Console.ReadLine());

                    switch (opc)
                    {
                        case 0:
                            Level = 0;
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Escriba el nombre de la categoria que desea agregar.");
                            user[0].CreateCategory(Console.ReadLine());
                            break;
                        case 2:
                            Console.Clear();
                            user[0].SeeCategory();
                            Console.WriteLine("Escriba el nombre de la categoria que desea eliminar.");
                            user[0].DeleteCategory(Console.ReadLine());
                            break;
                        case 3:
                            Console.Clear();
                            user[0].SeeCategory();
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            user[0].SeeCategory();
                            Console.WriteLine("Escriba el nombre del producto que desea agregar.");
                            string name = Console.ReadLine();
                            Console.WriteLine("Escriba el proveedor del producto que desea agregar.");
                            string supplier = Console.ReadLine();
                            Console.WriteLine("Escriba la fecha de vencimiento que desea agregar (mm/dd/aaaa).");
                            DateTime expiry = Convert.ToDateTime(Console.ReadLine());
                            DateTime entry = DateTime.Now;
                            Console.WriteLine("Escriba la categoria del producto que desea agregar.");
                            string cat = Console.ReadLine();
                            Console.WriteLine("Escriba el precio del producto que desea agregar.");
                            decimal price = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Escriba las unidades del producto que desea agregar.");
                            int stock = Convert.ToInt32(Console.ReadLine());
                            user[0].CreateProduct(name, supplier, expiry, entry, cat, price, stock);
                            Console.WriteLine("Se ha agregado el producto correctamente.");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            user[0].SeeProduct();
                            Console.WriteLine("Escriba el nombre del producto que desea eliminar.");
                            user[0].CreateCategory(Console.ReadLine());
                            break;
                        case 6:
                            Console.Clear();
                            user[0].SeeAllProduct();
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Opcion no disponible");
                            break;
                    }
                }while (Level != 0) ;


            }
            Console.WriteLine(Level);
            Console.ReadLine();
        }
    }
}
