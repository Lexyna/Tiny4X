namespace Tiny4X.GameUtils.Map
{

    public static class TerrainGenerator
    {

        public static Field[,] GenerateMap(int length, int height)
        {
            Field[,] map = new Field[height, length];

            Random rnd = new Random();

            for (int y = 0; y < height; y++)
                for (int x = 0; x < length; x++)
                {
                    int r = rnd.Next(0, 100);

                    Field field;

                    if (r > 50)
                        field = new GrassLand(x, y);
                    else
                        field = new Forest(x, y);

                    map[y, x] = field;
                }

            return map;
        }

    }

}