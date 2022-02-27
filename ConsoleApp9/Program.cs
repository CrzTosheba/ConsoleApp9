using System;
class Program
{
        static void Main(string[] args)
    {
        static (string Name,  string LastName, int Age) EnterUser()
        {
            (string Name, string LastName, int Age) User;
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();
            
            
            Console.WriteLine("Введите возраст цифрами");
            User.Age = int.Parse(Console.ReadLine());










            /*Console.WriteLine("У вас есть питомец?");
            User.HavePet = Console.ReadLine();*/




            return User;
        }
        EnterUser();
        
        
    }
   
 
    



    
}