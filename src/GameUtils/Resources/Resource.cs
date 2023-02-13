namespace Tiny4X.GameUtils.Resources
{

    public class Resource
    {

        public enum Type { Food, Production, Science, Gold }

        Type type;

        public int amount { get; }

        public Resource(Type type, int amount)
        {
            this.type = type;
            this.amount = amount;

        }

    }

}