
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

//using Microsoft.VisualBasic;

//MyRecord record = new MyRecord()
//{
//    MyProperty = 0
//};

//public record MyRecord
//{
//    public int MyProperty { get; set; }
//    public void Deneme()
//    {
//        Console.WriteLine("deneme");
//    }
//}

#endregion

#region Statik Kavrami Ve Kullanimi

// Statik yapilarda veriler instancelar uzerinden degil direk yapinin kendisi uzerinden calisilir.
// Bellekte Statik alaninda tutulurlar ve uygulamadan bagimsiz calisirlar.

// Uygulama capinda erisilebilir olmaktadirlar.

//Static olan seyler sadece statiklere erisebilir. Statik olmayan seyler statik olan seylere erisemez.
//Statik olarak tanimlanmis bir sinif icerisinde statik olmayan bir sey barinamaz.
//Statik olmayan bir sinifta statik olan seyler barinabilir.

//Statik olan seylerde virtual isaretini kullanamaz ve override edemeyiz. / Overload Edebiliriz.
// statiklerden nesne olusturulamayacagi icin baska bir nesnede kalitim ile override edilmesi akil kari degildir.

//class MyClass
//{
//    public int MyProperty { get; set; }
//    public static int MyInt { get; set; }


//    // X overload edilebilir.
//    public static void X()
//    {

//    }

//    public static void X(string y)
//    {

//    }
//}
//MyClass myClass = new MyClass();
//myClass.MyProperty = 0;
//MyClass.MyInt = 0;


// Asagidaki ornekte static bir alanin kalitim ile iki sinif arasinda tasinabildigini gostermektedir.
//partial class MyClass : MyClass2
//{
//    public MyClass()
//    {
//        MyProperty = 0;
//    }
//}

//public class MyClass2
//{
//    public MyClass2()
//    {
//    }

//    public static int MyProperty { get; set; }
//}


//Statik memberlara ilk deger atamak icin kullanilabilir. Tek seferlik calisir.
//class MyClass
//{
//    static MyClass()
//    {
//        Console.WriteLine("Statik Constructor.");
//    }
//}

#endregion

#region Delegete
//using System.Threading.Channels;

//Console.WriteLine("Deneme");

//Delegate tanimlama
//XHandler xdelegate = new XHandler(X); // ayni
//XHandler xdelegate2 = X; // ayni
//XHandler xdelegate3 = () => // Lambda ile
//{

//};
//XHandler xdelegate4 = delegate () // Anonim Method
//{

//};

//// Coklu Tanimlama : Imzalari ayni oldugu surece birden fazla methodu burada tanimlayabiliriz.
//xdelegate += () => { };
//xdelegate += delegate () { };
//xdelegate += xMethod2;
//xdelegate += xMethod1;

//// Coklu Tanimlamalarda Methodlar icerisinde dongu kurma

//var methods = xdelegate.GetInvocationList();
//foreach (var item in methods)
//{
//    global::System.Console.WriteLine(item.Method.Name);
//}

//// Delegate Kullanma
//xdelegate();
//xdelegate2.Invoke(); // Senkron

//IAsyncResult result = xdelegate2.BeginInvoke(new AsyncCallback(result => // Asenkron Calistirma
//{
//    // Asenkron surec sonlandiginda burasi tetiklenir.
//}), null);
//xdelegate2.EndInvoke(result); // Asenkron invoke sonlandirilir.
//void X()
//{
//    global::System.Console.WriteLine("Deneme");
//}
//void xMethod1() => Console.WriteLine("1");
//void xMethod2() => Console.WriteLine("2");
//public delegate void XHandler();

#endregion

#region Eventler

// ORNEK

//using System;

//string path = @"C:\Users\kocak\Desktop\Prompt Koleksiyon";
//PathControl PathControl = new();
//PathControl.PathControlEvent += (sizeMB) =>
//{
//    global::System.Console.WriteLine("Boyut 15 mb'ti asti" + " " + sizeMB);
//};
//PathControl.PathControlEvent += (sizeMB) =>
//{
//    global::System.Console.WriteLine("Boyut 15 mb'ti asti" + " " + sizeMB);
//};
//await PathControl.Control(path);

