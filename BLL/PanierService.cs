
using DAL.Entity;
using DAL.Repos;
using Models.Panier;

namespace BLL;

public class PanierService
{

    public void CreatePanier(int idProduit)
    {
        PanierRepos panierRepos = new PanierRepos();
        Panier panier = new Panier();
        panier.Date = DateTime.Now;
        panier.IdClient = 1;
        panier.Etat = true;


        var idPanier = panierRepos.Create(panier);

        //get Produit Information 
        BookRepos produitRepos = new BookRepos();
        var produit = produitRepos.Read(idProduit);

        PanierBook panierBook = new PanierBook();
        panierBook.IdPanier = idPanier;
        panierBook.IdProduit = idProduit;
        panierBook.Quantiter = 1;

        PanierBookRepos panierProduitRepos = new PanierBookRepos();
        panierProduitRepos.Create(panierBook);


    }

    public PanierVM GetPanier()
    {
        PanierVM panierVM = new PanierVM();

        #region "PanierRepos"
        PanierRepos panierRepos = new PanierRepos();
        var pEntity = panierRepos.Read(1);
        panierVM.Date = pEntity.Date;
        panierVM.Total = pEntity.Total;
        #endregion 

        for (int i = 0; i < 5; i++)
        {
            LignPanier P = new LignPanier();
            P.IdBook= 1;
            P.Quantite = 1 + i;
            P.PrixBook = 9 * i;
            P.Description = "Description " + i;
            panierVM.L.Add(P);
        }

        return panierVM;

    }
}