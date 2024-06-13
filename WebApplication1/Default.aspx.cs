using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        public DataTable Data { get; set; }
        public object GridViewDataSource
        {
            set
            {
                WebUserControl3.GridViewDataSource = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder cstext1 = new StringBuilder();
            cstext1.Append("function showPopup() {document.getElementById('popupPanel').style.display = 'block';}");

            //ClientScript.RegisterStartupScript(this.GetType(), "PopupScript", cstext1.ToString(), true);

            if (!IsPostBack)
            {
                LoadData();
                BindGridViewData();
            }
        }

        private void BindGridViewData()
        {
            GridViewDataSource = Data;
        }

        private void LoadData()
        {
            // Create a DataTable
            Data = new DataTable();
            // Assuming you have columns in your DataTable, add them here
            Data.Columns.Add("ID", typeof(int));
            Data.Columns.Add("Name", typeof(string));
            Data.Columns.Add("Age", typeof(int));
            // Populate the DataTable with some sample data
            Data.Rows.Add(1, "John", 30);
            Data.Rows.Add(2, "Jane", 25);
            Data.Rows.Add(3, "Bob", 40);
        }

        protected void btnShowPopup_Click(object sender, EventArgs e)
        {
            // Show the Bootstrap Modal using jQuery
            ScriptManager.RegisterStartupScript(this, GetType(), "showModal", "$(document).ready(function () { $('#myModal').modal('show'); });", true);
        }
    }
}