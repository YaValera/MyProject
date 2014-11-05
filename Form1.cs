using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DS_LB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TxtBxRes.ReadOnly = true;
        }
        Boolean P1(float x, float y)
        {
            bool p11 = (x * x + y * y <= 4);
            bool p12 = (y >= x + 2);
            bool P1 = p11 && p12;
            return P1;
        }
        Boolean P2(float x, float y)
        {
            bool p21 = (x * x + y * y <= 4);
            bool p22 = (y >= -x + 2);
            bool P2 = p21 && p22;
            return P2;
        }
        Boolean P3(float x, float y)
        {
            bool p31 = (x * x + y * y <= 4);
            bool p32 = (y <= x - 2);
            bool P3 = p31 && p32;
            return P3;
        }
        Boolean P4(float x, float y)
        {
            bool p41 = (x * x + y * y <= 4);
            bool p42 = (y <= -x - 2);
            bool P4 = p41 && p42;
            return P4;
        }
        Boolean P5(float x, float y)
        {
            bool p51 = (y <= -x - 2);
            bool p52 = (y >= x + 2);
            bool P5 = p51 && p52;
            return P5;
        }
        Boolean P6(float x, float y)
        {
            bool p61 = (y <= x - 2);
            bool p62 = (y >= -x + 2);
            bool P6 = p61 && p62;
            return P6;
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            TxtBxRes.Clear();
            float x = float.Parse(TxtBxX.Text);
            float y = float.Parse(TxtBxY.Text);
            bool P;
            P = (P1(x, y) || P2(x, y) || P3(x, y) || P4(x, y))||(P5(x, y) || P6(x, y));
            if (P)
                TxtBxRes.Text = "Попали";
            else
                TxtBxRes.Text = "Не Попали";
        }
    }
}
