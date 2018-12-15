using Sea.Battle.Ship.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea.Battle.Ship.Controllers
{
    public static class Game
    {
        #region Variables

        public static CellState[,] seaOwn = new CellState[10, 10];

        public static CellState[,] seaEnemy = new CellState[10, 10];

        #endregion
        #region
        public static void Init()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    seaOwn[i, j] = CellState.Empty;
                    seaEnemy[i, j] = CellState.Empty;
                }
            }
        }

        #endregion
    }
}
