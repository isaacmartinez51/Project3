using Continental.CUP.Repositories.Data;
using Continental.CUP.Repositories.Data.Entities;
using Continental.CUP.Repositories.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Continental.CUP.Web.Controllers.Shipment
{
    public class ShipmentController : Controller
    {
        private ApplicationDbContext _context;
        public ShipmentController(ApplicationDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// This method is called when the view is initialized.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// This method is called when is need to create an order.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(OrderVModel item)
        {
            if (ModelState.IsValid)
            {
                #region Fill select
                ViewBag.ReaderList = new SelectList(_context.Reader.ToList(), "ReaderID", "Name");
                #endregion
                #region Get order by ID
                OrderEModel orderModel = new OrderEModel();
                orderModel = _context.Order.FirstOrDefault(x => x.ShipmentNumber == item.Number);
                if (null == orderModel)
                {

                    //Actualizar Orden
                    orderModel = new OrderEModel()
                    {
                        Date = DateTime.Now,
                        Number = item.Number,
                        OnShipment = false,
                        ReaderID = null,
                        ShipmentNumber = item.Number
                    };
                    orderModel =  _context.Order.Add(orderModel).Entity;
                }
                //else
                //{
                //    orderModel = new OrderEModel()
                //    {
                //        ID = order.ID,
                //        Date = order.Date,
                //        Number = order.Number,
                //        OnShipment = order.OnShipment,
                //        ReaderID = order.ReaderID,
                //        ShipmentNumber = order.Number
                //    };

                //}
                #endregion

                #region obtener información de embarques
                //1.- Obtener el total de piezas

                List<OrderDetailVModel> embarques = new List<OrderDetailVModel> {
                    new OrderDetailVModel{ Traza =100922, PartNumber ="A2C98063402", Quantity = 48},
                    new OrderDetailVModel{ Traza =100920, PartNumber ="A2C98062602", Quantity = 240},
                    new OrderDetailVModel{ Traza =100921, PartNumber ="A2C98062602", Quantity = 96},
                    new OrderDetailVModel{ Traza =100921, PartNumber ="A2C98062702", Quantity = 48},

                };
                // 1.1.-el total de piezas convertirlo a tarimas
                foreach (OrderDetailVModel embarque in embarques)
                {
                    Console.WriteLine(embarque.PartNumber);
                    embarque.UnitID = embarque.Quantity / 48;
                    embarque.OrderID = orderModel.OrderID;
                }
                List<OrderDetailEModel> ordersDetail = JsonConvert.DeserializeObject<List<OrderDetailEModel>>(JsonConvert.SerializeObject(embarques).ToString());
                Console.WriteLine(embarques);
                _context.OrderDetail.AddRange(ordersDetail);
                _context.SaveChanges();
                #endregion
                OrderVModel orders = JsonConvert.DeserializeObject<OrderVModel>(JsonConvert.SerializeObject(orderModel).ToString());
                orders.ListOrderDetail = embarques;
                ViewBag.OrderDetail = embarques;
                ViewBag.Show = true;
                return View(orderModel);

            }
            else
                ViewBag.Show = false;
            return View(item);
        }



    }


    public class ReadTag
    {
        public string TagNumber { get; set; }
    }

    public class ReturnPartNumber
    {
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
        public int Success { get; set; }
    }
}