using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_minesweeper
{
    public class MineField
    {
        public int FieldSize;
        public int Difficulty;
        public Button[] GameField;

        public MineField(int FieldSize, int Difficulty)
        {
            this.FieldSize = FieldSize;
            this.Difficulty = Difficulty;
        }
    }
}
