using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace NRM.ExportToFile
{
    public static class ExportPlaylistToXML
    {
        /// <summary>
        /// Method responsible for building the xml document and flushing it to the output path
        /// </summary>
        /// <param name="playlist">Playlist that will be serialized in XML</param>
        /// <param name="path">Destination folder of the playlist</param>
        public static void ExportPlaylist(NRM.OO.SongDataColl playlist, string path)
        {
            XmlTextWriter xmlBuilder = new XmlTextWriter(path + "playlist.xml", null);
            xmlBuilder.WriteStartDocument();
            xmlBuilder.WriteStartElement("Playlist");


            foreach (var song in playlist)
            {
                xmlBuilder.WriteStartElement("Song");
                xmlBuilder.WriteAttributeString("Name", song.FullName);
                xmlBuilder.WriteAttributeString("BPM", song.BPM.ToString());
                xmlBuilder.WriteEndElement();
            }
            xmlBuilder.WriteEndElement();
            xmlBuilder.WriteEndDocument();
            xmlBuilder.Flush();
            xmlBuilder.Close();
        }
    }
}
