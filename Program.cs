string firstName = "Roshni";
string favMovie = "The Matrix";

string quote = "She's our friend and she's crazy";

Console.WriteLine("Hello  " + firstName + " "+ favMovie.ToUpper());
favMovie = (favMovie.ToUpper());
Console.WriteLine(favMovie.Contains("THE"));

favMovie = favMovie.Replace("A", "@");
favMovie = favMovie.Replace("E", "3");
Console.WriteLine(favMovie);
Console.WriteLine();

Console.WriteLine(quote);
quote = quote.ToUpper();
Console.WriteLine(quote);

quote = quote.Replace("A"," ");
quote = quote.Replace("E"," ");
quote = quote.Replace("I"," ");
quote = quote.Replace("O"," ");
quote = quote.Replace("U"," ");
Console.WriteLine(quote);


Console.WriteLine();
Console.WriteLine("           /\\                 __                ____                  ");
Console.WriteLine("       .--/ --\\--,           /\\ \\              /\\___\\             ");
Console.WriteLine("        \\/    \\/            / /\\ \\            /\\ \\___\\          ");
Console.WriteLine("        /\\    /\\           / /__\\ \\           \\ \\/ / /           ");
Console.WriteLine("       '--\\--/--`          \\/____\\/            \\/_/_/              ");
Console.WriteLine("           \\/                                                         ");

