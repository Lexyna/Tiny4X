using Tiny4X.GameUtils.Resources;
namespace Tiny4X.GameUtils.Map
{

    public class GrassLand : Field
    {
        public int cordX { get; }

        public int cordY { get; }

        public GrassLand(int cordX, int cordY) :
            base(cordX, cordY, 2, 0, 0, 0)
        {

        }

        public override Resource FieldBonus()
        {
            return new Resource(Resource.Type.Food, 1);
        }

        public override string GetDisplayString()
        {
            return "G";
        }

        public override string GetFieldInfo()
        {
            string info = "";

            info = $"Yields: {food.amount}food per turn";
            info += "\nEffects: none";

            return info;
        }

    }

}