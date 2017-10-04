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
    public class CardsListPageModel : FreshBasePageModel
    {
        public CardsListPageModel()
        {
            InitializeCommands();
            CardList = CardsService.get();
        }

        /* Properties */
        public IList<Card> CardList { get; private set; }

        public Card SelectedCard
        {
            get { return null; }
            set
            {
                if (value != null)
                {
                    CoreMethods.PushPageModel<CardPageModel>(value);
                    RaisePropertyChanged("SelectedCard");
                }                 
            }
        }

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