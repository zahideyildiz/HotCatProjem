using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCat.Model.Enums
{
    //UI'da admin dashboard tanımlayacağız. orda hangi verinin eklendiğini, güncellendiğini, silindiğini filtrelemek için bu sabit değerler üzerinden gerçekleştiricez.
    public enum DataStatus
    {
        INSERTED, // Eklendi
        UPDATED,
        DELETED
    }
}
