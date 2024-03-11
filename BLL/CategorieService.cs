using DAL.Entity;
using DAL.Repos;
using Models.Categorie;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class CategorieService
    {
        private readonly CategorieRepos _categorieRepository = new CategorieRepos();
        public List<CategorieVM> ListDetailVM()
        {

            var categorieRepos = new CategorieRepos();


            List<CategorieVM> listViewModels = new List<CategorieVM>();

            foreach (var item in categorieRepos.All())
            {
                CategorieVM categorieListViewModel = new CategorieVM();
                categorieListViewModel.Id = item.Id;
                categorieListViewModel.Nom = item.NomCategorie;
                categorieListViewModel.Description = item.Description;
                categorieListViewModel.NomImage = item.NomImage;
                listViewModels.Add(categorieListViewModel);
            }
            return listViewModels;
        }


        public List<Categorie> GetAllCategories()
        {
            return _categorieRepository.All();
        }

        public Categorie GetCategoryById(int id)
        {
            return _categorieRepository.GetById(id);
        }

    }
}
