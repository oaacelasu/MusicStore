using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ValidationController : Controller
    {
        public JsonResult CheckGenre(string genreId, [FromServices]IRepository<Genre> data)
        {
            var validate = new Validate(TempData);
            validate.CheckGenre(genreId, data);
            if (validate.IsValid) {
                validate.MarkGenreChecked();
                return Json(true);
            }
            else {
                return Json(validate.ErrorMessage);
            }
        }

        public JsonResult CheckArtist(string firstName, string operation, [FromServices]IRepository<Artist> data)
        {
            var validate = new Validate(TempData);
            validate.CheckArtist(firstName, operation, data);
            if (validate.IsValid) {
                validate.MarkArtistChecked();
                return Json(true);
            }
            else {
                return Json(validate.ErrorMessage);
            }
        }

    }
}