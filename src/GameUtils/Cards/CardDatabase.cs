namespace Tiny4X.GameUtils.Card
{

    /*
        Contains information about all cards in the game.
        Used as a Database to get card Information.
    */
    public class CardDatabase : ICardDatabase
    {

        Dictionary<string, ICard> cards;

        public CardDatabase()
        {
            CFarm farm = new CFarm();
            CInstitute institute = new CInstitute();
            CMarketplace marketplace = new CMarketplace();
            CWorkshop workshop = new CWorkshop();

            cards = new Dictionary<string, ICard>();

            cards.Add(farm.id, farm);
            cards.Add(institute.id, institute);
            cards.Add(marketplace.id, marketplace);
            cards.Add(workshop.id, workshop);
        }

        public ICard GetCard(string cardId)
        {
            throw new NotImplementedException();
        }

        public string GetDescription(string cardId)
        {
            if (cards.ContainsKey(cardId))
                return cards[cardId].GetDescription();
            return "Card not found";
        }
    }
}
