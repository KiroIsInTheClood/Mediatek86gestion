using System.Collections.Generic;
using Mediatek86.modele;
using Mediatek86.metier;
using Mediatek86.vue;
using System;

namespace Mediatek86.controleur
{
    internal class Controle
    {
        private readonly List<Livre> lesLivres;
        private readonly List<Dvd> lesDvd;
        private readonly List<Revue> lesRevues;
        private readonly List<Categorie> lesRayons;
        private readonly List<Categorie> lesPublics;
        private readonly List<Categorie> lesGenres;
        private List<CommandeDocumentLivre> lesCommandesLivres;
        private List<CommandeDocumentDvd> lesCommandesDvd;
        private List<CommandeRevue> lesCommandesRevues;
        private readonly List<Suivi> lesSuivis;

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            lesLivres = Dao.GetAllLivres();
            lesDvd = Dao.GetAllDvd();
            lesRevues = Dao.GetAllRevues();
            lesGenres = Dao.GetAllGenres();
            lesRayons = Dao.GetAllRayons();
            lesPublics = Dao.GetAllPublics();
            lesSuivis = Dao.GetAllSuivis();
            FrmMediatek frmMediatek = new FrmMediatek(this);
            frmMediatek.ShowDialog();
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Collection d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return lesGenres;
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Collection d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return lesLivres;
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Collection d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return lesDvd;
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Collection d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return lesRevues;
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Collection d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return lesRayons;
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Collection d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return lesPublics;
        }

        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <returns>Collection d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return Dao.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return Dao.CreerExemplaire(exemplaire);
        }

        /// <summary>
        /// Recupère toutes les commandes de livres dans la base de données
        /// </summary>
        /// <returns>La liste contenant toutes les commandes</returns>
        public List<CommandeDocumentLivre> GetCommandesLivres()
        {
            lesCommandesLivres = Dao.GetCommandesLivres();
            return lesCommandesLivres;
        }

        /// <summary>
        /// Recupère tout les suivis de la base de données
        /// </summary>
        /// <returns>La liste contenant tout les suivis</returns>
        public List<Suivi> GetAllSuivis()
        {
            return lesSuivis;
        }

        /// <summary>
        /// Permet de modifier une commande depuis l'onglet de Gestion des commandes (Livres)
        /// </summary>
        /// <param name="idCommande"></param>
        /// <param name="idSuivi"></param>
        public void ModifierCommandeLivreDVD(string idCommande, string idSuivi)
        {
            Dao.ModifierCommandeLivreDVD(idCommande, idSuivi);
        }

        /// <summary>
        /// Permet de créer une commande depuis l'onglet de Gestion des commandes (Livres)
        /// </summary>
        /// <param name="idCommande"></param>
        /// <param name="montant"></param>
        /// <param name="dateCommande"></param>
        /// <param name="livreId"></param>
        /// <param name="nbExemplaire"></param>
        public void CreerCommandeLivreDVD(string idCommande, int montant, DateTime dateCommande, string livreId, int nbExemplaire)
        {
            Dao.CreerCommande(idCommande, montant, dateCommande);
            Dao.CreerCommandeDocument2(idCommande, livreId, nbExemplaire);
        }

        /// <summary>
        /// Permet de supprimer une commande depuis l'onglet de Gestion des commandes (Livres)
        /// </summary>
        /// <param name="id"></param>
        public void SupprimerCommandeLivreDVD(string id)
        {
            Dao.SupprimerCommande(id);
            Dao.SupprimerCommande2(id);
        }

        /// <summary>
        /// Recupère toutes les commandes de DVD dans la base de données
        /// </summary>
        /// <returns>La liste contenant toutes les commandes</returns>
        public List<CommandeDocumentDvd> GetCommandesDvd()
        {
            lesCommandesDvd = Dao.GetCommandesDvd();
            return lesCommandesDvd;
        }

        public List<CommandeRevue> GetCommandesRevues()
        {
            lesCommandesRevues = Dao.GetCommandesRevues();
            return lesCommandesRevues;
        }

        public void CreerAbonnement(string idCommande, int montant, DateTime dateDebutAbonnement,
            DateTime dateFinAbonnement, string revueId)
        {
            Dao.CreerCommande(idCommande, montant, dateDebutAbonnement);
            Dao.CreerAbonnement(idCommande, dateFinAbonnement, revueId);
        }

        public void SupprimerAbonnnement(string idCommande)
        {
            Dao.SupprimerAbonnement(idCommande);
            Dao.SupprimerCommande2(idCommande);
        }
    }
}

