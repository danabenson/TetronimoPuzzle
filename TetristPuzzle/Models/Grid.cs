namespace TetristPuzzle.Models
{
    public class Grid
    {
        public char[,] GridSpaces;

        public Grid()
        {
            Columns = 32;
            Rows = 16;
            GridSpaces = new char[Columns,Rows];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    GridSpaces[j, i] = '*';
                }
            }
        }

        public int Rows { get; set; }

        public int Columns { get; set; }

        public int NumEmpty
        {
            get
            {
                int total = 0;
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (GridSpaces[j, i] == '*')
                        {
                            total++;
                        }
                    }
                }
                return total;
            }
        }

        public bool IsAvailable(int x, int y)
        {
            return x < Columns && y < Rows && x >= 0 && y >= 0 && GridSpaces[x, y] == '*';
        }

        public void Mark(int x, int y, TetronimoType t)
        {
            GridSpaces[x, y] = t.ToString()[0];
        }
    }
}