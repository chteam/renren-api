
namespace RenRen {
    public interface IRenRenHandler
    {
        /// <summary>
        /// 返回API实例
        /// </summary>
        RenRenApi Api { get; set; }
        /// <summary>
        /// 是否运行调试模式
        /// </summary>
        bool IsDebug { get; set; }
        /// <summary>
        ///用户的ID
        /// </summary>
        string UserID { get; }
    }
}
