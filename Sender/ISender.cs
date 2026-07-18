namespace Puniyu.Sender;

/// <summary>
/// 消息发送者
/// </summary>
public interface ISender
{
    /// <summary>
    /// 获取发送者的唯一标识符。
    /// </summary>
    /// <returns>代表用户 ID 的字符串。</returns>
    string UserId();

    /// <summary>
    /// 获取发送者的昵称或显示名称。
    /// </summary>
    /// <returns>发送者名称；如果未设置名称，则为 <c>null</c>。</returns>
    string? Name();

    /// <summary>
    /// 获取发送者的性别。
    /// </summary>
    /// <returns>一个 <see cref="Sex"/> 枚举值。</returns>
    Sex Sex();

    /// <summary>
    /// 获取发送者的年龄。
    /// </summary>
    /// <returns>年龄数值；如果年龄未知，则为 <c>null</c>。</returns>
    uint? Age();
}