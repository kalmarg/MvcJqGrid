using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace MvcJqGrid
{
    [DataContract]
    public class GridResult<TId>
    {
        [DataMember]
        public int page { get; set; }

        [DataMember]
        public int total { get; set; }

        [DataMember]
        public int records { get; set; }

        [DataMember]
        public bool repeatitems { get; set; }

        [DataMember]
        public List<GridRow<TId>> rows { get; set; }

        [DataMember]
        public GridResult<TId> subgrid { get; set; }
    }

    [DataContract]
    public class GridRow<TId>
    {
        [DataMember]
        public TId id { get; set; }

        [DataMember]
        public ArrayList cell { get; set; }
    }
}
