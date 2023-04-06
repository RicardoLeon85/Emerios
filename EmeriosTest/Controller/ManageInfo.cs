using EmeriosTest.Entities;

namespace EmeriosTest.Controller
{

    enum Categories
    {
        All = 1,
        Vertical = 2,
        Horizontal = 3,
        DiagonalRight = 4,
        DiagonalLeft = 5,
    }

    internal class ManageInfo
    {
        public string Calculate(Info info)
        {
            string resultAux = "";

            for (int i = 0; i < info.NroFilas; i++)
            {
                for (int j = 0; j < info.NroCol; j++)
                {
                    //Console.WriteLine("line: " + i.ToString() + " - Col: " + j.ToString());
                    string path = CheckLongestPath(Categories.All, info, i, j);

                    if (path.Length > resultAux.Length)
                    {
                        resultAux = path;
                    }
                }
            }

            return resultAux;
        }

        private string CheckLongestPath(Categories type, Info m, int i, int j)
        {
            string cell = m.Matriz[i, j].ToString();
            string path = cell;

            if (j + 1 < m.NroCol && (type == Categories.All || type == Categories.Vertical))
                if (cell == m.Matriz[i, j + 1])
                {
                    path = cell + "," + CheckLongestPath(Categories.Vertical, m, i, j + 1);
                }

            if (i + 1 < m.NroFilas && (type == Categories.All || type == Categories.Horizontal))
                if (path == m.Matriz[i + 1, j])
                {
                    path = cell + "," + CheckLongestPath(Categories.Horizontal, m, i + 1, j);
                }

            if (i + 1 < m.NroFilas && j + 1 < m.NroCol && (type == Categories.All || type == Categories.DiagonalRight))
                if (cell == m.Matriz[i + 1, j + 1])
                {
                    path = cell + "," + CheckLongestPath(Categories.DiagonalRight, m, i + 1, j + 1);
                }

            if (i + 1 < m.NroFilas && (j - 1) >= 0 && (type == Categories.All || type == Categories.DiagonalLeft))
                if (cell == m.Matriz[i + 1, j - 1])
                {
                    path = cell + "," + CheckLongestPath(Categories.DiagonalLeft, m, i + 1, j - 1);
                }

            if (path == "")
                path = cell;

            return path;
        }
    }
}
