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
                new Doc() { Title = AppResources.AgilePrinciples, Detail=AppResources.AgilePrinciplesDescription, Icon="principles.png", },
                new Doc() { Title = AppResources.Scrum, Detail=AppResources.ScrumDescription, Icon="scrum.png", },
                new Doc() { Title = AppResources.ScrumArtifacts, Detail=AppResources.ScrumArtifactsDescription, Icon="artifacts.png", },
                new Doc() { Title = AppResources.CommingSoon, Detail=AppResources.CommingSoonDescription, Icon="robot.png", }
            };
        }

    }
}
