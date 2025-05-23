using System.Drawing;

public class Affichage
{
    public Jeu jeu;
    public Affichage(Jeu jeu)
    {
        this.jeu = jeu;
    }

    public void AffichierTitre()
    {
        Console.Clear();
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine("░         ░    ░░░░░   ░░░      ░░░         ░   ░░░░░░░   ░         ░    ░░░░░   ░░░░░   ░░░░         ");
        Console.WriteLine("▒   ▒▒▒▒▒▒▒  ▒   ▒▒▒   ▒   ▒▒▒▒   ▒   ▒▒▒▒▒▒▒  ▒   ▒▒▒    ▒   ▒▒▒▒▒▒▒  ▒   ▒▒▒   ▒▒   ▒▒▒   ▒   ▒▒▒▒▒▒");
        Console.WriteLine("▒   ▒▒▒▒▒▒▒   ▒   ▒▒   ▒▒   ▒▒▒▒▒▒▒   ▒▒▒▒▒▒▒   ▒   ▒ ▒   ▒   ▒▒▒▒▒▒▒   ▒   ▒▒   ▒   ▒▒▒▒▒▒▒▒   ▒▒▒▒▒▒");
        Console.WriteLine("▓       ▓▓▓   ▓▓   ▓   ▓▓▓▓   ▓▓▓▓▓       ▓▓▓   ▓▓   ▓▓   ▓       ▓▓▓   ▓▓   ▓   ▓   ▓▓▓▓▓▓▓▓       ▓▓");
        Console.WriteLine("▓   ▓▓▓▓▓▓▓   ▓▓▓  ▓   ▓▓▓▓▓▓▓   ▓▓   ▓▓▓▓▓▓▓   ▓▓▓  ▓▓   ▓   ▓▓▓▓▓▓▓   ▓▓▓  ▓   ▓   ▓▓▓▓▓▓▓▓   ▓▓▓▓▓▓");
        Console.WriteLine("▓   ▓▓▓▓▓▓▓   ▓▓▓▓  ▓  ▓   ▓▓▓▓   ▓   ▓▓▓▓▓▓▓   ▓▓▓▓▓▓▓   ▓   ▓▓▓▓▓▓▓   ▓▓▓▓  ▓  ▓▓   ▓▓▓   ▓   ▓▓▓▓▓▓");
        Console.WriteLine("█         █   ██████   ███      ███         █   ███████   █         █   ██████   ████     ███         ");
        Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████ ");
        Console.WriteLine("Un jeu par : Léo Gaultier et Jolan Mazouffre : copyNOright 2025 \n\n\n");
        Console.WriteLine("Appuyer sur une touche pour continuer");
        Console.ReadKey();
    }
    public void AfficherIntro()
    {
        Console.Clear();
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⠻⢿⣛⣋⠉⠉⠉⠉⠉⠒⠲⠤⣤⢾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⢀⡤⠴⠒⠒⠒⠒⠒⠦⢤⣀⠀⠀⠀⠀⠀⠀⢀⣠⠤⠒⠉⠁⠀⠀⠀⠀⠀⠀⠀⡴⡱⣿⠦⡀⠀⢀⠤⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⢀⡜⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠦⡉⠒⣺⠭⠅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡜⡑⠀⡿⠀⠈⠞⠁⡘⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⣸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡼⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠎⡰⠁⠸⡇⠀⠀⡀⡰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀       Bonjour, humains misérables.");
        Console.WriteLine("⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⠋⠀⠀⣀⣠⠄⠒⠈⠀⠀⠀⠀⠀⠀⢠⠏⠀⠁⠉⠀⠈⠛⢥⣠⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀      Je suis le renard légendaire de ce monde. Oui, un renard. Deal with it.");
        Console.WriteLine("⠀⠀⠀⠀⠀⢸⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⡰⠁⡠⠖⠋⢠⠃⠀⠀⠀⠀⠀⠀⠀⢀⢔⡏⠀⠀⠀⠀⠸⣷⠠⡀⠙⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     Malheureusement, tu t'es fait écraser par un camion. Un modèle assez banal.");
        Console.WriteLine("⠀⠀⣠⠔⠋⠉⠀⠀⠀⠈⠉⠙⠒⠦⣄⡀⢠⢣⠊⠀⠀⢀⠆⠀⠀⠀⢀⠊⠀⢠⢁⡎⡸⠀⠀⠀⠀⠀⠀⠈⠉⠁⠀⠘⢦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     Mais bon, ton cœur était pur, ou du moins... recyclable.");
        Console.WriteLine("⠀⡼⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⡿⣅⠀⠀⠀⡼⠀⠀⢀⡔⠁⠀⣠⡇⡞⢸⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠩⣒⠄⠀⠀⠀⠀⠀⠀⠀⠀  ");
        Console.WriteLine("⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⡀⠀⡇⠀⢠⡞⠀⢀⠔⢹⡎⠀⡞⠀⠀⠀⠀⠀⠀⢠⡒⠒⠷⠿⠷⠒⠚⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀      Je t’ai donc réincarné dans ce monde magnifique et totalement instable.");
        Console.WriteLine("⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣄⠇⢀⢻⢃⣴⠁⠀⢨⠇⣸⠁⠀⠀⠀⠀⠀⠀⢸⠉⠲⢤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀       Le climat s’est amusé à mixer les biomes comme une playlist Spotify en aléatoire.");
        Console.WriteLine("⠀⠹⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⡶⡈⠸⠃⡇⢰⠀⡜⢀⠇⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⠀⠙⠦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀        Résultat : des banquises jouxtent des déserts. Bonne chance pour semer.");
        Console.WriteLine("⠀⠀⠹⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠑⢄⠀⠀⢳⠀⠀⣸⢁⢆⡼⡡⡞⠀⠀⠀⠀⠀⠀⠀⠀⠈⣇⠀⠀⠀⠀⠈⢣⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⣠⠼⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡄⠀⠀⢣⠀⣼⠰⢠⣇⠮⠞⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⡄⠀⠀⠀⠀⠀⠱⡄⠀⠀⠀⠀⠀⠀⠀⠀        Du coup, je t’offre… un potager. Oui. Un potager.");
        Console.WriteLine("⠀⡞⠁⠀⠈⢣⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣗⠲⢤⡀⣃⣷⣡⢷⡖⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⢷⢄⠀⠀⠀⠀⠀⠰⡀⠀⠀⠀⠀⠀⠀⠀       C’est la meilleure idée que j’ai eue après ma sieste de 400 ans.");
        Console.WriteLine("⠰⡇⠀⠀⠀⠀⠙⢦⠀⠀⠀⠀⠀⠀⠀⠀⠸⣀⡴⠋⠁⠀⢠⠎⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠸⠀⠁⠢⡀⠀⠀⠀⠘⢄⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⢧⠀⠀⠀⠀⠀⠀⠑⢦⡀⠀⠀⠀⠀⠀⠀⢻⡀⠀⠀⠀⢸⡠⡶⢀⡜⡰⣡⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠇⠀⠀⠀⠈⠲⣄⡀⠀⠈⠳⢄⠀⠀⠀⠀       Je ne te demande pas de sauver le monde. Je ne suis pas un philanthrope.");
        Console.WriteLine("⠀⠘⣆⠀⠀⠀⠀⠀⠀⠀⠙⠢⣄⠀⠀⠀⠀⠀⠳⡄⠀⠀⠘⠁⠗⠃⢿⡟⠙⣿⡈⡄⠀⠀⠀⠀⡄⡀⣰⡟⠀⠀⠀⠀⠀⠀⠈⢯⡑⠢⠄⣀⠑⠢⢀⣀      Je veux juste te voir t’enrichir de manière indécente.");
        Console.WriteLine("⠀⠀⠈⢦⡀⠀⠀⠀⠀⠀⠀⠀⠈⢿⠦⣀⠀⠀⠀⠙⢦⠀⠀⠀⠀⠀⠀⡇⠀⠐⢣⢹⡀⠀⡆⣼⣴⠗⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⡀⠀⠀⠀⠀⠀⠀        Dans la gloire du capitalisme, évidemment.");
        Console.WriteLine("⠀⠀⠀⡜⠻⣄⠀⠀⠀⠀⠀⠀⠀⠸⡴⠚⡟⠢⢄⣀⠀⠳⣄⠀⡟⢲⠒⡇⠀⠀⠀⢑⡇⡼⠛⠉⠁⡼⢡⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⡀⠀⠀⠀⠀⠀       Vois-tu, il n’y a rien de plus beau qu’un individu vivant dans l’opulence...");
        Console.WriteLine("⠀⠀⢸⠁⠀⠈⠳⣄⠀⠀⠀⠀⠀⠀⢳⡀⢷⠀⠀⠈⠙⠒⠬⣿⣇⣸⡀⡇⠀⠀⢀⠏⢹⠀⠀⠀⣰⠃⠀⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⣇⠀⠀⠀⠀⠀       ...tandis que tout autour de lui crie famine.");
        Console.WriteLine("⠀⠀⢸⠀⠀⠀⠀⠈⠳⣄⠀⠀⠀⠀⠀⠳⣸⠀⠀⠀⠀⠀⣠⠃⠀⢨⣧⡇⠀⠀⡼⠀⡟⠀⠀⢠⠇⠀⠀⠘⡀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢸⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠈⢧⠀⠀⠀⠀⠀⠈⢳⢦⡀⠀⠀⠀⠙⢆⠀⠀⣀⠔⠁⢀⡠⢛⣿⠀⠀⢰⠃⢀⡇⠀⠀⡞⠀⠀⠀⠀⠹⡢⢀⠀⠀⠀⠀⠀⠀⠘⣼⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠈⢳⡀⠀⠀⠀⠀⠈⢧⠉⣳⣤⣀⠀⠈⠳⣮⡥⠴⠚⠉⠀⢸⡏⠀⢀⡟⡀⢸⠁⠀⢸⠁⠀⠀⠀⠀⠀⠱⡀⠑⢤⡀⠀⠀⠀⠀⠹⡄⠀⠀⠀⠀      Oui. Je suis un renard sadique. Mais stylé.");
        Console.WriteLine("⠀⠀⠀⠀⠀⠙⠢⣄⠀⠀⠀⠈⢿⡁⢀⡏⠑⢢⢤⣈⠳⢄⡀⠀⠀⢸⠇⠀⡼⠀⠑⢿⠀⠀⣼⠀⠀⠀⠀⠀⠀⠀⠙⣄⠀⠈⠓⠦⣄⡀⠀⠑⢄⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠙⠲⠤⣀⣀⠙⢼⡀⠀⣿⠀⠈⠉⠓⠻⠶⣄⣸⠀⢠⣧⡀⠀⠈⡇⠀⢸⠈⢲⢄⡀⠀⠀⠀⠀⠈⠳⣄⠀⠀⠀⠈⠉⠐⠒⠓⠄⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⡿⢷⡤⣿⢤⠀⠀⠀⠀⢀⡤⣧⣄⣼⣽⣽⠀⠀⢳⠀⠀⢳⡢⠧⠌⠒⠤⢄⣀⡀⠀⠈⠑⠤⢀⣀⣀⠠⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠧⡼⠧⠼⠼⠀⠀⠀⠀⢿⣰⡇⢸⡆⣹⠀⠀⠀⠸⡄⠀⢄⢹⠓⡄⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠁⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠁⠀⠀⠀⠀⠉⠙⠛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");

        Console.ReadKey();
    }
    public void AfficherExplication()
    {
        Console.Clear();
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⠻⢿⣛⣋⠉⠉⠉⠉⠉⠒⠲⠤⣤⢾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⢀⡤⠴⠒⠒⠒⠒⠒⠦⢤⣀⠀⠀⠀⠀⠀⠀⢀⣠⠤⠒⠉⠁⠀⠀⠀⠀⠀⠀⠀⡴⡱⣿⠦⡀⠀⢀⠤⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⢀⡜⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠦⡉⠒⣺⠭⠅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡜⡑⠀⡿⠀⠈⠞⠁⡘⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⣸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡼⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠎⡰⠁⠸⡇⠀⠀⡀⡰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀       Les plantes… de nobles entités vertes, capricieuses et exigeantes.");
        Console.WriteLine("⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⠋⠀⠀⣀⣠⠄⠒⠈⠀⠀⠀⠀⠀⠀⢠⠏⠀⠁⠉⠀⠈⠛⢥⣠⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀      Elles veulent de l’eau, de la lumière, et surtout… du respect.");
        Console.WriteLine("⠀⠀⠀⠀⠀⢸⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⡰⠁⡠⠖⠋⢠⠃⠀⠀⠀⠀⠀⠀⠀⢀⢔⡏⠀⠀⠀⠀⠸⣷⠠⡀⠙⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     Plus elles sont heureuses, plus elles grandissent. Comme ton ego.");
        Console.WriteLine("⠀⠀⣠⠔⠋⠉⠀⠀⠀⠈⠉⠙⠒⠦⣄⡀⢠⢣⠊⠀⠀⢀⠆⠀⠀⠀⢀⠊⠀⢠⢁⡎⡸⠀⠀⠀⠀⠀⠀⠈⠉⠁⠀⠘⢦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     Mais si tu les déçois... elles meurent. Brutalement. Sans générique.");
        Console.WriteLine("⠀⡼⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⡿⣅⠀⠀⠀⡼⠀⠀⢀⡔⠁⠀⣠⡇⡞⢸⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠩⣒⠄⠀⠀⠀⠀⠀⠀⠀⠀  ");
        Console.WriteLine("⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⡀⠀⡇⠀⢠⡞⠀⢀⠔⢹⡎⠀⡞⠀⠀⠀⠀⠀⠀⢠⡒⠒⠷⠿⠷⠒⠚⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀      Chaque terrain dispose de ressources en eau et lumière différentes.");
        Console.WriteLine("⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣄⠇⢀⢻⢃⣴⠁⠀⢨⠇⣸⠁⠀⠀⠀⠀⠀⠀⢸⠉⠲⢤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀       Et dès qu’une plante occupe un terrain… elle attire les curieux.");
        Console.WriteLine("⠀⠹⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⡶⡈⠸⠃⡇⢰⠀⡜⢀⠇⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⠀⠙⠦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀        Marchands, monstres, animaux… La loterie du vivant commence.");
        Console.WriteLine("⠀⠀⠹⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠑⢄⠀⠀⢳⠀⠀⣸⢁⢆⡼⡡⡞⠀⠀⠀⠀⠀⠀⠀⠀⠈⣇⠀⠀⠀⠀⠈⢣⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⣠⠼⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡄⠀⠀⢣⠀⣼⠰⢠⣇⠮⠞⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⡄⠀⠀⠀⠀⠀⠱⡄⠀⠀⠀⠀⠀⠀⠀⠀        Mais maintenant... un message pour ton maître.");
        Console.WriteLine("⠀⡞⠁⠀⠈⢣⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣗⠲⢤⡀⣃⣷⣡⢷⡖⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⢷⢄⠀⠀⠀⠀⠀⠰⡀⠀⠀⠀⠀⠀⠀⠀       Oui. Toi. La personne qui touche au clavier. Je te vois.");
        Console.WriteLine("⠰⡇⠀⠀⠀⠀⠙⢦⠀⠀⠀⠀⠀⠀⠀⠀⠸⣀⡴⠋⠁⠀⢠⠎⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠸⠀⠁⠢⡀⠀⠀⠀⠘⢄⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⢧⠀⠀⠀⠀⠀⠀⠑⢦⡀⠀⠀⠀⠀⠀⠀⢻⡀⠀⠀⠀⢸⡠⡶⢀⡜⡰⣡⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠇⠀⠀⠀⠈⠲⣄⡀⠀⠈⠳⢄⠀⠀⠀⠀       Utilise. Les. Flèches. Directionnelles. Pour bouger. C’est pas sorcier.");
        Console.WriteLine("⠀⠘⣆⠀⠀⠀⠀⠀⠀⠀⠙⠢⣄⠀⠀⠀⠀⠀⠳⡄⠀⠀⠘⠁⠗⠃⢿⡟⠙⣿⡈⡄⠀⠀⠀⠀⡄⡀⣰⡟⠀⠀⠀⠀⠀⠀⠈⢯⡑⠢⠄⣀⠑⠢⢀⣀      Touche **Entrée** pour confirmer. **Backspace** pour revenir. Facile, hein ?");
        Console.WriteLine("⠀⠀⠈⢦⡀⠀⠀⠀⠀⠀⠀⠀⠈⢿⠦⣀⠀⠀⠀⠙⢦⠀⠀⠀⠀⠀⠀⡇⠀⠐⢣⢹⡀⠀⡆⣼⣴⠗⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⡀⠀⠀⠀⠀⠀⠀        Ah et surtout… ne scroll PAS dans la console. Jamais.");
        Console.WriteLine("⠀⠀⠀⡜⠻⣄⠀⠀⠀⠀⠀⠀⠀⠸⡴⠚⡟⠢⢄⣀⠀⠳⣄⠀⡟⢲⠒⡇⠀⠀⠀⢑⡇⡼⠛⠉⠁⡼⢡⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⡀⠀⠀⠀⠀⠀       Sinon l’affichage devient moche et mon égo pleure.");
        Console.WriteLine("⠀⠀⢸⠁⠀⠈⠳⣄⠀⠀⠀⠀⠀⠀⢳⡀⢷⠀⠀⠈⠙⠒⠬⣿⣇⣸⡀⡇⠀⠀⢀⠏⢹⠀⠀⠀⣰⠃⠀⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⣇⠀⠀⠀⠀⠀       Oui, les développeurs auraient pu mieux faire. Mais on fait avec.");
        Console.WriteLine("⠀⠀⢸⠀⠀⠀⠀⠈⠳⣄⠀⠀⠀⠀⠀⠳⣸⠀⠀⠀⠀⠀⣠⠃⠀⢨⣧⡇⠀⠀⡼⠀⡟⠀⠀⢠⠇⠀⠀⠘⡀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢸⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠈⢧⠀⠀⠀⠀⠀⠈⢳⢦⡀⠀⠀⠀⠙⢆⠀⠀⣀⠔⠁⢀⡠⢛⣿⠀⠀⢰⠃⢀⡇⠀⠀⡞⠀⠀⠀⠀⠹⡢⢀⠀⠀⠀⠀⠀⠀⠘⣼⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠈⢳⡀⠀⠀⠀⠀⠈⢧⠉⣳⣤⣀⠀⠈⠳⣮⡥⠴⠚⠉⠀⢸⡏⠀⢀⡟⡀⢸⠁⠀⢸⠁⠀⠀⠀⠀⠀⠱⡀⠑⢤⡀⠀⠀⠀⠀⠹⡄⠀⠀⠀⠀      J’espère sincèrement que tu ne t’ennuieras pas trop...");
        Console.WriteLine("⠀⠀⠀⠀⠀⠙⠢⣄⠀⠀⠀⠈⢿⡁⢀⡏⠑⢢⢤⣈⠳⢄⡀⠀⠀⢸⠇⠀⡼⠀⠑⢿⠀⠀⣼⠀⠀⠀⠀⠀⠀⠀⠙⣄⠀⠈⠓⠦⣄⡀⠀⠑⢄⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠙⠲⠤⣀⣀⠙⢼⡀⠀⣿⠀⠈⠉⠓⠻⠶⣄⣸⠀⢠⣧⡀⠀⠈⡇⠀⢸⠈⢲⢄⡀⠀⠀⠀⠀⠈⠳⣄⠀⠀⠀⠈⠉⠐⠒⠓⠄⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⡿⢷⡤⣿⢤⠀⠀⠀⠀⢀⡤⣧⣄⣼⣽⣽⠀⠀⢳⠀⠀⢳⡢⠧⠌⠒⠤⢄⣀⡀⠀⠈⠑⠤⢀⣀⣀⠠⠀⠀⠀⠀       Conseil 1: Les onglet info joeur et info plante sont essentiel, ne les néglige pas !!!");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠧⡼⠧⠼⠼⠀⠀⠀⠀⢿⣰⡇⢸⡆⣹⠀⠀⠀⠸⡄⠀⢄⢹⠓⡄⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠁⠀⠀⠀⠀⠀⠀        Conseil 2 : Devient adhérent au BDA, c'est le meilleur bureau de l'école !");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠁⠀⠀⠀⠀⠉⠙⠛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");


