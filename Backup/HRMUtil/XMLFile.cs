using System;
using System.Xml;
using System.Xml.XPath;

namespace HRMUtil
{
    public class XMLFile
    {

        private string _Path;
        private XPathNavigator _Nav;

        public XMLFile(string path)
        {
            _Path = path;
            XPathDocument doc = new XPathDocument(Path);
            _Nav = doc.CreateNavigator();            
        }

        public string Path
        {
            get { return _Path; }
            set { _Path = value; }
        }
       

        public string GetInsertingFormatMessageError(string errorCode, string formatString)
        {
            return string.Format(GetFormatMessageErrors(errorCode, "/HRM/Insert/Message"), formatString);
        }

        public string GetUpdatingFormatMessageError(string errorCode, string formatString)
        {
            return string.Format(GetFormatMessageErrors(errorCode, "/HRM/Update/Message"), formatString);
        }

        public string GetDeletingFormatMessageError(string errorCode, string formatString)
        {
            return string.Format(GetFormatMessageErrors(errorCode, "/HRM/Delete/Message"), formatString);
        }

        private string GetFormatMessageErrors(string errorCode, string xPath)
        {
            XPathExpression expr;
            expr = _Nav.Compile(xPath);
            XPathNodeIterator iterator = _Nav.Select(expr);
            iterator = _Nav.Select(expr);
            string messageReturn = string.Empty;
            try
            {
                while (iterator.MoveNext())
                {
                    string s = string.Empty;
                    XPathNavigator nav = iterator.Current.Clone();
                    s = nav.OuterXml;
                    string[] arr = s.Split('"');
                    if (arr.Length > 1)
                    {
                        if (errorCode.Equals(arr[1]))
                        {
                            messageReturn = nav.Value;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return messageReturn;
        }

            
    }
}
