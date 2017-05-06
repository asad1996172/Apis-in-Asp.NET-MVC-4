using Maharaja_Tandoori.Models;
using Maharaja_Tandoori.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Globalization;

namespace Maharaja_Tandoori.Controllers
{
    public class apisController : ApiController
    {
        public List<ProductDetails> getItems()
        {
            List<ProductDetails> pr;
            DB_A1AEE5_essShoppingCart productRepository = new DB_A1AEE5_essShoppingCart();

            pr = (from c in productRepository.Categories
                  select new ProductDetails
                  {
                      Id = c.Id,
                      CategoryName = c.Name,
                      CategoryNameFr = c.NameFr,
                      CategoryNameDu = c.NameDu,
                      CategoryIsActive = c.IsActive,
                      products =     (from p in productRepository.Products
                                      where p.CategoryId == c.Id
                                      select new AllProducts
                                      {
                                            Id = p.Id,
                                            ProductCode = p.ProductCode,
                                            Name = p.Name,
                                            NameFr = p.NameFr,
                                            NameDu = p.NameDu,
                                            Description = p.Description,
                                            DescriptionFr = p.DescriptionFr,
                                            DescriptionDu = p.DescriptionDu,
                                            Price = p.Price,
                                            FixedDiscount = p.FixedDiscount,
                                            DiscountPercentage = p.DiscountPercentage,
                                            Image = p.Image,
                                            IsActive = p.IsActive,
                                            productExtras =
                                                                                (from pe in productRepository.ProductExtras
                                                                                 where pe.ProductId == p.Id
                                                                                 select new AllProductExtras
                                                                                 {
                                                                                     Id = pe.Id,
                                                                                     Name = pe.Name,
                                                                                     NameFr = pe.NameFr,
                                                                                     NameDu = pe.NameDu,
                                                                                     Price = pe.Price

                                                                                 })
                     
                                      })
                      
                     
                  }).ToList();
                
            return pr;
        }
        public List<string> getPostalCodes()
        {
            List<string> pr;
            DB_A1AEE5_essShoppingCart zipcoderepo = new DB_A1AEE5_essShoppingCart();
            pr = zipcoderepo.ZipCodes.Select(x => x.ZipCode ).ToList();
            return pr; 
        }

        public List<Setup> getInfo()
        {
            List<Setup> pr;
            DB_A1AEE5_essShoppingCart settingRepository = new DB_A1AEE5_essShoppingCart();

            pr = settingRepository.Settings.ToList();

            return pr;
        }


        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public Dictionary<string, bool> verifyCoupon(string coupon)
        {
            DB_A1AEE5_essShoppingCart db = new DB_A1AEE5_essShoppingCart();
            var dictionary = new Dictionary<string, bool>();

            if (db.Promotions.Any(o => o.DiscountCoupon == coupon))
            {
                // Match!
                DateTime curr = DateTime.Now;
                Promotion promotion = db.Promotions.First(a => a.DiscountCoupon == coupon);

                if ((DateTime.Compare(curr, promotion.ExpiryDate) < 0) && (promotion.IsActive == true))
                {
                    dictionary.Add("result", true);
                }
                else
                {
                    dictionary.Add("result", false);
                }
                
            }
            else
            {
                dictionary.Add("result", false);
            }
            
            return dictionary;
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpPost]
        public Dictionary<string, string> saveOrder([FromBody]OrderSpecifications json)
        {
            bool check = true;
            bool check2 = true;
            //Convert.ToDateTime(json.OrderDateTime)
            DB_A1AEE5_essShoppingCart db = new DB_A1AEE5_essShoppingCart();
            Order order = new Order();
            //order.ID = Guid.NewGuid();
            order.Amount = json.Amount;
            order.CustomerId = json.CustomerId;
            order.OrderDateTime = Convert.ToDateTime(json.OrderDateTime);
            order.ConfirmedDateTime = Convert.ToDateTime(json.ConfirmedDateTime);
            order.Status = json.Status;
            order.PaymentRefID = json.PaymentRefID;
            order.FirstName = json.FirstName;
            order.LastName = json.LastName;
            order.Phone = json.Phone;
            order.Email = json.Email;
            order.Zipcode = json.Zipcode;
            order.City = json.City;
            order.DeliveryAddress = json.DeliveryAdress;
            order.PayerID = json.PayerID;
            order.Notes = json.Notes;
            order.AppliedDiscount = json.AppliedDiscount;
            order.PayBy = json.PayBy;
            order.DeliveryTime = TimeSpan.Parse(json.DeliveryTime);
            order.PayWith = json.PayWith;
            order.OrderStatus = json.OrderStatus;
            order.DeliveryMintues = TimeSpan.Parse(json.DeliveryMinutes);

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            db.Orders.Add(order);
            try
            {
                db.SaveChanges();

                check = true;
            }
            catch (Exception e)
            {
                check = false;
                dictionary.Add("result", "Order Not Created");
            }

            if (check == true)
            {
                foreach (var item in json.OrderDetail)
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.OderID = order.ID;
                    orderDetails.Price = item.ODPrice;
                    orderDetails.ProductID = item.ODProductID;
                    orderDetails.Quantity = item.ODQuantity;
                    orderDetails.ProductExtraID = item.ODProductExtraID;
                    orderDetails.ProductExtraPrice = item.ODProductExtraPrice;

                    db.OrderDetails.Add(orderDetails);
                    try
                    {
                        db.SaveChanges();
                        check2 = true;
                        
                    }
                    catch (Exception e)
                    {
                        check2 = false;
                        
                    }   
                }
                

            }


            if (check2 == true && check !=false)
            {
                dictionary.Add("result", "Order Created");
            }
            else if (check2 == false && check != false)
            {
                dictionary.Add("result", "Order Not Created");
            }
            return dictionary;
        }

    }
}
