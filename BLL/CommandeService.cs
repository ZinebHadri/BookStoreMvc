using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos;
using Models.Commande;

namespace BLL
{
    public class CommandeService
    {
        private readonly CommandeRepos _commandeRepos;

        public CommandeService()
        {
            _commandeRepos = new CommandeRepos();
        }

        public CommandeVM GetCommande(int id)
        {
            var commande = _commandeRepos.Read(id);

            var model = new CommandeVM
            {
                Montant = commande.Montant,
                Numero = commande.NCommande,
                Date = commande.Date
            };

            return model;
        }
    }
}
