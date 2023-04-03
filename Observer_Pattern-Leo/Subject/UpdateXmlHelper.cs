using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Observer_Pattern_Leo.Subject
{
    public class UpdateXmlHelper
    {
        //Permite mostrar los datos en el XML en tiempo real
        public class LabPCXmlHelper
        {
            private static string _filePath = HttpContext.Current.Server.MapPath("~/LabPC.xml");

            public static List<string> GetPcIds()
            {
                var pcIds = new List<string>();

                try
                {
                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(_filePath);

                    var nodeList = xmlDoc.SelectNodes("//LAB/PCid");

                    foreach (XmlNode node in nodeList)
                    {
                        pcIds.Add(node.InnerText);
                    }
                }
                catch (Exception ex)
                {
                    // Handle error
                }

                return pcIds;
            }

            public static bool AddPcId(string pcId)
            {
                try
                {
                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(_filePath);

                    var labNode = xmlDoc.SelectSingleNode("//LAB");

                    var pcIdNode = xmlDoc.CreateElement("PCid");
                    pcIdNode.InnerText = pcId;

                    labNode.AppendChild(pcIdNode);

                    xmlDoc.Save(_filePath);

                    return true;
                }
                catch (Exception ex)
                {
                    // Handle error
                }

                return false;
            }
        }
    }
}