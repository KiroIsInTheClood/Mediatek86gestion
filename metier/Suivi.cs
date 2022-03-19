using System.Collections.Generic;

namespace Mediatek86.metier
{
    /// <summary>
    /// Permet de connaitre l'état de la commande
    /// </summary>
    public class Suivi
    {
        /// <summary>
        /// Identifiant de l'état pour la commande
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Libellé de la commande
        /// </summary>
        public string Libelle { get; }

        /// <summary>
        /// Objet représentant l'état de la commande (id + libellé)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        public Suivi(string id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }

        /// <summary>
        /// Permet de stocker les états de commandes dans une liste
        /// </summary>
        public static List<Suivi> SuiviItems { get; set; }

        /// <summary>
        /// Retourne le libellé de l'élement
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Libelle;
        }

        /// <summary>
        /// Permet de savoir si la commande a un état
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Suivi LibelleCmd(string id)
        {
            foreach (Suivi suivi in SuiviItems)
            {
                if (suivi.Id == id) return suivi;
            }
            return new Suivi("-1", "Erreur");
        }
    }
}
