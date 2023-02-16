using Tiny4X.GameUtils.Resources;
namespace Tiny4X.GameUtils.Map
{

    public abstract class Field
    {
        int cordX { get; }
        int cordY { get; }

        protected Resource food;
        protected Resource production;
        protected Resource gold;
        protected Resource science;

        ///<summary>
        ///Base class for Fields.
        /// Defines the coordinate and base production values on this tile.  
        ///</summary>
        public Field(int coordX, int coordY, int food, int production, int gold, int science)
        {
            this.cordX = coordX;
            this.cordY = cordY;
            this.food = new Resource(Resource.Type.Food, food);
            this.production = new Resource(Resource.Type.Production, production);
            this.gold = new Resource(Resource.Type.Gold, gold);
            this.science = new Resource(Resource.Type.Science, science);
        }

        ///<summary>
        ///Returns the base Resource yield of this Filed and applies it to [WIP]
        ///</summary>
        public virtual void Yield()
        {

        }

        public void CalculateIInitialYields(Map world)
        {

        }

        ///<summary>
        ///Returns the Resource bonus this Field offer to adjacent Field.
        ///Can be negative.
        ///Can only offer one Resource.</summary>
        ///<returns>Resource</returns> 
        public abstract Resource FieldBonus();


        ///<summary>
        ///Returns the Letter Description from this filed to be displayed on the World Map
        ///</summary>
        public abstract string GetDisplayString();

        ///<summary>
        ///Returns a detailed summary of the yields, buildings and other effects active
        /// on this tile.
        ///</summary>
        public abstract string GetFieldInfo();

    }

}