Joueur Leo = new Joueur(42222);
Console.WriteLine(Leo);

Item potion = new Item("potion", 55);
Leo.Ajouter(potion);
Console.WriteLine(Leo);
Console.WriteLine(Leo);
Leo.Consommer(potion);
Console.WriteLine(Leo);
Leo.Ajouter(potion,33);
Console.WriteLine(Leo);