namespace Puniyu.Sender;

/// <summary>
/// 表示一个群组发送者的信息，是 <see cref="ISender"/> 接口的密封实现。
/// 相比好友发送者，增加了群内角色、群名片、等级和专属头衔等信息。
/// </summary>
public sealed class GroupSender : ISender
{
    private readonly string _userId;
    private readonly string? _name;
    private readonly Sex _sex;
    private readonly uint? _age;
    private readonly Role _role;
    private readonly string? _card;
    private readonly uint? _level;
    private readonly string? _title;

    /// <summary>
    /// 初始化 <see cref="GroupSender"/> 类的新实例。
    /// </summary>
    /// <param name="userId">发送者的唯一用户标识符，不能为 null 或空白。</param>
    /// <param name="name">发送者的昵称或显示名称；若未设置则为 <c>null</c>。</param>
    /// <param name="sex">发送者的性别；默认为 <see cref="Sex.Unknown"/>。</param>
    /// <param name="age">发送者的年龄；若年龄未知则为 <c>null</c>。</param>
    /// <param name="role">发送者在群内的角色；默认为 <see cref="Role.Unknown"/>。</param>
    /// <param name="card">发送者的群名片；若未设置则为 <c>null</c>。</param>
    /// <param name="level">发送者的等级；若未设置则为 <c>null</c>。</param>
    /// <param name="title">发送者的专属头衔；若未设置则为 <c>null</c>。</param>
    /// <exception cref="ArgumentException">
    /// <paramref name="userId"/> 为 null 或空白字符串时抛出。
    /// </exception>
    public GroupSender(
        string userId,
        string? name = null,
        Sex sex = Sender.Sex.Unknown,
        uint? age = null,
        Role role = Sender.Role.Unknown,
        string? card = null,
        uint? level = null,
        string? title = null)
    {
        if (string.IsNullOrWhiteSpace(userId))
            throw new ArgumentException("用户 ID 不能为空或空白。", nameof(userId));

        _userId = userId;
        _name = name;
        _sex = sex;
        _age = age;
        _role = role;
        _card = card;
        _level = level;
        _title = title;
    }

    /// <inheritdoc/>
    public string UserId() => _userId;

    /// <inheritdoc/>
    public string? Name() => _name;

    /// <inheritdoc/>
    public Sex Sex() => _sex;

    /// <inheritdoc/>
    public uint? Age() => _age;

    /// <summary>
    /// 获取发送者在群组中的角色。
    /// </summary>
    /// <returns>一个 <see cref="Role"/> 枚举值。</returns>
    public Role Role() => _role;

    /// <summary>
    /// 获取发送者的群名片（群内自定义名称）。
    /// </summary>
    /// <returns>群名片字符串；若未设置则为 <c>null</c>。</returns>
    public string? Card() => _card;

    /// <summary>
    /// 获取发送者的等级。
    /// </summary>
    /// <returns>等级数值；若未设置则为 <c>null</c>。</returns>
    public uint? Level() => _level;

    /// <summary>
    /// 获取发送者的专属头衔。
    /// </summary>
    /// <returns>专属头衔字符串；若未设置则为 <c>null</c>。</returns>
    public string? Title() => _title;
}