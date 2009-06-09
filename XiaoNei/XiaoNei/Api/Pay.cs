using XiaoNei.ApiContainer;

namespace XiaoNei.Api
{
    public class Pay:ApiBase
    {
        public Pay(XiaoNeiApi api) : base(api){}

        /*
         * xiaonei.pay.regOrder
          	order_id  	long  	�û�����У�ڶ������ţ��������뱣֤Ψһ��ÿһ�β��ܴ�����ͬ�Ĳ�����
	amount 	int 	У�ڶ���������, ȡֵ��ΧΪ[0,100]
	desc 	String 	�û�ʹ��У�ڶ������������Ʒ������
         
         
         <10800>  	���ݶ�������ʧЧ���޷���ȡ��token
<10801> 	��Ч�Ķ����� (С����)
<10802> 	���ѽ����Ч:��֧�ִ�����ѽ��
<10803> 	У����֧��ƽ̨,Ӧ���������δͨ�����޷�ʹ��ƽ̨,���ڴ˴���д������Ϣ
<10804> 	�ö���������
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
         *  	order_id  	long  	�û�����У�ڶ������š�
         */
        public bool IsCompleted(long orderId, FormatType format)
        {
            var dict = CreateDictionary(Api.CanPay ? "xiaonei.pay.isCompleted" : "xiaonei.pay4Test.isCompleted", true);
            dict.Add("order_id", orderId.ToString());
            return Api.Proc<PayIsCompleteContainer>(dict).Result;
        }
    }
}