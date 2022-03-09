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
    public class CommandeDocument
    {
        /// <summary>
        /// Id de la commande
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Date de la commande
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Montant de la commande
        /// </summary>
        public double Montant { get; set; }
        /// <summary>
        /// Nombre d'exemplaires
        /// </summary>
        public int NombreExemplaire { get; set; }
        /// <summary>
        /// Id du Livre/DVD
        /// </summary>
        public string IdLivDVD { get; set; }
        /// <summary>
        /// Titre du Livre/DVD
        /// </summary>
        public string Titre { get; set; }
        /// <summary>
        /// Etat de la commande
        /// </summary>
        public Suivi Etat { get; set; }

        public CommandeDocument(string id, DateTime date, double montant, int nombreExemplaire, string idLivDVD, string titre, Suivi etat)
        {
            Id = id;
            Date = date;
            Montant = montant;
            NombreExemplaire = nombreExemplaire;
            IdLivDVD = idLivDVD;
            Titre = titre;
            Etat = etat;
        }
    }
}
