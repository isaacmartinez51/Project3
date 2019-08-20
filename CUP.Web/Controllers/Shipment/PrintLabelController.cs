using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Continental.CUP.Web.Classes;
using Continental.CUP.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Continental.CUP.Web.Controllers.Shipment
{
    public class PrintLabelController : SessionController
    {
        public PrintLabelController(IOptions<AppSettings> appSettings)
        {
            this.AppSettings = appSettings.Value;
        }

        public IActionResult Index(SerialPrintModel item)
        {
            bool print = false;
            if (null != item.Serial)
            {
                item = ConnectionTraza.GetInformationSerial(this.AppSettings, item.Serial);
                string zpl = replaceZPL(this.AppSettings, item);
                print = printLabel(this.AppSettings, zpl);
            }
            return View();
        }

        #region Portal





        public IActionResult Portal( )
        {
            return View();
        } 






        #endregion

        private string replaceZPL(AppSettings appSettings, SerialPrintModel label)
        {

            if (label != null)
            {
                string zplBase = appSettings.ZPL;
                StringBuilder zpl = new StringBuilder(zplBase);
                zpl.Replace("*tittle*", "Blackflush de Producto Terminado");
                zpl.Replace("*em*", "Etiqueta Master");
                zpl.Replace("*mlfb*", label.MLFB);
                zpl.Replace("*sh*", label.PackingType);
                zpl.Replace("*ta*", "Tarima");
                zpl.Replace("*qan*", label.Quantity.ToString());
                zpl.Replace("sr", label.Serial);
                zpl.Replace("*date*", DateTime.Now.ToString());

                return zpl.ToString();
            }
            return null;
        }

        private bool printLabel(AppSettings appSettings, string zpl)
        {

            return RawPrinterHelper.SendStringToPrinter(appSettings.PrintNames, zpl);
        }
    }
}






















//private SerialPrintModel GetInformationSerial(AppSettings appSettings, string serial) {


//    return null;
//}
//[HttpPost]
//public async Task<ActionResult> Index(string value)
//{
//    SerialPrintModel serial = new SerialPrintModel();
//    serial.Serial = value;
//    var result = await Task.Run(() =>
//    {
//        return (1 - 99) / 2;
//    });

//    return View(serial);
//}