namespace Tiny4X.GameUtils.Card
{

    public interface ICardDatabase
    {

        public string GetDescription(string cardId);

        public ICard GetCard(string cardId);

    }

}