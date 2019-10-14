using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{

    public class Repostore
    {
        List<Product> products = new List<Product>();
        List<Category> categories = new List<Category>();
        int c = 0, n = 0;
        public List<Product> ListProduct()
        {
            List<Product> producto = new List<Product>();



            return producto;
        }
        public List<Category> ListCategory()
        {
            List<Category> category = new List<Category>();



            return category;
        }
        public void GetProduct()
        {
            Console.Write("Indique la cantidad de productos que desea agregar: ");
            c = Convert.ToInt32(Console.ReadLine());
            var count = products.Count;

            
            for (int i = 0; i < c; i++)
            {
                
                Product p1 = new Product();
                Category category = new Category();
                Console.Write("Ingrese el el nombre del producto: ");
                p1.Name = Console.ReadLine();
                Console.Write("Ingrese una descripcion: ");
                p1.Descrciption = Console.ReadLine();
                Console.Write("Ingrese el precio: ");
                p1.Price = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Ingrese la cantidad en stock del producto: ");
                p1.Quality = Convert.ToInt32(Console.ReadLine());
                Console.Write("De una descripcion a la categoria: ");
                category.Description = Console.ReadLine();
                count +=1 ;
                p1.Id = count;
                category.Id = count;
                products.Add(p1);
                categories.Add(category);
            }

        }
        public void ShowProduct(Product p)
        {
            
            Console.WriteLine("El nombre del producto es: " + p.Name + "\nDescripcion: " + p.Descrciption + "\nPrecio: " + p.Price + "\nCantidad en stock: " + p.Quality);
        }

        public void ListProduct(List<Product> p)
        {
            Console.WriteLine("Productos existentes");
            for (int i = 0; i < c; i++)
            {

                Console.WriteLine("El Id del Producto es: " + p[i].Id + "\nEl nombre del producto es: " + p[i].Name + "\nDescripcion: " + p[i].Descrciption + "\nPrecio: " + p[i].Price + "\nCantidad en stock: " + p[i].Quality);
            }

        }
        public void ShowProductByCategory(List<Category> cat)
        {
            Console.Write("Indique el producto del cual desea saver la categoria");
            n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El Id del Producto es: " + cat[n-1].Id + "\nLa categoria es: " + cat[n-1].Description);

            
        }
        public void Menu()
        {
            Product pro = new Product();
            
            Console.WriteLine("Este es  nuestro menu: ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1.- Agregar producto");
            Console.WriteLine("2.- Mostrar producto");
            Console.WriteLine("3.- Ver lista de productos");
            Console.WriteLine("4.- Ver las categorias");
            Console.WriteLine("5.- Salir");
            Console.Write("\nSeleccione la opcion que desea: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    GetProduct();
                    Menu();
                    break;
                case 2:
                    ShowProduct(pro);
                    Menu();
                    break;
                case 3:
                    ListProduct(products);
                    Menu();
                    break;
                case 4:
                    ShowProductByCategory(categories);
                    Menu();
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
            }
        }


    }
}
