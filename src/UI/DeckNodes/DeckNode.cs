using Terminal.Gui.Trees;
using Tiny4X.GameUtils.Card;

namespace Tiny4X.UI.DeckNodes
{

    public class DeckNode : TreeNode
    {

        public Deck deck { get; private set; }

        public List<CardNode> cards { get; set; }

        public override IList<ITreeNode> Children => cards.Cast<ITreeNode>().ToList();

        public override string Text { get => $"{deck.name} ({deck.GetAllCards().Count}/{Deck.maxDeckSize})"; }

        public DeckNode(Deck deck)
        {
            this.deck = deck;
            cards = new List<CardNode>();

            foreach (ICard card in deck.GetAllCards())
                AddChild(card.id);
        }

        public void AddChild(string cardId)
        {
            CardNode cardNode = new CardNode(cardId, this);
            cards.Add(cardNode);
        }

        public void Refresh()
        {
            cards.Clear();
            foreach (ICard card in deck.GetAllCards())
                AddChild(card.id);
        }

    }

}