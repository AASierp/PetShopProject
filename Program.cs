using PetShopPart1;
using System;
using System.ComponentModel.Design;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetShopPart1

{

    public class Program
    {
        public static void Main(string[] args)
        {

            var productLogic = new ProductLogic();

            //DogLeash dogLeash = new DogLeash(0, "", 0);

            //Console.WriteLine("Press 1 to add a Leash to Product inventory.\n");
            //Console.WriteLine("Press 2 to view a Product in inventory.\n");
            //Console.WriteLine("Type Exit to Quit.\n");

            //string userInput = Console.ReadLine();

            var userInput = "";

            while (userInput != "exit")
            {
        
                if (userInput == "1")
                {

                    var dogLeash = new DogLeash();
                        
                    Console.WriteLine("What is the name of the Leash?\n");

                    dogLeash.Name = Console.ReadLine();
                    
                    Console.WriteLine("What Material is the Leash made of?.\n");

                    dogLeash.Material = Console.ReadLine();
                    
                    Console.WriteLine("And how many inches is the Leash?\n");

                    dogLeash.LengthInches = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is the Price of the Leash?\n");
                    dogLeash.Price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("How many Leashes would you like to add to inventory?\n");
                    dogLeash.Quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please provide a short descrition of the product.\n");
                    dogLeash.Description = Console.ReadLine(); 
                    Console.WriteLine();

                    //Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                    //Console.WriteLine();

                    productLogic.addProduct(dogLeash);

                    Console.WriteLine($"Item {dogLeash.Name} was added to inventory.\n");
               
                }
                if (userInput == "2") 
                { 
                    Console.WriteLine("What is the name of the product you would like to view?\n");
                    var dogLeashName = Console.ReadLine();
                    var dogLeash = productLogic.GetDogLeashByName(dogLeashName);
                    if (dogLeash == null)
                        Console.WriteLine("Product cannot be found.");

                    Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                    Console.WriteLine();
                }

                

                Console.WriteLine("Press 1 to add a Leash to Product inventory.\n");
                Console.WriteLine("Press 2 to view a Product in inventory.\n");
                Console.WriteLine("Type Exit to Quit.\n");

                userInput = Console.ReadLine();


            }

            
        }
    }
}