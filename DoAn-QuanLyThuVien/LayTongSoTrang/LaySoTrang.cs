using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariablePaging;
namespace LayTongSoTrang
{
    public class LaySoTrang
    {
        public static void pageTotal()
        {
            VariablePaging.KhaiBaoBienRC.pageNumber = VariablePaging.KhaiBaoBienRC.rows % VariablePaging.KhaiBaoBienRC.pageSize != 0 ? VariablePaging.KhaiBaoBienRC.rows / VariablePaging.KhaiBaoBienRC.pageSize + 1 : VariablePaging.KhaiBaoBienRC.rows / VariablePaging.KhaiBaoBienRC.pageSize;
        }
    }
}
