
using Bertonis.BLL.Contracts;
using Bertonis.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BertoniAPP.BLL.Services
{
    public class CommentsService : ICommentsService
    {
        private IGalleryApi _galleryApi;

        public CommentsService(IGalleryApi galleryApi)
        {
            _galleryApi = galleryApi;
        }

        public async Task<List<CommentViewModel>> GetCommentsByPhotoId(int photoId)
        {
            var response = await _galleryApi.GetCommentsByPhotoId(photoId);
            var comments = response.Select(x => new CommentViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Body = x.Body
            }).ToList();

            if(!comments.Any())
                throw new Exception("Theres no comments with the photo id specified id");

            return comments;
        }

    }
}
