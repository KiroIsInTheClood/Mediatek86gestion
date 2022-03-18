using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mediatek86.modele;
using Mediatek86.metier;
using Mediatek86.bdd;
using System.Collections.Generic;
using System;

namespace Mediatek86.modele.Tests
{
    [TestClass()]
    public class DaoTests
    {
        private static readonly string server = "localhost";
        private static readonly string userid = "root";
        private static readonly string password = "";
        private static readonly string database = "mediatek86";
        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";
        private readonly BddMySql curs = BddMySql.GetInstance(connectionString);
        private void BeginTransaction()
        {
            curs.ReqUpdate("SET AUTOCOMMIT=0", null);
            curs.ReqUpdate("START TRANSACTION", null);
        }

        private void EndTransaction()
        {
            curs.ReqUpdate("ROLLBACK", null);
        }

        [TestMethod()]
        public void GetAllGenresTest()
        {
            List<Categorie> lesGenres = Dao.GetAllGenres();
            Assert.IsTrue(lesGenres.Count != 0, "devrait réussir : au moins un genre");
        }

        [TestMethod()]
        public void GetAllRayonsTest()
        {
            List<Categorie> lesRayons = Dao.GetAllRayons();
            Assert.IsTrue(lesRayons.Count != 0, "devrait réussir : au moins un rayon");
        }

        [TestMethod()]
        public void GetAllPublicsTest()
        {
            List<Categorie> lesPublics = Dao.GetAllPublics();
            Assert.IsTrue(lesPublics.Count != 0, "devrait réussir : au moins un public");
        }

        [TestMethod()]
        public void GetAllLivresTest()
        {
            List<Livre> lesLivres = Dao.GetAllLivres();
            Assert.IsTrue(lesLivres.Count != 0, "devrait réussir : au moins un livre");
        }

        [TestMethod()]
        public void GetAllDvdTest()
        {
            List<Dvd> lesDVDs = Dao.GetAllDvd();
            Assert.IsTrue(lesDVDs.Count != 0, "devrait réussir : au moins un DVD");
        }

        [TestMethod()]
        public void GetAllRevuesTest()
        {
            List<Revue> lesRevues = Dao.GetAllRevues();
            Assert.IsTrue(lesRevues.Count != 0, "devrait réussir : au moins une revue");
        }

        [TestMethod()]
        public void GetExemplairesRevueTest()
        {
            List<Exemplaire> lesExemplaires = Dao.GetExemplairesRevue("10011");
            Assert.IsTrue(lesExemplaires.Count != 0, "devrait réussir : au moins un exemplaire de cette revue existe");
        }

        [TestMethod()]
        public void CreerExemplaireTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCommandesLivresTest()
        {
            List<CommandeDocumentLivre> lesCommandesLivres = Dao.GetCommandesLivres();
            Assert.IsTrue(lesCommandesLivres.Count != 0, "devrait réussir : au moins une commande de livre");
        }

        [TestMethod()]
        public void GetAllSuivisTest()
        {
            List<Suivi> lesSuivis = Dao.GetAllSuivis();
            Assert.IsTrue(lesSuivis.Count != 0, "devrait réussir : au moins une etape de suivi existe");
        }

        [TestMethod()]
        public void ModifierCommandeLivreDVDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreerCommandeTest()
        {
            BeginTransaction();
            // Je ne ferrais le test que sur les commandes de livres meme si cette methode est universelle
            // Car si ca fonctionne pour l'un cela fonctionnera pour les deux autres
            List<CommandeDocumentLivre> lesCommandesLivres = Dao.GetCommandesLivres();
            int nbBeforeInsert = lesCommandesLivres.Count;
            string id = "TESTS";
            DateTime date = DateTime.Today;
            double montant = 1;
            int nbExemplaires = 1;
            string idLivre = "00001";
            string idSuivi = "00001";
            string libelleSuivi = "En cours.";
            string isbn = "1234569877896";
            string titre = "Quand sort la recluse";
            string auteur = "Fred Vargas";
            string collection = "Commissaire Adamsberg";
            string genre = "Policier";
            string publicdoc = "Adultes";
            string rayon = "Policiers français étrangers";
            string image = "";
            Dao.CreerCommande(id, (int)montant, date);
            Dao.CreerCommandeDocument2(id, idLivre, nbExemplaires);
            lesCommandesLivres = Dao.GetCommandesLivres();
            int nbAfterInsert = lesCommandesLivres.Count;
            CommandeDocumentLivre commandeAdd = lesCommandesLivres.Find(obj => obj.Id.Equals(id)
                && (obj.DateDeCommande == date)
                && (obj.Montant == montant + "€")
                && (obj.NombreExemplaire == nbExemplaires)
                && obj.IdLivDVD.Equals(idLivre)
                && obj.IdSuivi.Equals(idSuivi)
                && obj.Etat.Equals(libelleSuivi)
                && obj.ISBN.Equals(isbn)
                && obj.Titre.Equals(titre)
                && obj.Auteur.Equals(auteur)
                && obj.Collection.Equals(collection)
                && obj.Genre.Equals(genre)
                && obj.Public.Equals(publicdoc)
                && obj.Rayon.Equals(rayon)
                && obj.Image.Equals(image)
                );
            Assert.IsNotNull(commandeAdd, "devrait réussir : une commande a étée ajouté");
            Assert.AreEqual(nbBeforeInsert + 1, nbAfterInsert, "devrait réussir : une commande en plus");
            EndTransaction();
        }

        [TestMethod()]
        public void CreerCommandeDocument2Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SupprimerCommandeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SupprimerCommande2Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCommandesDvdTest()
        {
            List<CommandeDocumentDvd> lesCommandesDVDs = Dao.GetCommandesDvd();
            Assert.IsTrue(lesCommandesDVDs.Count != 0, "devrait réussir : au moins une commande de DVD");
        }

        [TestMethod()]
        public void GetAbonnementsRevuesTest()
        {
            List<AbonnementRevue> lesAbonnementsRevues = Dao.GetAbonnementsRevues();
            Assert.IsTrue(lesAbonnementsRevues.Count != 0, "devrait réussir : au moins un abonnement de revue");
        }

        [TestMethod()]
        public void CreerAbonnementTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SupprimerAbonnementTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ControleAuthentificationTest()
        {
            string identifiant = "admin";
            string mdp = "admin";
            Service service = new Service("admin", 1, "Administratif");
            Service servicetest = new Service(service.Utilisateur, service.ServiceInt, service.Nom);
            Service service2 = Dao.ControleAuthentification(identifiant, mdp);
            bool test = (service.Nom == service2.Nom);
            bool test2 = (service.ServiceInt == service2.ServiceInt);
            bool test3 = (service.Utilisateur == service2.Utilisateur);
            bool test4 = (servicetest == service2);
            Assert.AreEqual(service, Dao.ControleAuthentification(identifiant, mdp), "devrait reussir");
            string identifiantFaux = "ananas";
            string mdpFaux = "ananas";
            Assert.AreEqual(null, Dao.ControleAuthentification(identifiantFaux, mdpFaux), "devrait echouer : tout est faux");
            Assert.AreEqual(null, Dao.ControleAuthentification(identifiant, mdpFaux), "devrait echouer : mdp est faux");
            Assert.AreEqual(null, Dao.ControleAuthentification(identifiantFaux, mdp), "devrait echouer : identifiant est faux");
        }
    }
}