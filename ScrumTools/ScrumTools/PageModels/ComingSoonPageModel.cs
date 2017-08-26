using FreshMvvm;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScrumTools.PageModels
{
    public class ComingSoonPageModel : FreshBasePageModel
    {
        public ComingSoonPageModel()
        {
            InitializeCommands();
        }
        /* Commands */
        private ICommand _closeCommand;
        public ICommand CloseCommand
        {
            get { return _closeCommand; }
        }
        /* Private Methods */
        private void InitializeCommands()
        {
            _closeCommand = new Command(async () => await CloseExecute());
        }

        private async Task CloseExecute()
        {
            await CoreMethods.PopPageModel(true, true);
        }
    }
}
