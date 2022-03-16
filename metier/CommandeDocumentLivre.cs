using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    /// <summary>
    /// La commande d'un document
    /// </summary>
    public class CommandeDocumentLivre
    {
        private readonly string id;
        private readonly DateTime date;
        private readonly double montant;
        private readonly int nombreExemplaire;
        private readonly string idLivDVD;
        private readonly string idSuivi;
        private readonly string libelleSuivi;
        private readonly string isbn;
        private readonly string titre;
        private readonly string auteur;
        private readonly string collection;
        private readonly string genre;
        private readonly string publicdoc;
        private readonly string rayon;
        private readonly string image;

        public CommandeDocumentLivre(string id, DateTime date, double montant, int nombreExemplaire, 
            string idLivDVD, string idSuivi, string libelleSuivi, string isbn, string titre, 
            string auteur, string collection, string genre, string publicdoc, string rayon, string image)
        {
            this.id = id;
            this.date = date;
            this.montant = montant;
            this.nombreExemplaire = nombreExemplaire;
            this.idLivDVD = idLivDVD;
            this.idSuivi = idSuivi;
            this.libelleSuivi = libelleSuivi;
            this.isbn = isbn;
            this.titre = titre;
            this.auteur = auteur;
            this.collection = collection;
            this.genre = genre;
            this.publicdoc = publicdoc;
            this.rayon = rayon;
            this.image = image;
        }

        public string Id { get => id; }
        public DateTime DateDeCommande { get => date; }
        public string Montant { get => montant + "€"; }
        public int NombreExemplaire { get => nombreExemplaire; }
        public string IdLivDVD { get => idLivDVD; }
        public string IdSuivi { get => idSuivi; }
        public string Etat { get => libelleSuivi; }
        public string ISBN { get => isbn; }
        public string Titre { get => titre; }
        public string Auteur { get => auteur; }
        public string Collection { get => collection; }
        public string Genre { get => genre; }
        public string Public { get => publicdoc; }
        public string Rayon { get => rayon; }
        public string Image { get => image; }
    }
}
