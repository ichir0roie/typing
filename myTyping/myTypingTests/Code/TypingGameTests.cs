﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using myTyping.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTyping.Code.Tests
{
    [TestClass()]
    public class TypingGameTests
    {
        [TestMethod()]
        public void TypingGameTest()
        {

            string[] texts= {
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
                "もこもこに重ね着をして出かける"
            };

            var tg = new TypingGame();
            tg.setQuestions(0);

            tg.Ask();

            int count = 0;
            while (tg.questions.Count> 0)
            {
                
                var ret=tg.Entering(texts[new Random().Next(0, texts.Length)]);
                if (ret)
                {
                    var data=tg.getAnswer();

                    tg.Ask();

                }
                count++;
            }

            //Assert.Fail();
        }
    }
}