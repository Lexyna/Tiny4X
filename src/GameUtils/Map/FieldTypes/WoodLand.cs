using Tiny4X.GameUtils.Resources;

namespace Tiny4X.GameUtils.Map
{

    public class WoodLand : Field
    {
        public WoodLand(int coordX, int coordY) :
                   base(coordX, coordY, 0, 2, 0, 0)
        {

        }

        public override Resource FieldBonus()
        {
            return new Resource(Resource.Type.Production, 1);
        }

        public override string GetDisplayString()
        {
            return "W";
        }

        public override string GetFieldInfo()
        {
            string info = "";

            info = $"Yields: {production.amount}production per turn";
            info += "\nEffects: none";

            return info;
        }
    }

}