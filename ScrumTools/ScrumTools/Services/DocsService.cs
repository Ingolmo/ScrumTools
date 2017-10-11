using ScrumTools.Models;
using ScrumTools.Resources.Strings;
using System.Collections.Generic;

namespace ScrumTools.Services
{
    public static class DocsService
    {
        public static IList<Doc> get()
        {
            return new List<Doc>()
            {
                new Doc() { Title = AppResources.Scrum, Detail=AppResources.ScrumDescription, Icon="info.png", },
                new Doc() { Title = AppResources.AgilePrinciples, Detail=AppResources.AgilePrinciplesDescription, Icon="info.png", },
                new Doc() { Title = "test", Detail="test", Icon="info.png", }
            };
        }

    }
}
