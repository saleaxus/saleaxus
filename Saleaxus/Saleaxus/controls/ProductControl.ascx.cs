using Saleaxus.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Saleaxus.controls
{
    public partial class ProductControl : System.Web.UI.UserControl
    {
        public Product Product { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}