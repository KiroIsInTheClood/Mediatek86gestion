using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    public class AbonnementRevue
    {
        private readonly string id;
        private readonly DateTime dateCommande;
        private readonly DateTime dateFinAbonnement;
        private readonly string idRevue;
        private readonly bool empruntable;
        private readonly string titre;
        private readonly string periodicite;
        private readonly int delaiMiseDispo;
        private readonly string genre;
        private readonly string publicdoc;
        private readonly string rayon;
        private readonly string image;
        private readonly double montant;

        public AbonnementRevue(string id, DateTime dateCommande, DateTime dateFinAbonnement, string idRevue,
            bool empruntable, string titre, string periodicite, int delaiMiseDispo, string genre, string publicdoc, string rayon,
            string image, double montant)
        {
            this.id = id;
            this.dateCommande = dateCommande;
            this.dateFinAbonnement = dateFinAbonnement;
            this.idRevue = idRevue;
            this.empruntable = empruntable;
            this.titre = titre;
            this.periodicite = periodicite;
            this.delaiMiseDispo = delaiMiseDispo;
            this.genre = genre;
            this.publicdoc = publicdoc;
            this.rayon = rayon;
            this.image = image;
            this.montant = montant;
        }

        public string Id { get => id; }
        public DateTime DateDeCommande { get => dateCommande; }
        public DateTime DateDeFinAbonnement { get => dateFinAbonnement; }
        public string IdRevue { get => idRevue; }
        public bool Empruntable { get => empruntable; }
        public string Titre { get => titre; }
        public string Periodicite { get => periodicite; }
        public int DelaiMiseDispo { get => delaiMiseDispo; }
        public string Genre { get => genre; }
        public string Public { get => publicdoc; }
        public string Rayon { get => rayon; }
        public string Image { get => image; }
        public string Montant { get => montant + "€"; }
    }
}
