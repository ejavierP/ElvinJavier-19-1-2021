using Bertonis.BLL.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace Bertonis.Web.Controllers
{
    public class GalleryController : Controller
    {

        private readonly IAlbumsService _albumsService;
        private readonly IPhotosService _photosService;

        public GalleryController(IAlbumsService albumsService, IPhotosService photosService, ICommentsService commentsService)
        {
            _albumsService = albumsService;
            _photosService = photosService;
        }

        public async Task<IActionResult> Index()
        {
            var albums = await _albumsService.GetAlbums();
            return View(albums);
        }

        public async Task<IActionResult> Photos(int Id)
        {
            var photos = await _photosService.GetPhotosByAlbumId(Id);

            return View(photos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
