using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace WordBook.Helper
{
    /// <summary>
    /// XML Operation class
    /// </summary>
    public class xmlLoadFactory
    {
        #region load xml to DataSet
        /// <param name = "xmlPath">xml file path</param>
        /// <returns>DataSet</returns>
        public static DataSet GetXml(string xmlPath)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(xmlPath);
            return ds;
        }
        #endregion

        #region load xml node and attribute
        /// <param name="xmlPath">file path</param>
        /// <param name="node">node</param>
        /// <param name="attribute">if attribute is not null then return value</param>
        /// <returns>string</returns>
        public static string ReadNode(string xmlPath,string node,string attribute)
        {
            string rt = "";
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath);
                XmlNode xn = doc.SelectSingleNode(node);
                rt = (attribute.Equals("") ? xn.InnerText : xn.Attributes[attribute].Value);

            }
            catch { }
            return rt;
        }
        #endregion

        #region  find node data load to DataSet
        /// <param name="xmlPath">file path</param>
        /// <param name="xmlNode">node path:root/parent/current</param>
        /// <returns>DataSet</returns>
        public static DataSet GetXmlNodeData(string xmlPath,string xmlNode)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            DataSet ds = new DataSet();
            StringReader read = new StringReader(doc.SelectSingleNode(xmlNode).OuterXml);
            ds.ReadXml(read);
            return ds;
        }

        #endregion

        #region  update xml node value
        ///<param name="xmlPath">file path</param>
        ///<param name="Node">update node</param>
        ///<param name="Content">new update content</param>
        public static void XmlNodeReplace(string xmlPath, string Node, string Content)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            doc.SelectSingleNode(Node).InnerText = Content;
            doc.Save(xmlPath);
        }
        #endregion

        #region Delete node
        /// <param name="xmlPath">file path</param>
        /// <param name="Node">node </param>
        public static void XmlNodeDelete(string xmlPath, string Node)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            string mainNode = Node.Substring(0, Node.LastIndexOf("/"));
            doc.SelectSingleNode(mainNode).RemoveChild(doc.SelectSingleNode(Node));
            doc.Save(xmlPath);
        }
        #endregion

        #region Insert one node
        ///<param name="xmlPath">file path</param>
        ///<param name="MailNode">current node</param>
        ///<param name="ChildNode">new node</param>
        ///<param name="Element">child node for new node</param>
        ///<param name="Content">child node content</param>
        public static void XmlInsertNode(string xmlPath,string MailNode,string ChildNode,string Element, string Content)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            XmlNode objrootNode = doc.SelectSingleNode(MailNode);
            XmlElement objchildNode = doc.CreateElement(ChildNode);
            objrootNode.AppendChild(objchildNode);
            XmlElement objElement = doc.CreateElement(Element);
            XmlCDataSection xcds = doc.CreateCDataSection(Content);
            objElement.AppendChild(xcds);
            objchildNode.AppendChild(objElement);
            doc.Save(xmlPath);
        }
        #endregion

        #region 插入一节点,带一属性      
        /// <param name="xmlPath">Xml文档路径</param>
        /// <param name="MainNode">当前节点路径</param>
        /// <param name="Element">新节点</param>
        /// <param name="Attrib">属性名称</param>
        /// <param name="AttribContent">属性值</param>
        /// <param name="Content">新节点值</param>
        public static void XmlInsertElement(string xmlPath, string MainNode, string Element, string Attrib, string AttribContent, string Content)
        {
            XmlDocument objXmlDoc = new XmlDocument();
            objXmlDoc.Load(xmlPath);
            XmlNode objNode = objXmlDoc.SelectSingleNode(MainNode);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.SetAttribute(Attrib, AttribContent);
            objElement.InnerText = Content;
            objNode.AppendChild(objElement);
            objXmlDoc.Save(xmlPath);
        }
        #endregion
        #region 插入一节点不带属性       
        public static void XmlInsertElement(string xmlPath, string MainNode, string Element, string Content)
        {
            XmlDocument objXmlDoc = new XmlDocument();
            objXmlDoc.Load(xmlPath);
            XmlNode objNode = objXmlDoc.SelectSingleNode(MainNode);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.InnerText = Content;
            objNode.AppendChild(objElement);
            objXmlDoc.Save(xmlPath);
        }
        #endregion
    }
}
