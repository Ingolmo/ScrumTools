using ScrumTools.Models;
using System.Collections.Generic;

namespace ScrumTools.Services
{
    public static class CardsService
    {
        public static IList<Card> get()
        {
            return new List<Card>()
            {
                new Card() { Title = "1 point", Detail="Low hanging fruit", Image="est1.png", Thumbnail="est1_t.png" },
                new Card() { Title = "2 points", Detail="Piece of cake", Image="est2.png", Thumbnail="est2_t.png" },
                new Card() { Title = "3 points", Detail="It ain't rocket science", Image="est3.png", Thumbnail="est3_t.png" },
                new Card() { Title = "5 points", Detail="Blame the Platypus", Image="est5.png", Thumbnail="est5_t.png" },
                new Card() { Title = "8 points", Detail="An arm and a leg", Image="est8.png", Thumbnail="est8_t.png" },
                new Card() { Title = "13 points", Detail="Just squeaking by", Image="est13.png", Thumbnail="est13_t.png" },
                new Card() { Title = "20 points", Detail="Don’t put all your eggs in one basket", Image="est20.png", Thumbnail="est20_t.png" },
                new Card() { Title = "40 points", Detail="To step into an aubergine field", Image="est40.png", Thumbnail="est40_t.png" },
                new Card() { Title = "100 points", Detail="Monster task", Image="est100.png", Thumbnail="est100_t.png" },
                new Card() { Title = "Infinites points", Detail="When pigs fly", Image="inf.png", Thumbnail="inf_t.png" },
                new Card() { Title = "Unknow points", Detail="Here be dragons", Image="unk.png", Thumbnail="unk_t.png" },
                new Card() { Title = "Yak Shaving", Detail="This is a very-non-relevant-important task", Image="yak.png", Thumbnail="yak_t.png" },
                new Card() { Title = "Ping-Pong", Detail="Who can say no to this?", Image="pp.png", Thumbnail="pp_t.png" },
                new Card() { Title = "Brownie", Detail="Here be dragons", Image="brownie.png", Thumbnail="brownie_t.png" }
            };
        }
      
    }
}
