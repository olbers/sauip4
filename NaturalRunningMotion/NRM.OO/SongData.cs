using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NRM.OO
{
    public class SongData
    {
        public string FullName { get; set; }
        public string Name { get { return FullName.Substring(FullName.LastIndexOf("\\") + 1); } }
        public int BPM { get; set; }

    }
}
