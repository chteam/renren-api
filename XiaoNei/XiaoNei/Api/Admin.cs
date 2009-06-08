using XiaoNei.ApiContainer.Admin;

namespace XiaoNei.Api
{
    public class Admin : ApiBase
    {
        public Admin(XiaoNeiApi api) : base(api) { }

        /// <summary>
        /// ��ȡһ��Ӧ�õ�����Է��͵�֪ͨ�����
        /// <example>
        ///required api_key string ����Ӧ��ʱ�����api_key�����ýӿ�ʱ�����Ӧ�õ�Ψһ��ݡ� 
        ///method string xiaonei.admin.getAllocation 
        ///call_id float ��ǰ����������кţ�����ʹ�õ�ǰϵͳʱ��ĺ���ֵ�� 
        ///sig string �����ɵ�ǰ���������secretKey��һ��MD5ֵ, �й�ǩ�������֤���ĵ�����鿴У��REST�����֤���Ӧ�ã� 
        ///v  	string  	API�İ汾�ţ������ó�1.0
        ///optional 	format 	string 	Response�ĸ�ʽ,XML����JSON��ȱʡֵΪXML��
        /// </example>
        /// </summary>
        /// <returns></returns>
        public AllocationContainer Allocation(FormatType format)
        {
            var dict = CreateDictionary("xiaonei.admin.getAllocation");
            //add format
            return Api.Proc<AllocationContainer>(dict);
        }
        public AllocationContainer Allocation()
        {
            return Allocation(FormatType.Xml);
        }
    }
}