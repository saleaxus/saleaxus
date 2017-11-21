using Saleaxus.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Saleaxus
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(new decimal(10),"name"));
            this.ProductList.DataSource = products;
            this.ProductList.DataBind();
        }
    }
}