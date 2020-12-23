using myTyping.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myTyping
{
    public partial class Form1 : Form
    {

        TypingGame tg = new TypingGame();

        public Form1()
        {
            InitializeComponent();


            tg.setQuestions(0);

            ask();
        }

        private void ask()
        {
            if (tg.gameContinue())
            {
                var text = tg.Ask();
                laQues.Text = text;

                laRemain.Text = tg.getRemain().ToString();
            }
            else
            {
                finisher();
            }
            
        }

        private void finisher()
        {
            laQues.Text = "finish!!";
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            var result = tg.response(tbInput.Text);
            if (result)
            {
                laResult.Text = "TRUE!";
                tbInput.Text = "";
                ask();
            }
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var result =tg.Entering(tbInput.Text);
                if (result)
                {
                    laResult.Text = "TRUE!";
                }
                else
                {
                    laResult.Text = "FALSE!";
                }
                tbInput.Text = "";
                ask();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
