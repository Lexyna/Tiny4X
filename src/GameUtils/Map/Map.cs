using System.Data;
namespace Tiny4X.GameUtils.Map
{

    public class Map
    {
        private Field[,] map;

        public Map()
        {
            map = TerrainGenerator.GenerateMap(3, 5);

        }

        public DataTable ConvertMapToTable()
        {
            DataTable dt = new DataTable("Map");

            DataColumn coordinateCorner = new DataColumn();
            coordinateCorner.ColumnName = "y\\x";
            dt.Columns.Add(coordinateCorner);

            for (int x = 0; x < map.GetLength(1); x++)
            {
                DataColumn column = new DataColumn();
                column.ColumnName = $"{x + 1}";
                dt.Columns.Add(column);
            }

            for (int y = 0; y < map.GetLength(0); y++)
            {
                DataRow row = dt.NewRow();
                row[0] = $"{y + 1}";

                for (int x = 0; x < map.GetLength(1); x++)
                    row[x + 1] = map[y, x].GetDisplayString();

                dt.Rows.Add(row);
            }

            return dt;
        }

        public string GetFieldInfo(int x, int y)
        {
            if (x >= map.GetLength(1) || y >= map.GetLength(0)) return "";
            return map[y, x].GetFieldInfo();
        }

    }

}