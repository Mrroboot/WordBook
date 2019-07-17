using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordBook.BE
{
    public class BEWordDefinition
    {
        private int _id;
        private string _content;
        private string _explain;
        private int _heartC;
        private string _sentence;

        public int wordId
        {
            get { return _id; }
            set { _id = value; }
        }
        public int heartCount
        {
            get { return _heartC; }
            set { _heartC = value; }
        }
        public string wordContent
        {
            get { return _content; }
            set { _content = value; }
        }
        public string wordExplain
        {
            get { return _explain; }
            set { _explain = value; }
        }
        public string wordSentence
        {
            get { return _sentence; }
            set { _sentence = value; }
        }
    }
}
