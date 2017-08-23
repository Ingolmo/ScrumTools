using System;
using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using ScrumTools.Models;
using System.Collections.Generic;
using ScrumTools.Services;

namespace ScrumTools.PageModels
{
    public class CardsGridPageModel : FreshBasePageModel
    {        
        public CardsGridPageModel()
        {
            InitializeCommands();
            CardList = CardsService.get();
        }

        /* Properties */
        public IList<Card> CardList { get; private set; }

        /* Commands */
        private ICommand _goToCardCommand;
        public ICommand GoToCardCommand
        {
            get { return _goToCardCommand; }
        }

        /* Private Methods */
        private void InitializeCommands()
        {
            _goToCardCommand = new Command<Card>(async (card) => await GoToCardExecute(card)); ;
        }

        private async Task GoToCardExecute(Card card)
        {
            await CoreMethods.PushPageModel<CardPageModel>(card, false, true);
        }
    }
}
