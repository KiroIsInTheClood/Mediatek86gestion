using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    public class CommandeDocumentDvd
    {
        private readonly string id;
        private readonly DateTime date;
        private readonly double montant;
        private readonly int nombreExemplaire;
        private readonly string idLivDVD;
        private readonly string idSuivi;
        private readonly string libelleSuivi;
        private readonly int duree;
        private readonly string titre;
        private readonly string realisateur;
        private readonly string synopsis;
        private readonly string genre;
        private readonly string publicdoc;
        private readonly string rayon;
        private readonly string image;

        public CommandeDocumentDvd(string id, DateTime date, double montant, int nombreExemplaire,
            string idLivDVD, string idSuivi, string libelleSuivi, int duree, string titre,
            string realisateur, string synopsis, string genre, string publicdoc, string rayon, string image)
        {
            this.id = id;
            this.date = date;
            this.montant = montant;
            this.nombreExemplaire = nombreExemplaire;
            this.idLivDVD = idLivDVD;
            this.idSuivi = idSuivi;
            this.libelleSuivi = libelleSuivi;
            this.duree = duree;
            this.titre = titre;
            this.realisateur = realisateur;
            this.synopsis = synopsis;
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
        public int Duree { get => duree; }
        public string Titre { get => titre; }
        public string Realisateur { get => realisateur; }
        public string Synopsis { get => synopsis; }
        public string Genre { get => genre; }
        public string Public { get => publicdoc; }
        public string Rayon { get => rayon; }
        public string Image { get => image; }
    }
}
