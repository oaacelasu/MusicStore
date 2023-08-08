using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using Stripe;

namespace MusicStore.Controllers
{
    public class CartController : Controller
    {
        private IRepository<Album> data { get; set; }
        private ICart cart { get; set; }

        public CartController(IRepository<Album> rep, ICart c)
        {
            data = rep;
            cart = c;
            cart.Load(data);
        }

        public ViewResult Index() 
        {
            var vm = new CartViewModel {
                List = cart.List,
                SubTotal = cart.SubTotal
            };
            return View(vm);
        }

        [HttpPost]
        public RedirectToActionResult Add(int id)
        {
            var album = data.Get(new QueryOptions<Album> {
                Includes = "AlbumArtists.Artist, Genre",
                Where = b => b.AlbumId == id
            });
            if (album == null){
                TempData["message"] = "Unable to add album to cart";   
            }
            else {
                var dto = new AlbumDTO();
                dto.Load(album);
                CartItem item = new CartItem {
                    Album = dto,
                    Quantity = 1  // default value
                };
                cart.Add(item);
                cart.Save();

                TempData["message"] = $"{album.Title} added to cart";
            }
            return RedirectToAction("List", "Album");
        }

        public IActionResult Edit(int id)
        {
            CartItem item = cart.GetById(id);
            if (item == null) {
                TempData["message"] = "Unable to locate cart item";
                return RedirectToAction("List", "Album");
            }
            else {
                return View(item);
            }
        }
        [HttpPost]
        public RedirectToActionResult Edit(CartItem item)
        {
            cart.Edit(item);
            cart.Save();

            TempData["message"] = $"{item.Album.Title} updated";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult Remove(int id)
        {
            CartItem item = cart.GetById(id);
            cart.Remove(item);
            cart.Save();

            TempData["message"] = $"{item.Album.Title} removed from cart.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult Clear()
        {
            cart.Clear();
            cart.Save();

            TempData["message"] = "Cart cleared.";
            return RedirectToAction("Index");
        }

        public ViewResult Checkout() => View();
        
        public IActionResult Result(string payment_intent, string payment_intent_client_secret, string redirect_status)
        {
            // You can access and process the parameters here
            // For example, log the payment_intent, payment_intent_client_secret, and redirect_status
            cart.Clear();
            cart.Save();

            ViewBag.PaymentIntent = payment_intent;
            ViewBag.ClientSecret = payment_intent_client_secret;
            ViewBag.RedirectStatus = redirect_status;
            
            TempData["message"] = "Thank you for your order! - RedirectStatus: " + redirect_status;

            return RedirectToAction("Index", "Home");
        }
    }

    [Route("create-payment-intent")]
    [ApiController]
    public class PaymentIntentApiController : Controller
    {
        [HttpPost]
        public ActionResult Create(PaymentIntentCreateRequest request)
        {
            var paymentIntentService = new PaymentIntentService();
            var paymentIntent = paymentIntentService.Create(new PaymentIntentCreateOptions
            {
                Amount = CalculateOrderAmount(request.Items),
                Currency = "cad",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            });

            return Json(new { clientSecret = paymentIntent.ClientSecret });
        }
        private int CalculateOrderAmount(Item[] items)
        {
            // Replace this constant with a calculation of the order's amount
            // Calculate the order total on the server to prevent
            // people from directly manipulating the amount on the client
            return 1400;
        }
    }
}