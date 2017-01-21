using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace TestUI
{
    public partial class Form1 : Form
    {
        public Button[] buttons;
        public UILogic uiLogic = new UILogic();

        public Form1()
        {
            InitializeComponent();
            buttons = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 };
        }

        private void button_Click(object sender, EventArgs e)
        {
            bool[] state = uiLogic.getNextState(cbxSetup.Checked , int.Parse( ((Button)sender).Text));

            for (int i = 0; i < state.Length;i++ )
            {
                buttons[i].BackColor = state[i] ? Color.Green : SystemColors.Control;
            }
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            lblBFSSolution.Text= uiLogic.solveBFS();
        }
    }
}
