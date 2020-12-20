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


            string[] texts = {
                "たぬき寝入り",
                "里帰り",
                "言葉遣い",
                "平行四辺形",
                "日帰り温泉",
                "ペンダント",
                "向かい風",
                "雑木林",
                "ブッシュドノエル",
                "除夜の鐘",
                "幻想的",
                "伝統行事",
                "慌てふためく",
                "鮮やかな色",
                "きんぴらごぼう",
                "湯たんぽ",
                "奈良の大仏",
                "ベビーカー",
                "パーティーグッズ",
                "社交辞令",
                "新しいダウンジャケットが欲しいな",
                "キラキラ輝くイルミネーション",
                "今年はスノーボードに挑戦だ",
                "待ちに待ったクリスマス",
                "良いお年をお迎えください",
                "二人で肩を寄せ合って歩く",
                "ふかふかのマフラーを巻いてご満悦",
                "何をプレゼントしたらいいんだろう",
                "喉元過ぎれば熱さを忘れる",
                "もこもこに重ね着をして出かける",
                "ガッポイ"
            };


            tg.setQuestions(texts);

            ask();
        }

        private void ask()
        {
            var text=tg.Ask();
            laQues.Text = text;

            laRemain.Text = tg.getRemain().ToString();
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

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
    }
}
