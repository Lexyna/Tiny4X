namespace Tiny4X.GameUtils.Card
{

    public class CFarm : ICard
    {
        public string id { get => "Farm"; }

        public string GetDescription()
        {
            return "Provides +10f/t";
        }

        public void OnPlay()
        {
            throw new NotImplementedException();
        }
    }

}