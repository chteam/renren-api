using System.Web.UI;
using System.Web;
using XiaoNei;

public class XPage : Page,XiaoNei.IXiaoNeiHandler
{
    protected override void OnInit(System.EventArgs e)
    {
        base.OnInit(e);
        Api = new XiaoNeiApi(
            Session["xn_sig_api_key"].ToString(),
            Session["secret"].ToString(),
            Session["xn_sig_session_key"].ToString(),
            this);
    }
    public XiaoNeiApi Api { get; set; }
    public bool IsDebug { get; set; }
    public string UserID { get; set; }
    
    
}
