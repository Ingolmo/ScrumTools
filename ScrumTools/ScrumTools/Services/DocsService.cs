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
                new Doc() { Title = AppResources.AgilePrinciples, Detail=AppResources.AgilePrinciplesDescription, Content=AppResources.AgilePrinciplesContent ,Icon="principles.png", },
                new Doc() { Title = AppResources.Scrum, Detail=AppResources.ScrumDescription, Content=AppResources.ScrumContent ,Icon="scrum.png", },
                new Doc() { Title = AppResources.ScrumArtifacts, Detail=AppResources.ScrumArtifactsDescription, Content=AppResources.ScrumArtifactsContent, Icon="artifacts.png", },
                new Doc() { Title = AppResources.CommingSoon, Detail=AppResources.CommingSoonDescription, Content=AppResources.CommingSoonContent, Icon="robot.png", }
            };
        }

    }
}
