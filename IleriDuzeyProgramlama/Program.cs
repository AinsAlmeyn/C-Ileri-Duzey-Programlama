

#region Deger tipli degiskenlerde ref keywordu calisiyor.
//int b = 5;
//x(ref b);

//Console.WriteLine(b);
//void x(ref int a)
//{
//    a = 123;
//}

//string b = "deneme";
//void x(string b) 
//{
//    b = "deger";
//}
//x(b);
//Console.WriteLine(b);

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
//person.Name = "Kocak";
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

#region Struct / Deger turunde kisisellestirilmis veri yapisi

// integer bir struct'tir && boolean bir struct'tir
// struct optimizasyon amacli kullanilirlar. && bellekte daha hizli erisim saglanir (stack) ve nesne tipinde olmadigi icin.

// matematiksel veriler gibi basit degerleri temsil etmek icin kullanilirlar.
// struct kullanilabilecek iken sinif kullanmak performans kayiplarina sebep olur.

// int a , int b, int c, char z gibi degerleri struct altinda tutup erisimleri struct uzerinden saglayabiliriz.

// structlar icerisindeki operatif tanimlamalari kullanmak icin new keywordunu kullanmak zorundayiz.


//Boyut: Genellikle küçük veri yapıları için struct'ları tercih edin. Struct'lar yığın belleği üzerinde saklanır, bu yüzden büyük veri yapıları için uygun değillerdir çünkü yığın hızla dolabilir. Ayrıca, büyük bir struct'ı kopyalamak da maliyetlidir.

//Ömür: Sık sık oluşturulup yok edilen kısa ömürlü nesneler için struct'ları tercih edebilirsiniz, çünkü yığın belleğindeki nesnelerin yönetimi genellikle yığın dışındakilere göre daha verimlidir.

//Değişmezlik(Immutability): Değer tipleri genellikle değişmez olmalıdır. Eğer veri yapınızın değişmez olması önemliyse, struct kullanmayı düşünün.

//Kimlik vs Değer: Bir nesnenin kimliği (identity) mi yoksa değeri mi önemli? Örneğin, iki Point nesnesi aynı koordinatlara sahipse aynı olarak kabul edilirler. Bu tür durumlar için struct kullanımı uygundur.Ancak, iki farklı öğrenci nesnesi aynı bilgilere sahip olsa bile (isim, yaş, vs.) farklı kimlikleri vardır ve bu nedenle farklıdırlar. Bu tür durumlar için class kullanmalısınız.

//Referans Semantiği: Bir nesneyi bir fonksiyona referans olarak geçirmeniz ve bu fonksiyonun nesneyi değiştirmesi gerekiyorsa, class kullanmanız daha uygundur.

//Miraz(Inheritance): Eğer mirasa ihtiyaç duyuyorsanız, class kullanmalısınız. Struct'lar miras alınamaz.

//Performans: Struct'lar bellekte ardışık olarak yerleştirilir ve küçük veri yapıları için cache dostudur. Ancak, bu avantaj genellikle sadece yoğun hesaplamalarda farkedilir.

//Yeniden Atama ve Yan Etkiler: Struct'lar değer tipli olduğu için kopyalandığında tamamen yeni bir kopya oluşturulur. Bu, yanlışlıkla bir struct'ı değiştirme riskini ortadan kaldırabilir. Ancak, bu da bazen beklenmedik sonuçlara yol açabilir, bu yüzden dikkatli olmalısınız.

//Null Değerler: Struct'lar null değer alamazken, class'lar null değer alabilir. Eğer bir veri yapınızın null olabileceğini düşünüyorsanız, class kullanmanız daha iyi olabilir.
//using System.Globalization;
//using System.Diagnostics.Metrics;

//MyStruct myStruct = new();
//myStruct.Deneme(myStruct.a);

////MyStruct? myStruct = new();
////myStruct.Value.Deneme(); // Nullable olarak tanimlarsan value uzerinden erismelisin

//public struct MyStruct
//{
//    public int a { get; set; }
//    public int b { get; set; }
//    public void Deneme(object value)
//    {
//        Console.WriteLine(value.ToString());
//    }
//}

#endregion

#region Record / Class turunde degerleri on planda tutan veri yapisi

// c# 9.0'da init-only properties ozelligi gelmistir.
// degerlerin ilk degeri verilir ve daha sonra degistirilemez. Nesnenin ilk yaratilis aninda deger atamak icin

// init-only kullanimi

//MyClass myClass = new MyClass()
//{
//    MyProperty2 = 0,
//    MyProperty3 = 1,
//};
////myClass.MyProperty3 = 2; // hata sadece obje olusturulurken deger atanabilir.


//class MyClass
//{
//    public int MyProperty { get;} = 3;
//    public int MyProperty2 { get; set; }
//    public int MyProperty3 { get; init; }
//    //public int MyProperty4 {  init; } // get olmak zorunda hata init readonly icin tanimlanir.
//}



//records

MyRecord record = new MyRecord()
{
    MyProperty = 0
};

public record MyRecord
{
    public int MyProperty { get; set; }
    public void Deneme()
    {
        Console.WriteLine("deneme");
    }
}

#endregion


