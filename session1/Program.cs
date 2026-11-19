//q1
object book1= new Book()
    {
        title = "the vampire diares",
        pages = 500
    };
object book2 = new Book()
{
    title = "stranger things",
    pages = 900
};
///////////////////////////////////////////////
//q2
Console.WriteLine(book1.ToString());

Console.WriteLine(book1.Equals(book2));

Console.WriteLine(book1.GetHashCode());

Console.WriteLine(book1.GetType());


/// /////////////////////////////////////
/// q3
/// //it's a compile-time error because the data type is integer and we store a string inside it so the right is in pages=464;
///q4
try
{
    int x = 10;
    int y = 0;

    int result = x / y;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Can't divide by zero");
}
finally
{
    Console.WriteLine("Done");
}
    /// /////////////////////////////////////////
    /// q5
    int pages = 300;
    double number = pages;
Console.WriteLine(number);

/// //////////////////////////////
/// q6
double price = 49.99;

int number1 = (int)price;

Console.WriteLine(number1);

/// ////////////////
//q7
string pagesText = "464";

int pagesnum = Convert.ToInt32(pagesText);

Console.WriteLine(pagesnum);
/// ///////////////////////////////////
/// //q8
string yearText = "2023";

int year = int.Parse(yearText);

Console.WriteLine(year);
string badText = "abc";

if (int.TryParse(badText, out int resu))
{
    Console.WriteLine(resu);
}
else
{
    Console.WriteLine("Invalid number");
}
//////////////////////////////////////////
/// q9
/// 
int page = 464;

string pageText = page.ToString();

Console.WriteLine(pageText);
Console.WriteLine(pageText.GetType());

//////////////////////////////////////////
/// q10
int copies = 100;

// Boxing
object obj = copies;

// Unboxing
int newCopies = (int)obj;

Console.WriteLine(copies);
Console.WriteLine(newCopies);


















class Book
{
    public string title;
    public int pages;
}