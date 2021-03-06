﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SIvPaVS_App.BusinessObjects
{
    public partial class receiptType
    {
        public receiptType() {
            provider = new businessobjectType();
            provider.address = new addressType();
        }

       public decimal TAXBase
        {
            get
            {
                return (Convert.ToDecimal(1-taxpercentage* 0.01)) * TotalPrice; 
            }
        }

        public decimal TAXTotal
        {
            get
            {
                return TotalPrice - TAXBase;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                decimal price = 0;
                if (items!=null)
                    foreach (var item in items)
                        price += item.quantity * item.price;

                return price;
            }
        }

    }
}
