using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - done
            // give this class 4 members that all Animals have in common - done


            // Create a class Bird -  done
            // give this class 4 members that are specific to Bird - done
            // Set this class to inherit from your Animal Class - done

            // Create a class Reptile - done
            // give this class 4 members that are specific to Reptile - done
            // Set this class to inherit from your Animal Class - done 




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.NeedsSleep = true;
            myBird.eatsWorms = true;
            myBird.wings = 2;
            myBird.Chirps();

            Console.WriteLine("---------------------------------------");

            Console.WriteLine($" I have a bird named Pete.  He has {myBird.wings} wings.  Do you think he like worms? The answer to that is {myBird.eatsWorms} ");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var myReptile = new Reptile();
            myReptile.NeedsSleep = true;
            myReptile.reptileThreatLevel = 1;
            myReptile.Name = "Speedy";
            myReptile.reptileKind = "turtle";

            Console.WriteLine("---------------------");

            Console.WriteLine($"All hail my {myReptile.reptileKind} {myReptile.Name}. " +

                $"He thinks he is a beast, but his threat level isn only a {myReptile.reptileThreatLevel} it is {myReptile.NeedsSleep} he does needs sleep now and again");


            Console.ReadLine();
        }   
        
     }


}

