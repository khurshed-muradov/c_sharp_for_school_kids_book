// void SayHello()
// {
//     Console.WriteLine("Hello");
// }
// SayHello();

//--------

// Person Petr;
// Petr = new Person();
// Petr.firstName = "Petr";
// Petr.lastName = "Ivanov";
// Petr.ShowFullName();
// class Person
// {
//     // Поля
//     public string firstName;
//     public string lastName;
//     // Метод
//     public void ShowFullName()
//     {
//         Console.WriteLine("Name is " + firstName + " " + lastName);
//     }
// }

//-------------

// void WriteHelloJo()
// {
//     Console.WriteLine("Hello Jo");
// }
// void WriteHelloSam()
// {
//     Console.WriteLine("Hello Sam");
// }
// void WriteHelloYou()
// {
//     Console.WriteLine("Hello You");
// }
// WriteHelloJo();
// WriteHelloSam();
// WriteHelloYou();

//------------
// void WriteHello(string someName)
// {
//     Console.WriteLine("Hello " + someName);
// }
// WriteHello("Jo");
// WriteHello("Sam");
// WriteHello("You");

// --------------------

// void WriteHello(string firstName, string lastName)
// {
//     Console.WriteLine("Hello " + firstName + " " + lastName);
// }
// WriteHello("Petr", "Ivanov");

//-----------------------

// 

//------------------------------

// int NumberOfLegs(string animalName)
// {
//     if (animalName == "слон") // Если название животного слон
//         return 4;
//     // Возвращаемое число 4
// }
// if (animalName == "индейка")
// {
//     return 2;
// }
// if (animalName == "устрица")
// {
//     return 1;
// }
// else
// {
//     return 0;
// }

// int i; // Переменная "i" будет хранить значение числа конечностей
// i = NumberOfLegs("индейка"); // Теперь i=2, получив значение, возвращаенное методом NumberOfLegs
// Console.WriteLine("У индейки конечностей -" + i);
// i = NumberOfLegs("обезьяна"); //Теперь i=0. Потому что параметр обезьяна не была указана в параметрах метода
// Console.WriteLine("У обезьяны конечностей - " + i);
// Здесь ошибка 


//-------------

// void JustWriteSomething(string someThing)
// {
//     Console.WriteLine(someThing);
// }
// JustWriteSomething("777");

//--------------------

// Person Anna;
// Anna = new Person();
// int num = Anna.LuckyNumber(24, 14);
// Console.WriteLine("Счастливое число Анны: " + num);
// class Person
// {
//     // Поля
//     string firstName;
//     string lastName;
//     // Метод
//     public int LuckyNumber(int numberOfTeeth, int age)
//     {
//         return (numberOfTeeth * age);
//     }
// }

//------------------------

// class animal
// {
//     // Поля
//     public string kindOfAnimal;
//     public string name;
//     public int NumberOfLegs;
//     public int height;
//     public int length;
//     public string color;
//     bool hasTail;
//     protected bool isMammal;
//     private bool spelliingCorrect;
//     //Методы
//     // Открытый метод, получающий информацию о том, чем питается животное
//     public string GetFoodInfo()
//     {
//         // Представим, что здесь расположен код, выполняющий поиск по базе данных ...
//     }
//     // Закрытый метод для проверки правильности написания вида животного
//     private void spelliingCorrect()
//     {
//         // Представим, что здесь расположен код для проверки правописания ...
//     }
//     // Защищенный метод, определяет существование данного вида животного 
//     protected bool IsValidAnimalType()
//     {
//         // код для проверки существующих видов животных
//     }
// }
// class Zoo
// {
//     Animal a = new Animal();
//     a.name = "Kangaroo"
//     string food;
//     bool animalExists;
// }
// // Следующий код будет выполнен успешно, посколько классу "Zoo" разрешено обращаться к открытым методам
// // в классе Animal.
// food = a.GetFoodInfo(); // Вызод открытого метода

//------------------

// Person p = new Person();
// Console.WriteLine(p.lastName);

// class Person
// {
//     // Поля
//     public string firstName;
//     public string lastName;
//     // Метод-конструктор для класса Person
//     public Person()
//     {
//         firstName = "Johnny";
//         lastName = "Rocket";
//     }
// }

//-----------------------


