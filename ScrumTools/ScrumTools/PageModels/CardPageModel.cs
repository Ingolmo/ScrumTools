using FreshMvvm;
using ScrumTools.Models;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using System.Threading.Tasks;

namespace ScrumTools.PageModels
{
    public class CardPageModel : FreshBasePageModel
    {
        /* Properties */
        private Card _card;
        public string Image
        {
            get { return _card.Image; }
        }

        /* Commands */
        

        /* Overriden Methods */
        public override void Init(object initData)
        {
            base.Init(initData);
            _card = initData as Card;
        }

        /* Private Methods */
    }
}