//class PathControl
//{
//    public delegate void PathHandler(float sizeMB);
//    public event PathHandler PathControlEvent;
//    public event PathHandler PathLowControl;
//    public async Task Control(string path)
//    {
//        while (true)
//        {
//            await Task.Delay(1000);
//            DirectoryInfo directoryInfo = new(path);
//            var files = directoryInfo.GetFiles();
//            float size = await Task.Run(() => directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length));
//            float sizeMB = (size / 1024) / 1024;
//            if (sizeMB > 15)
//            {
//                PathControlEvent(sizeMB);
//            }
//            else
//            {
//                PathLowControl(sizeMB);
//            }
//        }
//    }
//}

//using System;

//MyEventPublisher eventPublisher = new();

//// Event Ile method baglama
//eventPublisher.MyEvent += X;
//void X()
//{
//    global::System.Console.WriteLine("Event Tetiklendi");
//}

////Event tetikeleme
//eventPublisher.ExecuteEvent();

//// Event Tanimlama
//class MyEventPublisher
//{
//    public delegate void XHandler();
//    //public event XHandler MyEvent;

//    XHandler xdelegete;
//    public event XHandler MyEvent
//    {
//        //method eklerken tetiklenir
//        add
//        {
//            xdelegete += value;
//        }
//        //method cikarilirken tetiklenir
//        remove
//        {
//            xdelegete -= value;
//        }
//    }
//    public void ExecuteEvent()
//    {
//        //event firlatma
//        //MyEvent();
//        xdelegete();
//    }
//}

//EticaretSistemi eticaret = new EticaretSistemi();


//// Olaylara metotları bağlama
//eticaret.SatinAlmaGerceklesti += eticaret.FaturaOlustur;
//eticaret.SatinAlmaGerceklesti += eticaret.StokGuncelle;
//eticaret.SatinAlmaGerceklesti += eticaret.EpostaGonder;

//// Ürün satın alma
//eticaret.UrunSatinAl();
//public class EticaretSistemi
//{
//    // Event tanımı Action ile
//    public event Action SatinAlmaGerceklesti;

//    public void FaturaOlustur()
//    {
//        Console.WriteLine("Fatura oluşturuldu.");
//    }

//    public void StokGuncelle()
//    {
//        Console.WriteLine("Stok güncellendi.");
//    }

//    public void EpostaGonder()
//    {
//        Console.WriteLine("E-posta bildirimi gönderildi.");
//    }

//    public void UrunSatinAl()
//    {
//        // Diğer satın alma işlemleri...

//        OnSatinAlmaGerceklesti(); // Satın alma olayını tetikleme
//    }

//    protected virtual void OnSatinAlmaGerceklesti()
//    {
//        SatinAlmaGerceklesti?.Invoke();
//    }
//}
//Bu örnekte, SatinAlmaGerceklesti adında bir event tanımladık. Satın alma işlemi gerçekleştiğinde bu olay tetiklenir. Program sınıfında bu olaya dinleyici (listener) olarak metotları ekledik. Bu şekilde, satın alma işlemi gerçekleştiğinde otomatik olarak bu metotlar çağırılır.

//Event'ler, sınıf dışından doğrudan tetiklenemez, bu nedenle OnSatinAlmaGerceklesti adında korumalı (protected) bir metot oluşturduk. Bu metot, satın alma işlemi gerçekleştiğinde içeriden olayı tetikler. Bu yaklaşım, event'lerin doğru ve güvenli bir şekilde kullanılmasını sağlar.


#endregion

#region Action Delegate'si
//geriye deger dondurmez.
//Action action1 = () => Console.WriteLine("Action");
//Action<bool> action2 = (b) => Console.WriteLine("Action<T>");
//Action<bool, int, int> action3 = (b, i1, i2) => Console.WriteLine("Action<T>");
#endregion

