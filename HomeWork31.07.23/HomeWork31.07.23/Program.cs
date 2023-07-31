
using HomeWork31._07._23;
using System.ComponentModel.DataAnnotations;

DataList<Book> datas = new DataList<Book>();
datas.Add(new Book { Id = 1, Name = "Xosrov ve Shirin"});
datas.Add(new Book { Id = 2, Name = "Igendername"});

var result = datas.Delete(2);

foreach (var item in result)
{
    Console.WriteLine(item.Name);
}



//var result = datas.GetAll();
//foreach(var item in result)
//{
//    Console.WriteLine(item.Name);
//}

//var result = datas.GetById(1);
//Console.WriteLine(result.Name);


