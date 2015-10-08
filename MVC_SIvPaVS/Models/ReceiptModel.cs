using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SIvPaVS.Models
{
 


    public class ReceiptModel : Xsd.ReceiptType
    {

        public static ReceiptModel Receipt {get; set;}
        public static int IDCounter { get; set; }

        public ReceiptModel(bool create = false)
        {
            if (!create)
            { if (Receipt == null)//[Key]
                {
                    Receipt = new ReceiptModel(true);
                    Receipt.Id = "1";
                    Receipt.Taxcode = "IDK co je TaxCode";
                    Receipt.Issuedat = DateTime.Now;
                    Receipt.Provider = new Provider(true);
                    Receipt.Items = new Item[2];
                    Receipt.Items[0] = new Item() { Name = "kosenie obilia", Quantity = 350, Price = 17500, Id = "1" };
                    Receipt.Items[1] = new Item() { Name = "presun", Quantity = 60, Price = 300, Id = "2" };
                    IDCounter = 2;
                }
            }
        }
    }



    public class ReceiptsModel: Xsd.ReceiptsType
    {
    }

    public class Provider : Xsd.Businessobject
    {
        public Provider(bool create = false)
        {

            if (create)
            {
                //if (ReceiptModel.Receipt.Provider == null)
                //{
                    //ReceiptModel.Receipt.Provider = new Provider(true);
                    /*ReceiptModel.Receipt.Provider.*/Address = new Address(true);
                    /*ReceiptModel.Receipt.Provider.*/Name = "JMG Agro, s.r.o.";
                    /*ReceiptModel.Receipt.Provider.*/Companyregnum = "46 493 115";
                   /* ReceiptModel.Receipt.Provider.*/Vatregnum = "SK20281611";
                //}
            }
        }

    }

    public class Address : Xsd.AddressType
    {
        public Address(bool create = false)
        {
            if (create)
            {
                //if (ReceiptModel.Receipt.Provider.Address == null)
                //{
                    //ReceiptModel.Receipt.Provider.Address = new Address(true);

                    /*ReceiptModel.Receipt.Provider.Address.*/Street = "Tuchyňa";
                    /*ReceiptModel.Receipt.Provider.Address.*/City = "Tuchyňa";
                    /*ReceiptModel.Receipt.Provider.Address.*/Zip = "018 55";
                    /*ReceiptModel.Receipt.Provider.Address.*/Country = "Slovakia";
                //}
            }
        }
    }

    public class Item : Xsd.ItemType
    {
        public Item() {
        }

        public double TotalPrice {
            get
            { return Quantity * (double)Price; }
        }

    }

}