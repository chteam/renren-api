
namespace XiaoNei {
	public interface IXiaoNeiHandler {
		/// <summary>
		/// 返回API实例
		/// </summary>
		XiaoNeiApi Api { get; set; }
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
