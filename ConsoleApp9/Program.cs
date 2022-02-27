using System;
class Program
{
    static void Main()
    {
      var user = EnterUser();
      var pets = GetPet();
      var color = GetColor();

        Console.WriteLine("Ваши ФИО:");
        Console.WriteLine($"Name: {user.Name}; LastName {user.LastName}"); //вывод на экран  пользователя
        Console.WriteLine("Кличка животного");
        foreach (var pet in pets.PetNames) // вывод на экран животных, т.к. там массив может быть, то и вывод такой
        {

            
            Console.WriteLine(pet);

        }
        Console.WriteLine("Любимый цвет");
        foreach (var colors in color.FavColor)
        {
            
            Console.WriteLine(colors);
        }
    
        


    }
    static (string Name, string LastName, int Age) EnterUser() // метод для ввода данных пользователя
    {
        (string Name, string LastName, int Age) User; //  кортеж для пользователя
        //Console.WriteLine("Введите имя");
        User.Name = TryGetValue(string.Format("Введите имя")); // считываем с клавы имя пользователя и принимаем это значение в Name, юзаем метод TryGetValue

        User.LastName = TryGetValue(string.Format("Введите фамилию"));

        Console.WriteLine("Введите возраст");
        User.Age = (int)AskNumber(); // по сути переходим на алгоритм корректного ввода числа и присваиваемс переменной Age
        return User;

    }
    static (bool HavePet, string[] PetNames) GetPet() //метод для животных
    {
        (bool HavePet, string[] PetNames) Pet; //кортеж для животинки

        Console.WriteLine("У вас есть животное?");
        Pet.HavePet = AskYesNo();
        
        
        var animalsCount = 0; // переменная для кол-ва животных
        
        
        if (Pet.HavePet)
        {
            Console.WriteLine("Сколько животных ?");

            animalsCount = (int)AskNumber();
        }
        
        Pet.PetNames = new string[animalsCount];
        for (var i = 0; i < animalsCount; i++)
        {
            Pet.PetNames[i] = TryGetValue(string.Format("Введите кличку животного №{0}", i + 1));
        }


         return Pet;
    }
    static (bool ColorYesNo, string[] FavColor) GetColor() // метод для цвета
    {
        (bool ColorYesNo, string[] FavColor) Color;
        Console.WriteLine("У вас есть любимый цвет?");
        Color.ColorYesNo = AskYesNo();

        var colorCount = 0; 

        if (Color.ColorYesNo)
        {
            Console.WriteLine("Сколько любмых цветов у вас?");
            colorCount = (int)AskNumber();
        }

        Color.FavColor = new string[colorCount];
        for (var i = 0;i < colorCount;i++)
        {
            Color.FavColor[i] = TryGetValue(string.Format("Введите любимый цвет №{0}", i + 1));
        }
        return Color;

    }



    static double AskNumber() // метода для запросов числовых значений, если не число, то выдаем ошибку
    {
        while (true)
        {
            var response = Console.ReadLine();
            if (double.TryParse(response, out var number) && number > 0) // парсим то что ввели и проверяемс
            {
                return number;
            }
            Console.WriteLine("Введено не корректное значение");
        }
    }

    static bool AskYesNo() // метода для запросов да или нет, тут уже учитываем регистр
    {
        while (true)
        {
            var response = TryGetValue("Введите да/нет");
            if (response.ToLower().Equals("да"))
                return true;
            else if (response.ToLower().Equals("нет"))
                return false;
        }
    }

    static string TryGetValue(string message) // метод на проверку пустого значения, нам же не нужны пустые значения
    {
        while (true)
        {
            Console.WriteLine(message);
            var result = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(result))
            {
                Console.WriteLine("Введено не корректное значение, повторите ввод, введите число");
                continue;
            }

            return result;
        }
    }


}










