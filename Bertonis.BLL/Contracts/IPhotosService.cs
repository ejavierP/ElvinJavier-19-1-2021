using Bertonis.BLL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertonis.BLL.Contracts
{
  public interface IPhotosService
  {
    Task<List<PhotoViewModel>> GetPhotosByAlbumId(int albumId);
    Task<PhotoViewModel> GetPhotoById(int photoId);
  }
}