#region Func Delegate'si
//Geriye int dönen metotları temsil eden bir Func delegate'i:
//Func<int> func1 = () => 3;

//Geriye bool dönen ve parametre olarak int, char alan Func delegate'i:
//Func<int, char, bool> func2 = (i, c) => 3 == 3;

//Geriye (int, char)-tuple dönen ve parametre olarak byte, int, string alan Func delegate'i:
//Func<byte, int, string, (int, char)> func3 = (b, i, s) => (3, 'a');
#endregion

#region ExpandoObject Dinamik Obje Olusturma
// Dynamic olarak veri yapilari olusturmakta kullanilir.

//using System.Dynamic;

//dynamic person = new ExpandoObject();
//person.DynamicProp = "Dynamic prop olusturma";
//person.Age = 32;
//person.DynamicMethod = new Func<int>(() => DateTime.UtcNow.Year - person.Age);

//// Eklenen proplari elde etmek
//IDictionary<string, object> dataDictionary = (IDictionary<string, object>)person;
//foreach (KeyValuePair<string, object> item in dataDictionary)
//{
//    global::System.Console.WriteLine($"Key : {item.Key} - Value : {item.Value}");
//}

//// Dictionary uzerinden prop eklemek
//dataDictionary.Add("Marr'ed", true);

// Serialization & Deserialization islemleri.
//using System.Dynamic;
//using System.Text.Json;

//dynamic person1 = new ExpandoObject();
//person1.Name = "Gençay";
//person1.Surname = "Yıldız";

//dynamic person2 = new ExpandoObject();
//person2.Name = "Suayip";
//person2.Surname = "Uçarturnagurbetgezerogulları";

//dynamic person3 = new ExpandoObject();
//person3.Name = "Müslüm";
//person3.Surname = "Yılmaz";

//List<ExpandoObject> list = new()
//{
//    person1,
//    person2,
//    person3
//};

////Serializasyon
//var jsonData = JsonSerializer.Serialize(list);
//Console.WriteLine(jsonData);

////Deserializasyon
//dynamic data = JsonSerializer.Deserialize<List<ExpandoObject>>(jsonData);

#endregion

#region Anonymus Kodlama

#region Anonymus Object

//var anonymus = new { name = "Anonim name", surname = "anonim surname" };
//dynamic anonymus2 = new { name = "Anonim name", surname = "anonim surname" };

#endregion

#region Anonymus Function

//var function = () => { }; // Fonksiyonun parametre ve geriye deger dondrume durumuna gore action / predict / func delegatelerinden birini kullanarak bu fonksiyonu var keywordune atayacaktir.

#endregion

#region Anonymus Collection
//using Microsoft.VisualBasic;

//var collection1 = new[] { 3, 5 };
//var collection2 = new Collection()
//{
//    new { name = "ali" },
//    new { name = "ahmet"}
//};

#endregion

#endregion

#region Redis Notlari

#region Data Turleri

//1. * *String * *: 
//   -Redis'in en temel, en basit veri türüdür.
//   - Metinsel değerlerle birlikte her türlü veriyi saklamak için kullanılır.
//   - Hatta binary olarak resim, dosya vs. veriler de saklayabilmektedir.
//1. **SET**: 
//   -İşlevi: Bir değeri bir anahtarla ilişkilendirerek ekler.
//   - Örnek Kullanım: `SET NAME hilmi`
//     - Bu komut, 'NAME' anahtarına 'hilmi' değerini atar.

//2. **GET**: 
//   -İşlevi: Belirtilen anahtarın değerini okur.
//   - Örnek Kullanım: `GET NAME`
//     - Bu komut, 'NAME' anahtarına atanmış olan değeri getirir.

//3. **GETRANGE**: 
//   -İşlevi: Anahtarın değerinde belirtilen karakter aralığını okur.
//   - Örnek Kullanım: `GETRANGE NAME 1 2`
//     - Bu komut, 'NAME' anahtarının değerindeki 1. ve 2. karakterler arasındaki bölümü döndürür.

