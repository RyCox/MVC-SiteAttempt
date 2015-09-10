using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MainSite.Core.Objects;
using MainSite.Core;
using System.Web.Mvc;

namespace MainSite.Models
{
    public class ListViewModel
    {
        public IList<Post> Posts { get; private set; }
        public int TotalPosts { get; private set; }

        public ListViewModel(IBlogRepository _blogRepository, int p)
        {
            Posts = _blogRepository.Posts(p - 1, 10);
            TotalPosts = _blogRepository.TotalPosts();
        }
    }
}