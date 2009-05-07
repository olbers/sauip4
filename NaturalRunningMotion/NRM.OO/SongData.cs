using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml;

namespace NRM.OO
{
    [DataContract(Name = "SongData", Namespace = "http://www.contoso.com")]
    public class SongData 
    {
        [DataMember()]
        public string FullName { get; set; }
        public string Name { get { return FullName.Substring(FullName.LastIndexOf("\\") + 1); } }
        [DataMember()]
        public int BPM { get; set; }
        [DataMember()]
        public string Length { get; set; }
    }
}
