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
    public static class ExportPlaylistToXML
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
    }
}
