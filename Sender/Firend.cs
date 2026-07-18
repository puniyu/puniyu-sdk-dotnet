namespace Puniyu.Sender;

/// <summary>
/// 表示一个好友发送者的信息，是 <see cref="ISender"/> 接口的密封实现。
/// </summary>
public sealed class FriendSender : ISender
{
    private readonly string _userId;
    private readonly string? _name;
    private readonly Sex _sex;
    private readonly uint? _age;

    /// <summary>
    /// 初始化 <see cref="FriendSender"/> 类的新实例。
    /// </summary>
    /// <param name="userId">发送者的唯一用户标识符。</param>
    /// <param name="name">发送者的昵称或显示名称；若未设置则为 <c>null</c>。</param>
    /// <param name="sex">发送者的性别；默认为 <see cref="Sex.Male"/>（即 <c>0</c>）。</param>
    /// <param name="age">发送者的年龄；若年龄未知则为 <c>null</c>。</param>
    public FriendSender(string userId, string? name = null, Sex sex = Sender.Sex.Unknown, uint? age = null)
    {
        _userId = userId;
        _name = name;
        _sex = sex;
        _age = age;
    }

    /// <inheritdoc/>
    public string UserId() => _userId;

    /// <inheritdoc/>
    public string? Name() => _name;

    /// <inheritdoc/>
    public Sex Sex() => _sex;

    /// <inheritdoc/>
    public uint? Age() => _age;
}