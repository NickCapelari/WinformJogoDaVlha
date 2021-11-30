using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformJogoVElha
{
    
    public partial class Form1 : Form
    {
        bool vezX = false;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnX_Click(object sender, EventArgs e)
        {
            vezX = true;
            lblVez.Text = "X";
            botoesEnabel();
            btnX.Enabled = false;
            btnO.Enabled = false;
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            vezX = false;
            lblVez.Text = "O";
            botoesEnabel();
            btnX.Enabled = false;
            btnO.Enabled = false;
        }

        private void btnRecomecar_Click(object sender, EventArgs e)
        {
            i = 0;
            btnc1l1.Enabled = false;
            btnc2l1.Enabled = false;
            btnc3l1.Enabled = false;
            btnc1l2.Enabled = false;
            btnc2l2.Enabled = false;
            btnc3l2.Enabled = false;
            btnc1l3.Enabled = false;
            btnc2l3.Enabled = false;
            btnc3l3.Enabled = false;

            btnX.Enabled = true;
            btnO.Enabled = true;

            btnc1l1.Text= "";
            btnc2l1.Text= "";
            btnc3l1.Text= "";
            btnc1l2.Text= "";
            btnc2l2.Text= "";
            btnc3l2.Text= "";
            btnc1l3.Text= "";
            btnc2l3.Text= "";
            btnc3l3.Text= "";

            lblVez.Text = " - ";
            lblVencedor.Text = " - ";

        }

        private void botoesEnabel()
        {
            btnc1l1.Enabled = true;
            btnc2l1.Enabled = true;
            btnc3l1.Enabled = true;
            btnc1l2.Enabled = true;
            btnc2l2.Enabled = true;
            btnc3l2.Enabled = true;
            btnc1l3.Enabled = true;
            btnc2l3.Enabled = true;
            btnc3l3.Enabled = true;
        }
        private void botoesEnabelF()
        {
            btnc1l1.Enabled =false;
            btnc2l1.Enabled =false;
            btnc3l1.Enabled =false;
            btnc1l2.Enabled =false;
            btnc2l2.Enabled =false;
            btnc3l2.Enabled =false;
            btnc1l3.Enabled =false;
            btnc2l3.Enabled =false;
            btnc3l3.Enabled =false;
            lblVez.Text = " - ";
        }

        private void btn_Click(object sender, EventArgs e)
        {
           i++;
           Button btn = (Button)sender;
           if(vezX)
            {
                btn.Text = "X";
                lblVez.Text = "O";

            }
            else
            {
                btn.Text = "O";
                lblVez.Text = "X";
            }
            btn.Enabled = false;
            verificaVencedor();
            vezX = !vezX;                
        }
        private void verificaVencedor()
        {
            if ((btnc1l1.Text == btnc2l1.Text && btnc1l1.Text == btnc3l1.Text && btnc1l1.Text != "")||
                (btnc1l2.Text == btnc2l2.Text && btnc1l2.Text == btnc3l2.Text && btnc1l2.Text != "")||
                (btnc1l3.Text == btnc2l3.Text && btnc1l3.Text == btnc3l3.Text && btnc1l3.Text != "")||
                (btnc1l1.Text == btnc1l2.Text && btnc1l1.Text == btnc1l3.Text && btnc1l1.Text != "")||
                (btnc2l1.Text == btnc2l2.Text && btnc2l1.Text == btnc2l3.Text && btnc2l1.Text != "")||
                (btnc3l1.Text == btnc3l2.Text && btnc3l1.Text == btnc3l3.Text && btnc3l1.Text != "")||
                (btnc1l1.Text == btnc2l2.Text && btnc2l2.Text == btnc3l3.Text && btnc2l2.Text != "")||
                (btnc3l1.Text == btnc2l2.Text && btnc1l3.Text == btnc2l2.Text && btnc3l1.Text != ""))
            {
                botoesEnabelF();
                switch (vezX)
                {
                    case true:
                        lblVencedor.Text = "X";
                        break;
                    case false:
                        lblVencedor.Text = "O";
                        
                        break;
                }
            }
            else if (i == 9)
            {
                lblVencedor.Text = "Empate";
                botoesEnabelF();
            }
          
        }
    }

   
}
