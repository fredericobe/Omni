using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.Base
{
    public interface IProduct
    {
        string InternalCode { get; set; }
        string Indexer { get; set; }
        string Type { get; set; }
        string Name { get; set; }        
        string Market { get; set; }
        string ISIN { get; set; }

    }
}
