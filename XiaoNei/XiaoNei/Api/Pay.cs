using XiaoNei.ApiContainer;

namespace XiaoNei.Api
{
    public class Pay:ApiBase
    {
        public Pay(XiaoNeiApi api) : base(api){}

        /*
         * xiaonei.pay.regOrder
          	order_id  	long  	用户消费校内豆订单号，参数必须保证唯一，每一次不能传递相同的参数。
	amount 	int 	校内豆消费数额, 取值范围为[0,100]
	desc 	String 	用户使用校内豆购买的虚拟物品的名称
         
         
         <10800>  	传递订单号已失效，无法获取到token
<10801> 	无效的订单号 (小于零)
<10802> 	消费金额无效:不支持大笔消费金额
<10803> 	校内网支付平台,应用资料审核未通过，无法使用平台,请在此处填写申请信息
<10804> 	该订单不存在
         */
        public string RegOrder(long orderId,int amount,string desc,FormatType format)
        {
            var dict = CreateDictionary(Api.CanPay ? "xiaonei.pay.regOrder" : "xiaonei.pay4Test.regOrder", true);
            dict.Add("order_id", orderId.ToString());
            dict.Add("amount", amount.ToString());
            dict.Add("desc", desc);
            
            return Api.Proc<PayRegOrderContainer>(dict).Token;
        }
        /*
         *  	xiaonei.pay.isCompleted
         Pay.isCompleted
         *  	order_id  	long  	用户消费校内豆订单号。
         */
        public bool IsCompleted(long orderId, FormatType format)
        {
            var dict = CreateDictionary(Api.CanPay ? "xiaonei.pay.isCompleted" : "xiaonei.pay4Test.isCompleted", true);
            dict.Add("order_id", orderId.ToString());
            return Api.Proc<PayIsCompleteContainer>(dict).Result;
        }
    }
}