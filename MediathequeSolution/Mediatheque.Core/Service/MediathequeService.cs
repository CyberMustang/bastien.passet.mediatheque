using System.Collections.Generic;
using Mediatheque.Core.Model;

namespace Mediatheque.Core.Service
{
    public class MediathequeService
    {
        private readonly List<ObjetDePret> _fondDeCommerce = new List<ObjetDePret>();
        private readonly INotationService _notationService;

        public MediathequeService(INotationService notationService)
        {
            _notationService = notationService;
        }

        public void AddObjet(ObjetDePret objet)
        {
            _fondDeCommerce.Add(objet);
        }

        public int GetNombreObjet()
        {
            return _fondDeCommerce.Count;
        }

        public List<string> PresenterJeux()
        {
            List<string> result = new List<string>();

            if (_fondDeCommerce.Count == 0)
            {
                result.Add("Il n'y a rien ici.");
                return result;
            }

            foreach (var objet in _fondDeCommerce)
            {
                if (objet is CD)
                {
                    CD cd = (CD)objet;
                    string description = $"Nom du jeu : {cd.Nom}, Éditeur : {cd.Editeur}, Tranches d'âge : {cd.TranchesAge}";
                    int note = _notationService.GetNoteJeuxSociete(cd.Nom);
                    description += $", Note : {note}";
                    result.Add(description);
                }
            }

        return result;
        }

    }
}
