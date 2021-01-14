
using Bertonis.BLL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertonis.BLL.Contracts
{
  public interface ICommentsService
  {
    Task<List<CommentViewModel>> GetCommentsByPhotoId(int photoId);
  }
}