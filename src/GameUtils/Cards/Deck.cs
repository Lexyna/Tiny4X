namespace Tiny4X.GameUtils.Card
{

    public class Deck
    {

        public static int maxDeckSize { get; private set; } = 20;

        private List<ICard> deck { get; set; }

        public string name { get; private set; }

        public Deck(string name)
        {
            deck = new List<ICard>();
            this.name = name;
        }

        public void AddCard(ICard card)
        {
            if (deck.Count >= maxDeckSize) return;
            deck.Add(card);
        }

    }

}