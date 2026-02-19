using System;
using System.Collections.Generic;

namespace Pizzanapoli
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine(" Bienvenido a la Pizzería ");
        Console.WriteLine("¿Desea una pizza vegetariana o una pizza no vegeriana?");
        Console.WriteLine("(todas las pizzas llevan de base Mozarella y tomate)");
        Console.WriteLine("1 - vegetariana");
        Console.WriteLine("2 - No vegetariana");
        Console.Write("Seleccione una opción: ");

        string pizza_type = "";
        string ingredient_type = "";
        string input = Console.ReadLine()!;

        if (input == "1")
        {
            pizza_type = "Vegetariana";

            Console.WriteLine("\nIngredientes disponibles:");

            Console.WriteLine("1 - Pimiento");
            Console.WriteLine("2 - Tofu");
            

            string opcionIngrediente = Console.ReadLine()!;

            if (opcionIngrediente == "1") 
            {
                ingredient_type = "Pimiento";
            }
            else if (opcionIngrediente == "2")
            {
                ingredient_type = "Tofu";
            }
            else
            {
                Console.WriteLine("Opción inválida.");
                return;
            }
        }
        else if (input == "2")
        {
            pizza_type = "No Vegetariana";

            Console.WriteLine("\nIngredientes disponibles:");
            Console.WriteLine("1 - Peperoni ");
            Console.WriteLine("2 - Jamón ");
            Console.WriteLine("3 - Salmón ");
           

            string opcionIngrediente = Console.ReadLine()!;

            if (opcionIngrediente == "1")
            {
                ingredient_type = "Peperoni";
            }
            else if (opcionIngrediente == "2")
            {
                ingredient_type = "Jamón";
            }
            else if (ingredient_type == "3")
            {
                ingredient_type = "Salmón";
            }
            else
            {
                Console.WriteLine("Opción inválida.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Opción inválida.");
            return;
        }

        Console.WriteLine("\n -- Resumen de su pedido -- ");
        Console.WriteLine($"Tipo de pizza: {pizza_type}");
        Console.WriteLine($"Ingredientes: Tomate, Mozzarella, {ingredient_type  }");
        

            
        }
    }
}


/*class Program
{
    static void Main(string[]args)
    {
        List<string> pizza_type = new List<string>(){"vegetariana","no vegetariana"};

        List<List<string>> pizza_ingredients = new List<List<string>>()
         {
                new List<string>{"Pimiento","tofu"},
                new List<string>{"Peperoni","pollo","salmon"}
        };
        Console.WriteLine("------------Bienvenido a Bella Napoli.-------------");

        Console.WriteLine("Favor seleccionar el tipo de pizza que desea:");

        for(int i = 0; i< pizza_type.Count; i++)
            {
                Console.WriteLine($"{i+1}.{pizza_type[i]}");
            }
                
             int selected_pizza_type = int.Parse(Console.ReadLine()!)-1 ; 
             Console.WriteLine($"\nseleccionaste:\n{pizza_type[selected_pizza_type]}\n");

            Console.WriteLine("selecciona los ingredientes");

        for(int i = 0; i< pizza_ingredients[selected_pizza_type].Count; i++)
            {
                Console.WriteLine($"{i+1}.{pizza_ingredients[selected_pizza_type][i]}");
            }
                
             int ingredients = int.Parse(Console.ReadLine()!)-1 ; 
             Console.WriteLine($"\nTu eleccion\n\n{ingredients}");

             Console.WriteLine($"la pizza que seleccionaste es {pizza_type[selected_pizza_type]}, y los ingredientes: {pizza_ingredients[selected_pizza_type][ingredients]}");

    } 
}

}*/