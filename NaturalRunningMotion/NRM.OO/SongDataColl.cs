using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace NRM.OO
{
    [CollectionDataContract(Name="Playlist")]
    public class SongDataColl:Collection<SongData>
    {

    }
}
