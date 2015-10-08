using SIvPaVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIvPaVS.Controllers
{
    public class ReceiptController : Controller
    {
        // GET: Receipt
        public ActionResult Receipt()
        {

            if (ReceiptModel.Receipt == null) new ReceiptModel();
            ViewData.Model = ReceiptModel.Receipt;
            return View();
        }

        [HttpPost]
        public ActionResult Index(Item item)
        {

            addNewItem(item);


            ViewData.Model = ReceiptModel.Receipt;

            //ViewData.Model = new HomeModel() { CompanyTitle = "test", TotalPrice = 145 };
            return View("~/Views/Receipt/Receipt.cshtml");
        }

       // [HttpPost]
        public ActionResult DeleteItem(string ID)
        {

            deleteItem(ID);


            ViewData.Model = ReceiptModel.Receipt;

            //ViewData.Model = new HomeModel() { CompanyTitle = "test", TotalPrice = 145 };
            return View("~/Views/Receipt/Receipt.cshtml");
        }

        private void deleteItem(string ID)
        {


            int position = 0;
            foreach (var item in ReceiptModel.Receipt.Items)
            {
                if (item.Id == ID)
                    break;
                
                position++;
            }


            var items = ReceiptModel.Receipt.Items;
            ReceiptModel.Receipt.Items = new Item[items.Count() -1];
            int receiptItemCounter = 0;
            int itemsCounter = 0;

            foreach (var item in items)
            {
                if (itemsCounter != position)
                    ReceiptModel.Receipt.Items[receiptItemCounter++] = item;

                itemsCounter++;
            }



        }

        private void addNewItem(Item item)
        {
            var items = ReceiptModel.Receipt.Items;
            ReceiptModel.Receipt.Items = new Item[items.Count() + 1];

            
            int counter = 0;
            foreach (var it in items)
            {
                ReceiptModel.Receipt.Items[counter++] = it;
            }
            item.Id = (++ ReceiptModel.IDCounter).ToString();
            ReceiptModel.Receipt.Items[counter] = item;

        }

        public ActionResult Company()
        {
            return PartialView();
        }


        public ActionResult Items()
        {
            return PartialView();
        }

        public ActionResult CompanyAddress()
        {
            return PartialView();
        }

        public ActionResult CreateItem()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateItem(Item item)
        {

            addNewItem(item);
            ViewData.Model = ReceiptModel.Receipt;

            //ViewData.Model = new HomeModel() { CompanyTitle = "test", TotalPrice = 145 };
            return View();
        }


    }
}