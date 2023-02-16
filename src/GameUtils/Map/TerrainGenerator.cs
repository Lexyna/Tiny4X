namespace Tiny4X.GameUtils.Map
{

    public static class TerrainGenerator
    {

        public static Field[,] GenerateMap(int length, int height)
        {
            Field[,] map = new Field[height, length];

            for (int y = 0; y < height; y++)
                for (int x = 0; x < length; x++)
                {
                    map[y, x] = new GrassLand(x, y);
                }

            return map;
        }

    }

}