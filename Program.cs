// Sett opp biblioteket
Library library = new Library();

// Lag bøkene
Book martian = new Book("Martian", "Jane Doe", new DateTime(2004, 3, 25));

// Legg til bøker i biblioteket
library.AddNewBook(martian);

// Håndter bruker input
bool runProgram = true;
while (runProgram)
{
  // les av bruker input
  Console.WriteLine("Do you want to lend or return?");
  string? userInput = Console.ReadLine();

  // Vi må finne hva bruker skrev inn

  // List ut tilgjengelige bøker
  if (userInput == "list")
  {
    Console.WriteLine("Here are available books:");
    List<Book> availableBooks = library.ListAvailableBooks();

    foreach (var book in availableBooks)
    {
      Console.WriteLine(book.Title);
    }
  }
  // For å låne en bok (lend)
  else if (userInput == "lend")
  {
    Console.WriteLine("What is the title of the book?");
    string? wantedBookTitle = Console.ReadLine();

    if (wantedBookTitle == null)
    {
      continue; // Start hoved løkken på nytt
    }

    Book? book = library.LendBook(wantedBookTitle);

    // Det kan hend biblioteket ikke hadde boken vår
    if (book == null)
    {
      Console.WriteLine("No book with title found: " + wantedBookTitle);
    }
    else
    {
      Console.WriteLine("Lending book: " + book.Title);
    }
  }
  // For å lever tilbake en bok (return)
  else if (userInput == "return")
  {
    Console.WriteLine("Returning a book");
  }
  // For å avslutte (exit)
  else if (userInput == "exit")
  {
    runProgram = false;
  }
}