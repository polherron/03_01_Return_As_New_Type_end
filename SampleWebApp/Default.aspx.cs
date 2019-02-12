using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SampleWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

          protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Model.Model.UpdateData();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Model.Model.CreateData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Model.Model.DeleteData(8);
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = Model.Model.ReadData().Employees;
            GridView1.DataBind();

        }
    }
}