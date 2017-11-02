using FreshMvvm;
using ScrumTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTools.PageModels
{
    public class DocPageModel : FreshBasePageModel
    {
        /* Properties */
        private Doc _doc;
        public Doc Doc
        {
            get { return _doc; }
        }

        /* Commands */


        /* Overriden Methods */
        public override void Init(object initData)
        {
            base.Init(initData);
            _doc = initData as Doc;
        }

        /* Private Methods */
    }
}
