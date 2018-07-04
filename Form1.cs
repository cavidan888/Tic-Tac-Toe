using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        bool yazdir = true;
        int klikSayi = 0;

        private void ButonClick(object sender, EventArgs e)
        {
            Button buton = (Button)sender;

            if (yazdir)
            {
                buton.Text = "X";
            }
            else
            {
                buton.Text = "O";
            }

            yazdir = !yazdir;

            //biz bura basanda yazdir false olur sonra yene basa qayidir true olur. burda hec bir deyer teyin etmir sadece cek eliyir

            buton.Enabled = false;
            klikSayi++;
            Winner();
        }

        public void Winner()
        {
            bool have_Winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                have_Winner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                have_Winner = true;
            }
           else  if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                have_Winner = true;
            }


            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                have_Winner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                have_Winner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                have_Winner = true;
            }



            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                have_Winner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                have_Winner = true;
            }





            if (have_Winner == true)
            {
                DisableButtons();

                string winner = "";

                if (yazdir)

                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + "win","yeah");

            }

            else
            {
                if (klikSayi == 9)
                {
                    MessageBox.Show("Draw", "Bummer");
                }

            }

                
            }
           
        

        private void DisableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch (Exception)
            {

             
            }
        }
    }
}
