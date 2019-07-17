using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordBook.BE
{
    public class BESourceDefinition
    {
        private int _xmlid;
        private int _xmlheart;
        private string _xmlName;
        private string _xmlPath;
        private string _xmlimg;

        public int xmlID
        {
            get { return _xmlid; }
            set { _xmlid = value; }
        }
        public int xmlHeart
        {
            get { return _xmlheart; }
            set { _xmlheart = value; }
        }
        public string xmlName
        {
            get { return _xmlName; }
            set { _xmlName = value; }
        }
        public string xmlPath
        {
            get { return _xmlPath; }
            set { _xmlPath = value; }
        }
        public string xmlImg
        {
            get { return _xmlimg; }
            set { _xmlimg = value; }
        }
    }
}
