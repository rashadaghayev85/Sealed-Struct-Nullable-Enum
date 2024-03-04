

using Sealed_Struct_Nullable_Enum;
using System.Reflection.Emit;

//Book book = new Book();
//book.Name = "bebhe";
//Console.WriteLine(book.Name);

//Test test = new Test();
//test.MyProperty = 1;
//Console.WriteLine(test.MyProperty);


//string name = null;
//int? num = null;

//Console.WriteLine(book.Id);
//if (book.Id == null)
//{
//    Console.WriteLine("Book id notfound");
//}

Book book1 = new Book()
{
    Id = 1,
    Name = "Isgendername",
    Author = new Author()
    {
        Name = "Nizami",
        Id = 2,
    }
};
Book book2 = new Book()
{
    Id = 2,
    Name = "Xosrov ve Shirin",
};
Book[] books = { book1, book2 };


//Console.WriteLine("Book:"+book2.Name+"   Author:"+book2.Author?.Name.ToString());

//void GetBookById(Book[] books,int? id = null)
//{

//    if (id == null)
//    {
//        Console.WriteLine("Your id is null");
//        return;
//    }
//    Book?  result=books.FirstOrDefault(m=>m.Id ==(int) id);
//    Console.WriteLine(result.Name);
//}
//    GetBookById(books,2);

//Level level = Level.Low;
//Console.WriteLine(level);
//Console.WriteLine((int)level == 1);

void GetLevel(string level)
{
    switch (level)
    {
        case nameof(Level.Low):
            Console.WriteLine("Low");
            break;
        case nameof(Level.Medium):
            Console.WriteLine("Medium");
            break;
        case nameof(Level.High):
            Console.WriteLine("High");
            break;
        default:
            Console.WriteLine("suhoshx");
            break;
    }
}
//GetLevel(2);
GetLevel("Medium");

