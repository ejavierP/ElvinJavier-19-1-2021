
using Bertonis.BLL.Contracts;
using Bertonis.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BertoniAPP.BLL.Services
{
    public class AlbumsService : IAlbumsService
    {
        private IGalleryApi _galleryApi;

        public AlbumsService(IGalleryApi galleryApi)
        {
            _galleryApi = galleryApi;
        }

        public async Task<List<AlbumViewModel>> GetAlbums()
        {
            var response = await _galleryApi.GetAlbums();
            var albums = response.Select(x => new AlbumViewModel
            {
                Id = x.Id,
                Title = x.Title
            }).ToList();

            if (!albums.Any())
                throw new Exception("Theres no albums avialable right now");

            return albums;
        }


    }
}
