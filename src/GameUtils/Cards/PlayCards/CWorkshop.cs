namespace Tiny4X.GameUtils.Card
{

    public class CWorkshop : ICard
    {
        public string id => "Workshop";

        public string GetDescription()
        {
            return "Provides +10p/t";
        }

        public void OnPlay()
        {
            throw new NotImplementedException();
        }
    }

}