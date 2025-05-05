// See https://aka.ms/new-console-template for more information

Jeu jeu = new Jeu();
for (int i = 0; i < 10; i++)
{
    jeu.PasserSemaine();
    Console.WriteLine($"Semaine {i + 1} : {jeu.potager}");
    Console.WriteLine($"Semaine {i + 1} : {jeu.potager.terrains[0].plante}");
}