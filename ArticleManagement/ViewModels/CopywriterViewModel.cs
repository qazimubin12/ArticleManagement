﻿using ArticleManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArticleManagement.ViewModels
{
    public class CopywriterViewModel
    {
        public List<Article> Articles { get; set; }
        public User SignInUser { get; set; }
        public string SearchTerm { get; set; }
    }
}