using FreshMvvm;
using ScrumTools.Models;
using ScrumTools.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScrumTools.PageModels
{
    public class DocsListPageModel : FreshBasePageModel
    {
        public DocsListPageModel()
        {
            InitializeCommands();
            DocList = DocsService.get();
        }

        /* Properties */
        public IList<Doc> DocList { get; private set; }

        public Doc SelectedDoc
        {
            get { return null; }
            set
            {
                if (value != null )
                {
                    CoreMethods.PushPageModel<DocPageModel>(value);
                    RaisePropertyChanged("SelectedDoc");
                }
            }
        }

        /* Commands */
        private ICommand _goToDocCommand;
        public ICommand GoToDocCommand
        {
            get { return _goToDocCommand; }
        }

        /* Private Methods */
        private void InitializeCommands()
        {
            _goToDocCommand = new Command<Doc>(async (doc) => await GoToDocExecute(doc));
        }

        private async Task GoToDocExecute (Doc doc)
        {
            await CoreMethods.PushPageModel<DocPageModel>(null, true, true);
        }
    }
}
