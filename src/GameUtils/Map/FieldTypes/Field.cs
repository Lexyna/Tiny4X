namespace Tiny4X.GameUtils.Map
{

    public class Field
    {
        int cordX { get; }
        int cordY { get; }

        public Field(int coordX, int coordY)
        {
            this.cordX = coordX;
            this.cordY = cordY;
        }

        public virtual void Yield()
        {

        }

    }

}