using eSports.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace eSports.Services
{
    public static class XmlService
    {
        public static Dados Load(string path)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Prohibit;

            using (XmlReader reader = XmlReader.Create(path, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Dados));
                Dados data = (Dados)serializer.Deserialize(reader);

                if (data == null)
                    throw new InvalidDataException("O ficheiro XML está vazio.");

                return data;
            }
        }

        public static void Save(Dados data, string path)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = new UTF8Encoding(false);

            // sem os xmlns:xsi / xmlns:xsd por defeito
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "");

            using (XmlWriter writer = XmlWriter.Create(path, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Dados));
                serializer.Serialize(writer, data, namespaces);
            }
        }
    }
}