using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlayerListAssignment
{
    public partial class PlayersDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Panel1.Visible = false;
            Panel2.Visible = false;
        }

        protected void CricketPlayers_CheckedChanged(object sender, EventArgs e)
        {
            if(CricketPlayers.Checked == true)
            {
                Panel1.Visible = true;
            }
                
        }

        protected void TennisPlayers_CheckedChanged(object sender, EventArgs e)
        {
            if(TennisPlayers.Checked = true )
            {
                Panel2.Visible = true;
            }
        }
    }
}