
//    Définir une classe Livre avec les attributs suivants : Titre, Auteur (Nom complet), Prix.
//    Définir à l’aide des propriétés les méthodes d’accès aux différents attributs de la classe.
//    Définir un constructeur permettant d’initialiser les attributs d'une instance par des valeurs saisies par l’utilisateur.
//    Définir la méthode Afficher ( ) permettant d’afficher les informations du livre en cours.
//    Écrire un programme testant la classe Livre.

using TPLivre;

// création d'une liste de livre
List<Livre> Livres = new List<Livre>();

// 1er livre
Livre L1 = new Livre();
Livres.Add(L1);
Console.WriteLine("Titre du livre : ");
string titre = Console.ReadLine();
Console.WriteLine("Auteur du livre : ");
string auteur = Console.ReadLine();
Console.WriteLine("Prix du livre : ");
decimal prix = decimal.Parse(Console.ReadLine());

L1.SetTitre(titre);// avec le getter
L1.Titre = titre; // avec la properties

L1.Auteur = auteur;
L1.Prix = prix;



// 2eme livre

Console.WriteLine("Titre du livre : ");
titre = Console.ReadLine();
Console.WriteLine("Auteur du livre : ");
auteur = Console.ReadLine();
Console.WriteLine("Prix du livre : ");
prix = decimal.Parse(Console.ReadLine());

Livre L2 = new Livre(titre,auteur,prix);
Livres.Add(L2);

foreach (Livre livre in Livres)
{
    livre.Afficher();
}