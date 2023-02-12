namespace Tiny4X.GameUtils.Card
{

    public interface ICard
    {
        string id { get; }

        public void OnPlay();

        public string GetDescription();
    }

}