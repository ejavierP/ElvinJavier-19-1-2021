using System;
using System.Collections.Generic;
using System.Text;

namespace Bertonis.BLL.ViewModels
{
  public class PhotoViewModel
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string ThumbnailUrl { get; set; }
    public List<CommentViewModel> Comments { get; set; }
}
}
