
#region Deger tipli degiskenlerde ref keywordu calisiyor.
//int b = 5;
//x(ref b);

//Console.WriteLine(b);
//void x(ref int a)
//{
//    a = 123;
//}
#endregion

#region Referanst tipi nesnelerde Ref Keywordu Calisiyor.

//Person person = null;
//person ??= new() { Name = "Yildiray" };

//nameConvert(ref person);
//Console.WriteLine();

//void nameConvert(ref Person person)
//{
//    person.Name = "Kocak";
//}

//class Person
//{
//    public string Name { get; set; }
//}

#endregion

#region Ref Kullanmadan referans tiplerde referans degistirilebilir.

//using System.Runtime.InteropServices;

//Person person = null;
//person ??= new() { Name = "Yildiray" };

//nameConvert(person);

//Console.WriteLine(person.Name);
//void nameConvert(Person person)
//{
//    person.Name = "Kocak";
//}

//class Person
//{
//    public string Name { get; set; }
//}

#endregion

#region + Operator Overloading Bire Cok iliskili siniflari baglar

//using System.Data.Common;

//Student student = null;
//student ??= new() { Name = "Yildiray" };

//List<Book> book = null;
//book ??= new() { new Book() { Name = "Deneme", Author = "Ali Riza Akinci" } };

//Student result = student + book;

//Console.WriteLine(result.Books.FirstOrDefault().Name);

//class Student
//{
//    public string? Name { get; set; }
//    public List<Book>? Books { get; set; } = new();

//    public static Student operator +(Student student, List<Book> books)
//    {
//        foreach (var item in books)
//        {
//            student.Books.Add(item);
//        }
//        return student;
//    }
//}

//class Book
//{
//    public string? Name { get; set; }
//    public string? Author { get; set; }
//}


#endregion

#region Implicit & Explicit Operators Overloading

//A a = new B();
//A a2 = (A)new B();

//class A
//{
//    public string Data1 { get; set; }
//    public string Data2 { get; set; }
//    public string Data3 { get; set; }

//    public static implicit operator A(B b)
//    {
//        return new A()
//        {
//            Data1 = b.Data1,
//            Data2 = b.Data2,
//            Data3 = b.Data3,
//        };
//    }
//}

//class B
//{
//    public string Data1 { get; set; }
//    public string Data2 { get; set; }
//    public string Data3 { get; set; }
//}

#endregion

#region ?? operatoru ile null olmayan degerlere atamayi engelleme
//MyClass myClass2 = new MyClass { Name = "efe"}; 

//MyClass myClass = new MyClass() { Name = "Yildiray" };

//myClass??= new MyClass { Name = "Ahmet"};

//Console.WriteLine(myClass.Name);

//class MyClass
//{
//    public string Name { get; set; }
//}


//MyClass myClass = null;

//if (true)
//{
//myClass ??= new MyClass() { Name = "Yildiray" };
//}
//if (true)
//{
//myClass ??= new MyClass() { Name = "Ahmet" };
//}
//if (true)
//{
//myClass ??= new MyClass() { Name = "Efe" };
//}

//Console.WriteLine(myClass.Name);

//class MyClass
//{
//    public string Name { get; set; } = "Deneme";
//}

#endregion

#region CustomException Class ve Hata Yonetimi
//try
//{
//    while (true)
//    {
//        var key = Console.ReadKey();
//        if (key.Key == ConsoleKey.R)
//        {
//            throw new CustomException("Laylaylom galiba sana gore sevmeler...")
//            {
//                Deger = "aldin mi "
//            };
//        }
//        else
//        {
//            Console.WriteLine(key.Key);
//        }
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

//class CustomException : Exception
//{
//    public CustomException()
//    {

//    }
//    public CustomException(string message) : base(message)
//    {

//    }
//    public string Deger { get; set; }
//}
#endregion