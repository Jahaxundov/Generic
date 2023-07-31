
//boxing,umboxing

//int num = 5;

//object t = num;
//num = 100;
//Console.WriteLine(t);

//int num = 5;

//object t = num;
//int j = (int)t;
//Ang,downcasting

using ClassWork31._07._23;

//Animal animal1 = new Animal();
//Fish fish = new Fish();
//Animal animal2 = fish;
//Animal animal3 = new Fish();
//Fish fish1 = (Fish)animal2;
//Book book = new Book();


//object[] animals = {book, 1, "Salam", animal1, fish, animal2, animal3, fish1 };

//foreach (var item in animals)
//{
//if(item is Animal a)
//{
//    //((Animal)item).Name = "Tulku";
//    //Console.WriteLine(((Animal)item).Name);
//    a.Name = "Tulku";
//    Console.WriteLine(a.Name);
//}

//    Animal animal = item as Animal;
//    if (animal != null)
//    {
//        animal.Name = "canavar";
//        Console.WriteLine(animal.Name);
//    }

//}

//byte num1 = 5;
//int num2 = num1;

//int num3 = 5;
//byte num4 = (byte)num3;

//static void Test(int? a=5)
//{
//    Test2((int)a);
//}

//static void Test2(int m)
//{

//}
//Test();

//IntList intList = new IntList();
//intList.Add(5);
//intList.Add(15);
//intList.Add(20);
//intList.Add(12);
//var result = intList.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//StringList stringList = new StringList();
//stringList.AddStr("salam");
//stringList.AddStr("salamlar");
//var result = stringList.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//DataList<int> datas = new DataList<int>();
//datas.Add(1);
//datas.Add(2);
//var result = datas.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//DataList<string> words = new DataList<string>();
//words.Add("salam");
//words.Add("salam1");
//var list = words.GetAll();
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//DataList<bool> statutes = new DataList<bool>();
//statutes.Add(true);
//statutes.Add(true);
//var listBool = words.GetAll();
//foreach (var item in listBool)
//{
//    Console.WriteLine(item);
//}

//DataList<Book1> books = new DataList<Book1>();
//books.Add(new Book1 { Name="Kitab",Id=1 });
//books.Add(new Book1 { Name = "Kitab2", Id = 2 });
//var result = books.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}

//Repository<string> data1 = new Repository<string>();

//Repository<Book1> data2 = new Repository<Book1>();

//Repository<int> data3 = new Repository<int>();

Repository<Bird, Animal> animal = new Repository<Bird, Animal>();











