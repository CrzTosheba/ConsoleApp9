using System;
class Program
{
        static void Main(string[] args)
    {
      
        static (string Name, string LastName, int Age) EnterUser()
        {
            (string Name, string LastName, int Age) User;
            (bool HasPet, string[] PetName) Pet;
            (string[] NumColor, string[] FavColor) Color;
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();
            
            
            Console.WriteLine("Введите возраст цифрами");
            User.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Есть ли у вас животные?");

            var PetResult = Console.ReadLine();
            if (PetResult == "Да")
            {
                Pet.HasPet = true;
                
            }
            else
            {
                Pet.HasPet = false;
            }





            return User;
            }
            EnterUser();


        

        


    }
   
 
    



    
}