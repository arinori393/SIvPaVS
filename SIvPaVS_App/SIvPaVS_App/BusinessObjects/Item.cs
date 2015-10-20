using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SIvPaVS_App.BusinessObjects
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
