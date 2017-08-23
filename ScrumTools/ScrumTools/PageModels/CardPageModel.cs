using FreshMvvm;
using ScrumTools.Models;

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
        public string Title
        {
            get { return _card.Title; }
        }
        /* Commands */

        /* Overriden Methods */
        public override void Init(object initData)
        {
            base.Init(initData);
            _card = initData as Card;
        }
    }
}
