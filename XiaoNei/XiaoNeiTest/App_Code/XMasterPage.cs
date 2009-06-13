
using System.Text;
using System.Web.UI;

public class XMasterPage : MasterPage
{
    public string QueryData
    {
        get
        {
            StringBuilder qd = new StringBuilder("xn_sig_session_key=");
            qd.Append(Session["xn_sig_session_key"]);
            qd.Append("&");
            qd.Append("xn_sig_api_key=");
            qd.Append(Session["xn_sig_api_key"]);
            return qd.ToString();
        }
    }
}
