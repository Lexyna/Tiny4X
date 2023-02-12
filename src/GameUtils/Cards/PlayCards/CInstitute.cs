namespace Tiny4X.GameUtils.Card
{

    public class CInstitute : ICard
    {
        public string id => "Institute";

        public string GetDescription()
        {
            return "Provides +10r/t";
        }

        public void OnPlay()
        {
            throw new NotImplementedException();
        }
    }

}