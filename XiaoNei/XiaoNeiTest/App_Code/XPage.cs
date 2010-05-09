using System.Web.UI;
using System.Web;
using RenRen;

public class XPage : Page,RenRen.IRenRenHandler
{
    protected override void OnInit(System.EventArgs e)
    {
        base.OnInit(e);
        Api = new RenRenApi(
            Session["xn_sig_api_key"].ToString(),
            Session["secret"].ToString(),
            Session["xn_sig_session_key"].ToString(),
            this);
    }
    public RenRenApi Api { get; set; }
    public bool IsDebug { get; set; }
    public string UserID { get; set; }
    
    
}
