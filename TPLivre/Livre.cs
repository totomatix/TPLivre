using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLivre
{
    /// <summary>
    /// Class représenant un livre
    /// 3 attributs : titre, auteur et prix
    /// </summary>
    public class Livre
    {
        private string _Titre;
        private string _Auteur;
        private decimal _Prix;

        /// <summary>
        /// Titre du livre
        /// </summary>
        public string Titre { get => _Titre; set => _Titre = value; }
        /// <summary>
        /// Auteur du livre (Nom complet)
        /// </summary>
        public string Auteur { get => _Auteur; set => _Auteur = value; }
        /// <summary>
        /// Prix du livre
        /// </summary>
        public decimal Prix { get => _Prix; set => _Prix = value; }

        /// <summary>
        /// Constructeur de Livre (livre vide)
        /// </summary>
        public Livre()
        {

        }
        /// <summary>
        /// Constructeur de livre sans le prix
        /// </summary>
        /// <param name="titre">Titre du livre</param>
        /// <param name="auteur">Auteur du livre</param>
        public Livre(string titre, string auteur)
        {
            Titre = titre;
            Auteur = auteur;
        }
        /// <summary>
        /// Constructeur complet de livre 
        /// </summary>
        /// <param name="titre">Titre du livre</param>
        /// <param name="auteur">Auteur du livre</param>
        /// <param name="prix">Prix du livre</param>
        public Livre(string titre, string auteur, decimal prix)
        {
            Titre = titre;
            Auteur = auteur;
            Prix = prix;
        }

        /// <summary>
        /// Permet de récupérer le titre du livre
        /// </summary>
        /// <returns>Titre du livre</returns>
        public string GetTitre()
        {
            return _Titre;
        }
        /// <summary>
        /// Permet de modifier le titre du livre
        /// </summary>
        /// <param name="titre">nouveau titre du livre</param>
        public void SetTitre(string titre)
        {
            _Titre = titre;
        }
        /// <summary>
        /// Permet d'obtenir l'auteur du livre
        /// </summary>
        /// <returns>Auteur du livre</returns>
        public string GetAuteur()
        {
            return _Auteur;
        }
        /// <summary>
        /// Permet de modifier l'auteur du livre
        /// </summary>
        /// <param name="auteur">Nouvel auteur du livre</param>
        public void SetAuteur(string auteur)
        {
            _Auteur = auteur;
        }

        /// <summary>
        /// Permet d'obtenir le prix du livre
        /// </summary>
        /// <returns>Prix du livre</returns>
        public decimal GetPrix()
        {
            return _Prix;
        }
        /// <summary>
        /// Permet de modifier le prix du livre
        /// </summary>
        /// <param name="prix">Nouveau prix du livre</param>
        public void SetPrix(decimal prix)
        {
            _Prix = prix;
        }
        /// <summary>
        /// Permet d'afficher toutes les informations d'un livre
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine($"Titre : {Titre}");
            Console.WriteLine($"Auteur : {Auteur}");
            Console.WriteLine($"Prix : {Prix}");
        }
    }
}
