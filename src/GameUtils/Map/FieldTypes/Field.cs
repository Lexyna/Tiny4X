using Tiny4X.GameUtils.Resources;
namespace Tiny4X.GameUtils.Map
{

    public abstract class Field
    {
        int cordX { get; }
        int cordY { get; }

        Resource food;
        Resource production;
        Resource gold;
        Resource science;

        public Field(int coordX, int coordY, int food, int production, int gold, int science)
        {
            this.cordX = coordX;
            this.cordY = cordY;
            this.food = new Resource(Resource.Type.Food, food);
            this.production = new Resource(Resource.Type.Production, production);
            this.gold = new Resource(Resource.Type.Gold, gold);
            this.science = new Resource(Resource.Type.Science, science);
        }

        public virtual void Yield()
        {

        }

        public void CalculateIInitialYields(Map world)
        {

        }

        public abstract Resource FieldBonus();

    }

}