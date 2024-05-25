using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string roomType = ddlRoomType.SelectedValue;
            DateTime checkInDate = DateTime.Parse(txtCheckInDate.Text);
            DateTime checkOutDate = DateTime.Parse(txtCheckOutDate.Text);

            Models.Reservation dataAccess = new Models.Reservation();
            dataAccess.AddReservation(name, email, roomType, checkInDate, checkOutDate);

            lblMessage.Text = "Reservation successful!";
        }
    }
}
