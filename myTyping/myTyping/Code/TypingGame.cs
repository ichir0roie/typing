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

        public int quesPlace = 0;

        public TypingGame()
        {
             watch = new System.Diagnostics.Stopwatch();
            questions = new List<questionData>();
            answers = new List<questionData>();
        }

        public void setQuestions(string[] texts)
        {
            foreach(var text in texts)
            {
                questions.Add(new questionData(text));
            }
        }

        public string Ask()
        {
            //todo : select question from questionData

            quesPlace = new Random().Next(0,questions.Count);


            watch.Start();

            return questions[quesPlace].text;
        }


        public bool response(string input)
        {
            bool correct = true;
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
