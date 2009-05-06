using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NRM.OO;

namespace NRM.ExportToFile
{
    /// <summary>
    /// Auxiliar class that allows exporting the data from the nunchuk
    /// </summary>
    public static class ExportWiiData
    {
        public static void ExportDataToCSV(string path, WiiDataColl wii, WiiDataColl nun)
        {
            ExportDataAux(path + @"\wii.txt", wii);
            ExportDataAux(path + @"\nun.txt", nun);
        }
        /// <summary>
        /// Method that exports the data to a csv file using the FileStream Class
        /// </summary>
        /// <param name="path">Full name of the file, including the path</param>
        /// <param name="wii">Collection with the data to export to the file</param>
        private static void ExportDataAux(string path, WiiDataColl wii)
        {
            try
            {
                FileStream theFile = File.Open(path, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(theFile);

                foreach (WiiData c in wii)
                {
                    writer.WriteLine(c.X + ";" + c.Y + ";" + c.Z);
                }
                writer.Close();
                theFile.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}