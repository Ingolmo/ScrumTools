using ScrumTools.Models;
using System.Collections.Generic;

namespace ScrumTools.Services
{
    public static class DocsService
    {
        public static IList<Doc> get()
        {
            return new List<Doc>()
            {
                new Doc() { Title = "Agile Principles", Detail="Agile principles", Icon="info.png", },
                new Doc() { Title = "test", Detail="test", Icon="info.png", },
            };
        }

    }
}
