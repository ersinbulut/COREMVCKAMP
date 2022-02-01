﻿using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentavalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Ersin"
                },
                 new UserComment
                {
                    ID=2,
                    Username="Mesut"
                },
                  new UserComment
                {
                    ID=3,
                    Username="Merve"
                },
            };
            return View(commentavalues);
        }
    }
}
