using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace dbmanager
{
    public static class SystemLogger
    {
        public static void Log(LoggerModel item)
        {
            var filename = Path.Combine(Application.StartupPath, "SystemLogs", "SystemLog_" + DateTime.Now.ToString("MMddyyyyhhmmsstt")) + ".xml";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = true;
            Guid id = Guid.NewGuid();
            using (XmlWriter writer = XmlWriter.Create(filename,settings))
            {
                writer.WriteStartElement("SystemLog");
                writer.WriteElementString("Id", id.ToString());
                writer.WriteElementString("Method", item.Method);
                writer.WriteElementString("Database", item.Database);
                writer.WriteElementString("OperationType", item.OperationType);
                writer.WriteElementString("OperationTime", item.OperationTime);
                writer.WriteElementString("IsSuccess", item.IsSuccess);
                writer.WriteElementString("SystemRemarks", item.SystemRemarks);
                writer.WriteEndElement();
                writer.Flush();
            }
        }
    }
}
