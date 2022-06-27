// See https://aka.ms/new-console-template for more information


string title = "The Lord of the Rings";
string author = "J.R.R. Tolkien";
string isbn = "9780544003415"; // scelto tipo stringa perché alcuni isbn contengono -
short pagesNum = 1216;
float weight = 1.2f; // kg
float height = 20.95f; // cm
float width = 13.97f; // cm
float depth = 4.44f; // cm
float rating = 4.8f; // 0 to 5
int reviewsNum = 24027;
bool kindleVersion = true;
bool flexibleCoverVersion = true;

Console.WriteLine("\nBOOK INFO:");
Console.WriteLine($"Title: {title}");
Console.WriteLine($"Author: {author}");
Console.WriteLine($"ISBN: {isbn}");
Console.WriteLine($"Pages: {pagesNum}");
Console.WriteLine($"Weight: {weight}kg");
Console.WriteLine($"Dimensions: {height}cm x {width}cm x {depth}cm");
Console.WriteLine($"Rating: {rating}/5");
Console.WriteLine($"Reviews: {reviewsNum}");
Console.Write("Kindle version available: ");
if(kindleVersion)
{
    Console.Write("yes\n");
}
else
{
    Console.Write("no\n");
}

Console.Write("Flexible cover version available: ");
if (flexibleCoverVersion)
{
    Console.Write("yes\n");
}
else
{
    Console.Write("no\n");
}
Console.WriteLine();