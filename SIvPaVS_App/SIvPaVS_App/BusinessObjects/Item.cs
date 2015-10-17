using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIvPaVS_App.Schema;


namespace SIvPaVS_App.Schema
{

    public partial class itemType
    {
        public decimal TotalItemPrice
        { get
            {
                return price * quantity;
            }
        }
    }
}
