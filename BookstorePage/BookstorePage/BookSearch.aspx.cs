﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookstorePage
{
    public partial class BookSearchResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Book> results= (List<Book>)Session["Results"];
            for (int i = 0; i < results.Count; i++)
            {
                
            }
        }
    }
}