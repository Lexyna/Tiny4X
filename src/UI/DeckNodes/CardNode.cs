using Terminal.Gui.Trees;
using Tiny4X.GameUtils.Card;

namespace Tiny4X.UI.DeckNodes
{
    public class CardNode : TreeNode
    {
        public string id { get; private set; }
        public DeckNode deckNode { get; private set; }

        public override string Text { get => id; set { id = value; } }

        public CardNode(string id, DeckNode deckNode)
        {
            this.id = id;
            this.deckNode = deckNode;
        }

    }
}