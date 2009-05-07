using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;
using NRM.OO;

namespace NRM.ExportToFile
{
    public static class PlaylistToXML
    {
        /// <summary>
        /// Method responsible for the serialization (Using the new DataContract Serializer .NET 3.5 )
        /// and flushing xml document to the output path
        /// </summary>
        /// <param name="playlist">Playlist that will be serialized in XML</param>
        /// <param name="path">Destination folder of the playlist</param>
        public static void ExportPlaylist(NRM.OO.SongDataColl playlist, string path)
        {
            string filename = path + "playlist.xml";
            FileStream fs = new FileStream(filename, FileMode.Create);
            // Create a generic List of types and add the known types
            // to the collection.
            List<Type> knownTypeList = new List<Type>();
            knownTypeList.Add(typeof(SongDataColl));
            knownTypeList.Add(typeof(SongData));            
            
            DataContractSerializer ser =
                new DataContractSerializer(typeof(SongDataColl), knownTypeList);

            ser.WriteObject(fs, playlist);
            fs.Close();
        }
        public static SongDataColl ImportPlaylist(string path)
        {
            SongDataColl cll = null;
            // Deserialize an instance of the class 
            // from an XML file. First create an instance of the 
            // XmlDictionaryReader.
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                XmlDictionaryReader reader =
                    XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

                // Create the DataContractSerializer instance.
                DataContractSerializer ser =
                    new DataContractSerializer(typeof(SongDataColl));

                // Deserialize the data and read it from the instance.
                cll = (SongDataColl)ser.ReadObject(reader);
                fs.Close();
            }
            catch (Exception ex)
            {
                cll = new SongDataColl();
            }
            return cll;
        }

    }
}