//4. **INCR & INCRBY**: 
//   -İşlevi: Bir anahtarın sayısal değerini arttırma.
//   - Örnek Kullanım: `INCR SAYI`
//     - Bu komut, 'SAYI' anahtarının değerini bir arttırır.

//5. **DECR & DECRBY**: 
//   -İşlevi: Bir anahtarın sayısal değerini azaltma.

//6. **APPEND**:
//   -Islevi : Uzerine ekleme




//2. **List**:
//   -Değerleri koleksiyonel olarak tutan bir türdür.
// - LPUSH bosa veri ekleme
// - LRANGE veri listleme
// - RPUSH sona veri ekleme
// - LPOP ilk datayi cikarma.
// - RPOP son datayi cikarma
// - LINDEX indexe gore datayi getirme.



//3. **Set**:
//   -Verileri rastgele bir düzende unique bir biçimde tutan veri türüdür.
// - SADD ekleme islemi yapar / SADD COLORS orange purple blue white
// - SREM silme islemi yapar / SREM COLORS orange
// - SISMEMBER arama islemi yapar / SISMEMBER COLORS purple
// - SINTER iki setteki kesisimi getirir / SINTER user1:BOOKS user2:BOOKS
// - SCARD eleman sayisini getirir / SCARD COLOR



//4. **Sorted Set**:
//   -Set'in düzenli bir şekilde tutan versiyonudur.
// - ZADD ekleme / ZADD TEAMS 1 A   : 1 score degerine karsilik gelir sayisal olmalidir. score unique degildir ama kayitlar uniquedir
// - ZRANGE getirme / ZRANGE TEAMS 0-1 YA DA ZRANGE TEAMS 0-1 WITHSCORES
// ZREM silme / ZREM TEAMS A
// ZREVRANK siralama ogrenme / ZREVRANK TEAMS B




//5. * *Hash * *:
//   -Key - Value formatında veri tutan türdür.
// - HMSET & HSET ekleme / HMSET EMPLOYEES username gncy ya da HSET ile
// - HMGET & HGET getirme / HMGET EMPLOYEES username
// - HDEL silme / HDEL EMPLOYEES username
// - HGETALL tumunu getirme / HGETALL EMPLOYEES




//6. **Streams**:
//   -Log gibi hareket eden bir veri türüdür.
//   - Streams, event'lerin oluştuğu sırayla kaydedilmelerini ve daha sonra işlenmelerini sağlar.

//7. **Geospatial Indexes**:
//   -Coğrafi koordinatların saklanmasını sağlayan veri türüdür.
#endregion

#region Redis ile Caching

#region In Memory

//In-Memory Cache İşlem Sırası
//1.AddMemoryCache servisini uygulamaya ekleyiniz.
//2. IMemoryCache referansını inject ediniz.
//3. Set metoduyla veriyi cache'leyebilir, Get metoduyla cache'lenmiş veriyi elde edebilirsiniz.
//4. Remove fonksiyonuyla cache'lenmiş veriyi silebilirsiniz.
//5. TryGetValue metod ile kontrolü bir şekilde cache'den veriyi okuyabilirsiniz.

#endregion

#region Distributed Caching

// Kullanilacak kutuphane "Microsoft.Extensions.Caching.StackExchangeRedis"
//1.StackExchangeRedis kütüphanesini uygulamaya yükleyiniz.
//2. AddStackExchangeRedisCache servisini uygulamaya ekleyiniz.
//3. IDistributedCache referansını inject ediniz.
//4. SetString metodu ile metinsel, Set metodu ile ise binary olarak verilerinizi redis'e cache'leyebilirsiniz. Aynı şekilde GetString ve Get fonksiyonlarıyla cache'lenmiş verileri elde edebilirsiniz.
//5. Remove fonksiyonu ile cache'lenmiş verileri silebilirsiniz.

#endregion

#endregion

#endregion