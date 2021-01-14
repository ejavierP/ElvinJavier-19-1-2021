
using Bertonis.BLL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertonis.BLL.Contracts
{
  public interface IAlbumsService
  {
    Task<List<AlbumViewModel>> GetAlbums();
  }
}