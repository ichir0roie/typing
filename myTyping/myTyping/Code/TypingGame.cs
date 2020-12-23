using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTyping.Code
{
    public class TypingGame
    {
        public List<questionData> questions;//todo : finally this is private.
        public List<questionData> answers;//todo : finally this is private.
        private System.Diagnostics.Stopwatch watch;

        bool gameFinish = true;

        public int quesPlace = 0;
        public TypingGame()
        {
             watch = new System.Diagnostics.Stopwatch();
            questions = new List<questionData>();
            answers = new List<questionData>();
        }

        public bool gameContinue()
        {
            return !gameFinish;
        }

        public int getRemain()
        {
            return questions.Count;
        }

        public void setQuestions(int num)
        {
            var data=  getQuesData.getTexts();
            foreach(var text in data[num])
            {
                questions.Add(new questionData(text));
            }

            gameFinish = false;

        }

        public string Ask()
        {
            //todo : select question from questionData

            if (questions.Count <= 0)
            {
                gameFinish = true;
                return "finish";
            }

            quesPlace = new Random().Next(0,questions.Count);

            watch.Start();

            //todo null exception;
            return questions[quesPlace].text;
        }


        public bool response(string input)
        {
            if (gameFinish||quesPlace<0)
            {
                return false;
            }

            if (input == questions[quesPlace].text)
            {
                var data = questions[quesPlace];
                questions.RemoveAt(quesPlace);
                quesPlace = -1;
                data.clear = true;
                data.time = watch.Elapsed.TotalSeconds;

                answers.Add(data);
                return true;
            }

            bool correct = false;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] != questions[quesPlace].text[i])
                {
                    correct = false;
                    questions[quesPlace].missTypes++;
                    break;
                }
            }


            return correct;
        }

        public bool Entering(string input)
        {
            if (gameFinish)
            {
                return false;
            }
            watch.Stop();

            if (input == questions[quesPlace].text)
            {
                var data = questions[quesPlace];
                questions.RemoveAt(quesPlace);
                quesPlace = -1;
                data.clear = true;
                data.time = watch.Elapsed.TotalSeconds;

                answers.Add(data);
                return true;
            }

          return false;
        }

        public questionData getAnswer()
        {
            var data = answers[answers.Count - 1];

            return data;
        }

        public class questionData
        {
            public string text = "";
            public bool clear = false;
            public double time = 0;
            public int missTypes = 0;

            public questionData(string _text)
            {
                text =_text;
            }
        }


    }
}
