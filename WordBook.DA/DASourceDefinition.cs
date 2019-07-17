using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Configuration;

namespace WordBook.DA
{
    public class DASourceDefinition
    {
        public DataSet GetSourceFileDefini(BE.BESourceDefinition sourceDefini)
        {
            DataSet dsSource = new DataSet();
            if (File.Exists(ConfigurationManager.AppSettings["ObjectCfg"].ToString()))
            {
                dsSource = xmlLoadFactory.GetXml(ConfigurationManager.AppSettings["ObjectCfg"].ToString());
            }
            return dsSource;
        }
    }
}
