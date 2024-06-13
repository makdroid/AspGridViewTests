using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class GridViewControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void BindGridViewData(object dataSource)
        {
            GridView1.DataSource = dataSource;
            GridView1.DataBind();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            //BindGridView(); // Call a function to rebind the GridView
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            string name = ((TextBox)row.Cells[1].Controls[0]).Text; // Assuming Name is in the second column
            int age = Convert.ToInt32(((TextBox)row.Cells[2].Controls[0]).Text); // Assuming Age is in the third column
                                                                                 // Update the DataTable with the new values
            DataTable dt = (DataTable)GridView1.DataSource;
            DataRow dr = dt.Rows.Find(id);
            if (dr != null)
            {
                dr["Name"] = name;
                dr["Age"] = age;
                // Now, update your database with these changes if required
                // e.g., call a method to update your database
                // database.UpdateData(id, name, age);
            }
            GridView1.EditIndex = -1; // Exit edit mode
            //BindGridView(); // Rebind the GridView
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1; // Exit edit mode
            //BindGridView(); // Rebind the GridView
        }

    }
}