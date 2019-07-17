using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBook.Constant
{
    class Session
    {
        private int _id;
        private string _title;
        private string[] _session;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string[] Session
        {
            get { return _session; }
            set { _session = value; }
        }
        
    }
}
