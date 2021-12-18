using System.Collections.ObjectModel;
using MVVM.Model;

namespace MVVM.ViewModel
{
    public class ContatoViewModel : ObservableCollection<Contato>
    {
        public ContatoViewModel()
        {
            PreparaContatoCollection();
        }

        private void PreparaContatoCollection()
        {
            Add(new Contato
            {
                Nome = "Jose Carlos",
                Sobrenome = "Macoratti",
                Email = "macoratti@yahoo.com",
                Telefone = "012-8789-0200"
            });

            Add(new Contato
            {
                Nome = "Bruno",
                Sobrenome = "Silveira",
                Email = "brunosilv@email.com",
                Telefone = "021-9987-3458"
            });

            Add(new Contato
            {
                Nome = "Jonatas",
                Sobrenome = "Sanches",
                Email = "jonsanch@email.com",
                Telefone = "011-8975-57898"
            });
        }
    }
}
