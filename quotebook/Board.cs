/*public class Board
{
    List<Quote> _quotes = new List<Quote>();

    
    private void NicePrint(string item)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"{item}");
        Console.WriteLine("-----------------------------------");

    }
    public void ShowQuotes()
    {
        foreach (Quote quote in collection)
        {
            NicePrint(quote.GetQuote());
        }
    }

    public void AddQuote(Quote quote)
    {
        _quotes.Add(quote);
    }

    public void GetRandomQuote()
    {
        var random = new Random();
        var randomNumber = random.Next(0, _quotes.Count);
        NicePrint(_quotes[randomNumber].GetQuote());
    }
}*/