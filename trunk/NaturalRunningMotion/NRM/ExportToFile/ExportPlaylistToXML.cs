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
        /// property that contains the XMLDocument with the xml 
        /// structure and data of the playlist
        /// </summary>
        public static XmlDocument XmlPlaylist { get; set; }
        /// <summary>
        /// Method that creates the XMLDocument
        /// </summary>
        public static void CreateFile ()
	    {
            if (!File.Exists("playlist.xml"))
            {
                createXmlPlaylistDocument();
            }

            XmlPlaylist = new XmlDocument();
            XmlPlaylist.Load("playlist.xml");
            XmlElement xmlRoot = XmlPlaylist.DocumentElement;
        }

        public static void createXmlPlaylistDocument()
        {
            XmlTextWriter xmlPlaylist = new XmlTextWriter("playlist.xml", null);
            xmlPlaylist.WriteStartDocument();
            xmlPlaylist.WriteStartElement("Playlist");
            xmlPlaylist.WriteEndElement();
            xmlPlaylist.WriteEndDocument();
            xmlPlaylist.Close();
        }

        internal static void ExportPlaylist(NRM.OO.SongDataColl playlist, string path)
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
