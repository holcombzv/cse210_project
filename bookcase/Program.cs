Book harryPotter = new Book("Harry Potter", "J.K.Rowling");
harryPotter.display();

harryPotter.checkOut();
harryPotter.display();

harryPotter.checkIn();
harryPotter.display();

Console.WriteLine($"Available: {harryPotter.isAvailable()}\nTimes Read: {harryPotter.timesRead()}");

Bookcase bookcase = new Bookcase();

bookcase.addBook(harryPotter);
Console.WriteLine($"{bookcase.countBooks()} books.");