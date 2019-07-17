using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBook.Constant
{
    public class SourceFile
    {
        public static List<SourceFile> listF = new List<SourceFile>();
        private static int _Cid = -1;
        public SourceFile(int id,string xmlname,string xmlpath,int hearts,string imgp)
        {
            Id = id;
            xmlName = xmlname;
            xmlPath = xmlpath;
            heartCount = hearts;
            ImgPath = imgp;

        }
        int _id;
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }
        string _xmlname;
        public string xmlName
        {
            get { return _xmlname; }
            private set { _xmlname = value; }
        }
        string _xmlpath;
        public string xmlPath
        {
            get { return _xmlpath; }
            private set { _xmlpath = value; }
        }
        int _heartC;
        public int heartCount
        {
            get { return _heartC; }
            private set { _heartC = value; }
        }
        string _img;
        public string ImgPath
        {
            get { return _img; }
            private set { _img = value; }
        }
        public static List<SourceFile> GetSampleSource(SourceFile newFile)
        {            
            listF.Add(newFile);
            return listF;
        }
        public static int CurrentID
        {
            get { return _Cid; }
            set { _Cid = value; }
        }
        
        //private string _xmlName;
        //private string _xmlPath;

        //public string xmlName
        //{
        //    get { return _xmlName; }
        //    set { _xmlName = value; }
        //}
        //public string xmlPath
        //{
        //    get { return _xmlPath; }
        //    set { _xmlPath = value; }
        //}
    }
    
}
