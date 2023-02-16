using Tiny4X.GameUtils.Effects;
namespace Tiny4X.GameUtils.Buildings
{

    public abstract class Building
    {

        private List<IEffect> effects;

        public Building()
        {
            effects = new List<IEffect>();
        }


    }

}