﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DocView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var filePath = Request.QueryString["filePath"];
    }

    protected void Login_Jmp_bt_Click(object sender, EventArgs e)
    {

    }
}