namespace Tiny4X.GameUtils.Card
{

    public class Deck
    {

        public static int maxDeckSize { get; private set; } = 20;

        private List<ICard> deck { get; set; }

        public Deck()
        {
            deck = new List<ICard>();
        }

    }

}