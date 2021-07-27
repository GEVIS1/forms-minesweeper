using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_minesweeper
{
    public partial class Form1 : Form
    {

        MineField mf;
        public Form1()
        {
            InitializeComponent();
            mf = new MineField(5,5);
        }
    }
}