        Console.ReadKey();
    }
    public void Bloque()
    {
        Console.Clear();
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⠻⢿⣛⣋⠉⠉⠉⠉⠉⠒⠲⠤⣤⢾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⢀⡤⠴⠒⠒⠒⠒⠒⠦⢤⣀⠀⠀⠀⠀⠀⠀⢀⣠⠤⠒⠉⠁⠀⠀⠀⠀⠀⠀⠀⡴⡱⣿⠦⡀⠀⢀⠤⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⢀⡜⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠦⡉⠒⣺⠭⠅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡜⡑⠀⡿⠀⠈⠞⠁⡘⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⣸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡼⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠎⡰⠁⠸⡇⠀⠀⡀⡰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀      Eh bah alors !?? ");
        Console.WriteLine("⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⠋⠀⠀⣀⣠⠄⠒⠈⠀⠀⠀⠀⠀⠀⢠⠏⠀⠁⠉⠀⠈⠛⢥⣠⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀       On est bloqué !?");
        Console.WriteLine("⠀⠀⠀⠀⠀⢸⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⡰⠁⡠⠖⠋⢠⠃⠀⠀⠀⠀⠀⠀⠀⢀⢔⡏⠀⠀⠀⠀⠸⣷⠠⡀⠙⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀       Plus de graine à planter !?");
        Console.WriteLine("⠀⠀⣠⠔⠋⠉⠀⠀⠀⠈⠉⠙⠒⠦⣄⡀⢠⢣⠊⠀⠀⢀⠆⠀⠀⠀⢀⠊⠀⢠⢁⡎⡸⠀⠀⠀⠀⠀⠀⠈⠉⠁⠀⠘⢦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀        Plus de plante pour attiré un marchand !?");
        Console.WriteLine("⠀⡼⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⡿⣅⠀⠀⠀⡼⠀⠀⢀⡔⠁⠀⣠⡇⡞⢸⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠩⣒⠄⠀⠀⠀⠀⠀⠀⠀⠀  ");
        Console.WriteLine("⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⡀⠀⡇⠀⢠⡞⠀⢀⠔⢹⡎⠀⡞⠀⠀⠀⠀⠀⠀⢠⡒⠒⠷⠿⠷⠒⠚⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀      PTDR ! Tu me fait marrer toi ! ");
        Console.WriteLine("⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣄⠇⢀⢻⢃⣴⠁⠀⢨⠇⣸⠁⠀⠀⠀⠀⠀⠀⢸⠉⠲⢤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          J'ai bien fait de t'amener dans ce monde !");
        Console.WriteLine("⠀⠹⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⡶⡈⠸⠃⡇⢰⠀⡜⢀⠇⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⠀⠙⠦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀         Tu est un vrai bouffon ! ");
        Console.WriteLine("⠀⠀⠹⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠑⢄⠀⠀⢳⠀⠀⣸⢁⢆⡼⡡⡞⠀⠀⠀⠀⠀⠀⠀⠀⠈⣇⠀⠀⠀⠀⠈⢣⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⣠⠼⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡄⠀⠀⢣⠀⣼⠰⢠⣇⠮⠞⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⡄⠀⠀⠀⠀⠀⠱⡄⠀⠀⠀⠀⠀⠀⠀⠀        ");
        Console.WriteLine("⠀⡞⠁⠀⠈⢣⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣗⠲⢤⡀⣃⣷⣡⢷⡖⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⢷⢄⠀⠀⠀⠀⠀⠰⡀⠀⠀⠀⠀⠀⠀⠀       Allez je vais me montrer d'humeur charitable et t'aider !");
        Console.WriteLine("⠰⡇⠀⠀⠀⠀⠙⢦⠀⠀⠀⠀⠀⠀⠀⠀⠸⣀⡴⠋⠁⠀⢠⠎⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠸⠀⠁⠢⡀⠀⠀⠀⠘⢄⠀⠀⠀⠀⠀⠀            Voici une petite graine de Verdichouff !");
        Console.WriteLine("⠀⢧⠀⠀⠀⠀⠀⠀⠑⢦⡀⠀⠀⠀⠀⠀⠀⢻⡀⠀⠀⠀⢸⡠⡶⢀⡜⡰⣡⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠇⠀⠀⠀⠈⠲⣄⡀⠀⠈⠳⢄⠀⠀⠀⠀             ULTRA CHERE !!!!");
        Console.WriteLine("⠀⠘⣆⠀⠀⠀⠀⠀⠀⠀⠙⠢⣄⠀⠀⠀⠀⠀⠳⡄⠀⠀⠘⠁⠗⠃⢿⡟⠙⣿⡈⡄⠀⠀⠀⠀⡄⡀⣰⡟⠀⠀⠀⠀⠀⠀⠈⢯⡑⠢⠄⣀⠑⠢⢀⣀      ");
        Console.WriteLine("⠀⠀⠈⢦⡀⠀⠀⠀⠀⠀⠀⠀⠈⢿⠦⣀⠀⠀⠀⠙⢦⠀⠀⠀⠀⠀⠀⡇⠀⠐⢣⢹⡀⠀⡆⣼⣴⠗⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⡀⠀⠀⠀⠀⠀⠀        ");
        Console.WriteLine("⠀⠀⠀⡜⠻⣄⠀⠀⠀⠀⠀⠀⠀⠸⡴⠚⡟⠢⢄⣀⠀⠳⣄⠀⡟⢲⠒⡇⠀⠀⠀⢑⡇⡼⠛⠉⠁⡼⢡⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⡀⠀⠀⠀⠀⠀         Ne te soucis pour l'argent, je prend à crédit ! ");
        Console.WriteLine("⠀⠀⢸⠁⠀⠈⠳⣄⠀⠀⠀⠀⠀⠀⢳⡀⢷⠀⠀⠈⠙⠒⠬⣿⣇⣸⡀⡇⠀⠀⢀⠏⢹⠀⠀⠀⣰⠃⠀⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⣇⠀⠀⠀⠀⠀     ");
        Console.WriteLine("⠀⠀⢸⠀⠀⠀⠀⠈⠳⣄⠀⠀⠀⠀⠀⠳⣸⠀⠀⠀⠀⠀⣠⠃⠀⢨⣧⡇⠀⠀⡼⠀⡟⠀⠀⢠⠇⠀⠀⠘⡀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢸⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠈⢧⠀⠀⠀⠀⠀⠈⢳⢦⡀⠀⠀⠀⠙⢆⠀⠀⣀⠔⠁⢀⡠⢛⣿⠀⠀⢰⠃⢀⡇⠀⠀⡞⠀⠀⠀⠀⠹⡢⢀⠀⠀⠀⠀⠀⠀⠘⣼⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠈⢳⡀⠀⠀⠀⠀⠈⢧⠉⣳⣤⣀⠀⠈⠳⣮⡥⠴⠚⠉⠀⢸⡏⠀⢀⡟⡀⢸⠁⠀⢸⠁⠀⠀⠀⠀⠀⠱⡀⠑⢤⡀⠀⠀⠀⠀⠹⡄⠀⠀⠀⠀      J");
        Console.WriteLine("⠀⠀⠀⠀⠀⠙⠢⣄⠀⠀⠀⠈⢿⡁⢀⡏⠑⢢⢤⣈⠳⢄⡀⠀⠀⢸⠇⠀⡼⠀⠑⢿⠀⠀⣼⠀⠀⠀⠀⠀⠀⠀⠙⣄⠀⠈⠓⠦⣄⡀⠀⠑⢄⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠙⠲⠤⣀⣀⠙⢼⡀⠀⣿⠀⠈⠉⠓⠻⠶⣄⣸⠀⢠⣧⡀⠀⠈⡇⠀⢸⠈⢲⢄⡀⠀⠀⠀⠀⠈⠳⣄⠀⠀⠀⠈⠉⠐⠒⠓⠄⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⡿⢷⡤⣿⢤⠀⠀⠀⠀⢀⡤⣧⣄⣼⣽⣽⠀⠀⢳⠀⠀⢳⡢⠧⠌⠒⠤⢄⣀⡀⠀⠈⠑⠤⢀⣀⣀⠠⠀⠀⠀⠀       ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠧⡼⠧⠼⠼⠀⠀⠀⠀⢿⣰⡇⢸⡆⣹⠀⠀⠀⠸⡄⠀⢄⢹⠓⡄⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠁⠀⠀⠀⠀⠀⠀        ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠁⠀⠀⠀⠀⠉⠙⠛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");


        Console.ReadKey();
    }
    public void AfficherPotager(List<string> listActions, int action)
    {
        Console.Clear();
        Console.WriteLine($"Semaine : {jeu.semaine}                                                                                            Mode Classique");
        Console.WriteLine($"Argent : {jeu.joueur.argent}                                                                                     ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣤⣤⠤⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠋⢀⢰⢈⣹⠓⣾⢷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣨⠀⢠⠐⣪⣭⣅⢤⣿⠞⠳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣟⣶⢃⡃⠟⠓⡁⣫⡄⡀⠐⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⡰⢫⣟⠿⠧⣿⣿⣥⠴⣴⣮⣏⡣⣄⣲⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⣰⣽⡵⢡⠤⠀⠈⢿⣷⠆⢚⡋⡁⢤⣿⡿⠁⠀⠀⠀⠀⢀⡤⠊⠉⠉⠙⣦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⣠⣤⠖⠶⡟⡧⢿⠀⠀⠀⠀⠀⠛⠶⣾⣷⡶⠟⠛⠉⢣⠀⣀⣀⣀⡜⠁⠀⠀⣠⠏⠁⠀⠀⢹⡠⠤⣄⣄⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⡜⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠞⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⣇⡀⢅⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠁⠩⠵⠴⠲⠔⠶⠶⠶⠦⠴⠶⠶⠶⠖⠦⠤⢴⠏⠀⡴⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡏⡧⡀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡀⠀⠀⣀⣀⣀⢀⣀⠀⠀⠀⠀⠀⠀⣀⣀⠤⠞⠁⠀⡜⢸⡏⠀⢸⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠽⠕⠋⠘⠓⠒⠲⠤⠤⠤⡖⣛⠴⠶⡲⠮⠭⢶⣭⠦⠤⠎⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        AfficherPlante();
        Menu(listActions, action);


    }
    public void ChoixPotager(int action)
    {
        Console.Clear();
        Console.WriteLine($"Semaine : {jeu.semaine}                                                                                            Mode Classique");
        Console.WriteLine($"Argent : {jeu.joueur.argent}                                                                                     ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣤⣤⠤⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠋⢀⢰⢈⣹⠓⣾⢷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣨⠀⢠⠐⣪⣭⣅⢤⣿⠞⠳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣟⣶⢃⡃⠟⠓⡁⣫⡄⡀⠐⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⡰⢫⣟⠿⠧⣿⣿⣥⠴⣴⣮⣏⡣⣄⣲⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⣰⣽⡵⢡⠤⠀⠈⢿⣷⠆⢚⡋⡁⢤⣿⡿⠁⠀⠀⠀⠀⢀⡤⠊⠉⠉⠙⣦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⣠⣤⠖⠶⡟⡧⢿⠀⠀⠀⠀⠀⠛⠶⣾⣷⡶⠟⠛⠉⢣⠀⣀⣀⣀⡜⠁⠀⠀⣠⠏⠁⠀⠀⢹⡠⠤⣄⣄⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⡜⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠞⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⣇⡀⢅⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠁⠩⠵⠴⠲⠔⠶⠶⠶⠦⠴⠶⠶⠶⠖⠦⠤⢴⠏⠀⡴⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡏⡧⡀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡀⠀⠀⣀⣀⣀⢀⣀⠀⠀⠀⠀⠀⠀⣀⣀⠤⠞⠁⠀⡜⢸⡏⠀⢸⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠽⠕⠋⠘⠓⠒⠲⠤⠤⠤⡖⣛⠴⠶⡲⠮⠭⢶⣭⠦⠤⠎⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        ChoixPlante(action);
        Console.WriteLine();
        Console.WriteLine("Choisissez une plante ! ");


    }
    public void ChoixTerrain(int action)
    {
        Console.Clear();
        Console.WriteLine($"Semaine : {jeu.semaine}                                                                                            Mode Classique");
        Console.WriteLine($"Argent : {jeu.joueur.argent}                                                                                     ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣤⣤⠤⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠋⢀⢰⢈⣹⠓⣾⢷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣨⠀⢠⠐⣪⣭⣅⢤⣿⠞⠳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣟⣶⢃⡃⠟⠓⡁⣫⡄⡀⠐⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⡰⢫⣟⠿⠧⣿⣿⣥⠴⣴⣮⣏⡣⣄⣲⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⣰⣽⡵⢡⠤⠀⠈⢿⣷⠆⢚⡋⡁⢤⣿⡿⠁⠀⠀⠀⠀⢀⡤⠊⠉⠉⠙⣦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⣠⣤⠖⠶⡟⡧⢿⠀⠀⠀⠀⠀⠛⠶⣾⣷⡶⠟⠛⠉⢣⠀⣀⣀⣀⡜⠁⠀⠀⣠⠏⠁⠀⠀⢹⡠⠤⣄⣄⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⡜⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠞⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⣇⡀⢅⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠁⠩⠵⠴⠲⠔⠶⠶⠶⠦⠴⠶⠶⠶⠖⠦⠤⢴⠏⠀⡴⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡏⡧⡀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡀⠀⠀⣀⣀⣀⢀⣀⠀⠀⠀⠀⠀⠀⣀⣀⠤⠞⠁⠀⡜⢸⡏⠀⢸⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠽⠕⠋⠘⠓⠒⠲⠤⠤⠤⡖⣛⠴⠶⡲⠮⠭⢶⣭⠦⠤⠎⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        AfficherTerrain(action);
        Console.WriteLine();
        Console.WriteLine("Choisissez un Terrain ! ");


    }
    public void AfficherTerrain(int plante)
    {
        for (int i = 0; i < 22; i++) // 22 est la taille des sprites. oui c'est pas opti mais manque de temps

        {
            string un = (jeu.potagerPrincipale.terrains[0].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[0].animalApprivoiser?.Sprite()[i] + " " : "                    ";
            string deux = (jeu.potagerPrincipale.terrains[1].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[1].animalApprivoiser?.Sprite()[i] + " " : "                    ";
            string trois = (jeu.potagerPrincipale.terrains[2].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[2].animalApprivoiser?.Sprite()[i] + " " : "                    ";
            string quatre = (jeu.potagerPrincipale.terrains[3].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[3].animalApprivoiser?.Sprite()[i] + " " : "                    ";

            un += (jeu.potagerPrincipale.terrains[0].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[0].plante?.Sprite()[i] : "###################";
            deux += (jeu.potagerPrincipale.terrains[1].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[1].plante?.Sprite()[i] : "###################";
            trois += (jeu.potagerPrincipale.terrains[2].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[2].plante?.Sprite()[i] : "###################";
            quatre += (jeu.potagerPrincipale.terrains[3].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[3].plante?.Sprite()[i] : "###################";
            string[] possibilite = new string[] { un, deux, trois, quatre };
            Console.WriteLine();
            for (int j = 0; j < 4; j++)
            {
                if (j == plante)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{possibilite[j]} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write($"{possibilite[j]} ");
                }
            }
        }
    }
    public void ChoixPlante(int plante)
    {
        for (int i = 0; i < 22; i++) // 22 est la taille des sprites. oui c'est pas opti mais manque de temps

        {
            string un = (jeu.potagerPrincipale.terrains[0].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[0].animalApprivoiser?.Sprite()[i] + " " : "                    ";
            string deux = (jeu.potagerPrincipale.terrains[1].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[1].animalApprivoiser?.Sprite()[i] + " " : "                    ";
            string trois = (jeu.potagerPrincipale.terrains[2].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[2].animalApprivoiser?.Sprite()[i] + " " : "                    ";
            string quatre = (jeu.potagerPrincipale.terrains[3].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[3].animalApprivoiser?.Sprite()[i] + " " : "                    ";

            un += (jeu.potagerPrincipale.terrains[0].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[0].plante?.Sprite()[i] : "                  ";
            deux += (jeu.potagerPrincipale.terrains[1].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[1].plante?.Sprite()[i] : "                  ";
            trois += (jeu.potagerPrincipale.terrains[2].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[2].plante?.Sprite()[i] : "                  ";
            quatre += (jeu.potagerPrincipale.terrains[3].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[3].plante?.Sprite()[i] : "                  ";
            string[] possibilite = new string[] { un, deux, trois, quatre };
            Console.WriteLine();
            for (int j = 0; j < 4; j++)
            {
                if (j == plante)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{possibilite[j]} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write($"{possibilite[j]} ");
                }
            }
        }
    }
    public void AfficherPlante()
    {
        for (int i = 0; i < 22; i++) // 22 est la taille des sprites. oui c'est pas opti mais manque de temps

        {
            string un = (jeu.potagerPrincipale.terrains[0].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[0].animalApprivoiser?.Sprite()[i] + " " : "                    ";
            string deux = (jeu.potagerPrincipale.terrains[1].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[1].animalApprivoiser?.Sprite()[i] + " " : "                    ";
            string trois = (jeu.potagerPrincipale.terrains[2].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[2].animalApprivoiser?.Sprite()[i] + " " : "                    ";
            string quatre = (jeu.potagerPrincipale.terrains[3].animalApprivoiser?.Sprite() != null) ? jeu.potagerPrincipale.terrains[3].animalApprivoiser?.Sprite()[i] + " " : "                    ";

            un += (jeu.potagerPrincipale.terrains[0].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[0].plante?.Sprite()[i] : "                  ";
            deux += (jeu.potagerPrincipale.terrains[1].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[1].plante?.Sprite()[i] : "                  ";
            trois += (jeu.potagerPrincipale.terrains[2].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[2].plante?.Sprite()[i] : "                  ";
            quatre += (jeu.potagerPrincipale.terrains[3].plante?.Sprite() != null) ? jeu.potagerPrincipale.terrains[3].plante?.Sprite()[i] : "                  ";
            Console.WriteLine($"{un} {deux} {trois} {quatre}");
        }
    }
    public void Menu(List<string> listActions, int action)
    {
        Console.WriteLine();
        for (int i = 0; i < listActions.Count; i++)
        {
            if (i != action)
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("|" + listActions[i] + "|");
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void InfoPotager(Potager potager)
    {
        Console.Clear();
        int i = 1;
        foreach (Terrain terrain in potager.terrains)
        {
            string afficher = (terrain.plante != null) ? $" Terrain n°{i} de type {terrain.type} => {terrain.plante}" : $" Terrain n°{i} de type {terrain.type} => Pas de plante";
            Console.WriteLine(afficher);
            i++;
        }
        Console.ReadKey();
    }
    public void AffichageMarchand(List<string> actionPossible, int action)
    {
        Console.Clear();
        Console.WriteLine($"Semaine : {jeu.semaine}                                                                                            Mode Urgence");
        Console.WriteLine($"Argent : {jeu.joueur.argent}                                                                                          ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⠻⢷⣦⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⣀⣀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡴⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣦⣄⣠⡤⠒⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⢾⣤⣤⣤⣴⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠙⠻⣿⣿⣿⣿⣿⣯⣿⣿⣿⣭⣭⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀                 Je suis le marchand...");
        Console.WriteLine("⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡆⠀⠀⠀⠀⠀               Je vends Plein de trucs...");
        Console.WriteLine("⠀⠀⠀⠀⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡄⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣿⢿⣿⣿⣿⣿⣿⣿⡀⠀⠀⠀             Enfin à ceux qui ont de l'argent...");
        Console.WriteLine("⠀⠀⢀⣾⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃⣿⣿⣿⣿⣿⣿⣿⠹⣿⣿⣿⣿⣿⣿⠟⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠻⠆⠀⠀               ... ");
        Console.WriteLine("⠀⠰⠿⠿⠿⣿⣿⣿⣿⣿⣿⡿⠀⢠⣿⣿⣿⣿⣿⣿⣿⡄⣿⣿⣿⣿⣿⣿⠀⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⠑⠊⠙⣿⣿⣿⠿⠿⠿⠛⠃⠙⠛⣛⣿⣿⣿⣄⡸⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀               C'est à dire pas grand monde...");
        Console.WriteLine("⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⡧⣴⡾⠿⠛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠙⠛⠛⠛⠿⢿⣻⠶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⡅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⡿⠋⠉⠉⠻⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣷⢾⣍⠙⠆⢸⣿⣿⣿⣿⣿⣿⣿⡆⠀                       Les gens sont pauvre  ");
        Console.WriteLine("⠐⠀⠴⠀⠀⠀⢹⣿⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠈⠛⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⡧⠴⠋⠀⣠⣿⣿⣿⣿⣿⣿⣿⣿⣷⠀");
        Console.WriteLine("⠀⠀⠦⠄⠀⠀⠀⠹⣿⣿⠿⣧⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⣿⣿⣿⣀⣠⣴⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⣀⣀⠀⢀⣿⣿⣿⣿⣿⣶⣦⣤⣀⣀⡀⠀⠀⠀⠀⠀⠀⢀⣤⣴⣾⣿⣿⣿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡄");
        Console.WriteLine("⠀⠀⠀⠀⠀⢿⣽⠧⠾⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⡄⠀⠀⠀⢸⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠁⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⠀⠀⢻⣿⠿⠛⠉⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣾⣿⣿⣿⣿⣿⠃");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⡿⢿⣿⣿⠟⠁⠀⣀⣤⠴⠛⠉⠀⠀⠀⠀⠀⠈⢻⣿⣿⣿⣿⣿⣿⣿⣻⣿⣿⣿⣿⣿⣿⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⠟⠋⣀⣾⣋⣤⡤⠖⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⡇⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⡿⠛⠁⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⣿⣿⣿⣿⣿⡏⢸⣿⡿⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⡉⠉⠉⠉⠀⠈⠉⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⢰⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣷⠀⠀\n\n\n");
        Console.WriteLine("Choisir une action :");
        Menu(actionPossible, action);
    }
    public void VisiteurPlante(Visiteur visiteur, Terrain terrain)
    {
        for (int i = 0; i < 22; i++) // 22 est la taille des sprites. oui c'est pas opti mais manque de temps

        {
            Console.WriteLine($"{visiteur.Sprite()[i]} {terrain.plante?.Sprite()[i]}");
        }
    }
    public void AffichageAnimalMonstre(Visiteur visiteur, Terrain terrain, List<string> listActions, int action)
    {
        Console.Clear();
        Console.WriteLine($"Un {visiteur.nom} est apparue dans votre potager et menace votre {terrain.plante?.nom} !\t\t\t");
        VisiteurPlante(visiteur, terrain);
        Console.WriteLine("Choississez une action VITE :");
        Menu(listActions, action);
    }
}
