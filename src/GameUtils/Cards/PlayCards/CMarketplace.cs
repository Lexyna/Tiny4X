namespace Tiny4X.GameUtils.Card
{

    public class CMarketplace : ICard
    {
        public string id => "Marketplace";

        public string GetDescription()
        {
            return "Provides +10g/t";
        }

        public void OnPlay()
        {
            throw new NotImplementedException();
        }
    }

}