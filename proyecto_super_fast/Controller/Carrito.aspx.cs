﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Carrito : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        GV_Carrito.DataSource = (List<Pedido>)Session["Carrito"];
        GV_Carrito.DataBind();
    }
}