﻿using System;
using OpenDoc.Models;

namespace OpenDoc
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] != null)
            {
                Usuario user = Session["USER"] as Usuario;
                LBL_User.Text = user.descrip;

                if (user.tip_usuario != 0)
                {
                    item_conf.Attributes.Add("class", "disabled");
                    item_conf.Attributes.Add("href", "#");
                }
            }
            else
                Response.Redirect("Login.aspx");
        }
    }
}