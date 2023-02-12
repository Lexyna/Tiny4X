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

        public bool AddCard(ICard card)
        {
            if (deck.Count >= maxDeckSize) return false;
            deck.Add(card);
            return true;
        }

        public bool RemoveCard(string cardId)
        {
            ICard? card = deck.Find(d => d.id == cardId);
            if (card == null) return false;
            return deck.Remove(card);
        }

        public List<ICard> GetAllCards()
        {
            return deck;
        }

        public List<string> GetAllCardsById()
        {
            List<string> ids = new List<string>();
            foreach (ICard card in deck)
                ids.Add(card.id);
            return ids;
        }

    }

}