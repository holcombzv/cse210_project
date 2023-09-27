Player ronaldo = new Player("Ronaldo Christiano", 7);
// ronaldo.Display();

Player potter = new Player("Harry Potter", 12);
// potter.Display();

Team trashPandas = new Team("Trash Pandas");
trashPandas.AddPlayer(ronaldo);
trashPandas.AddPlayer(potter);
trashPandas.DisplayRoster();