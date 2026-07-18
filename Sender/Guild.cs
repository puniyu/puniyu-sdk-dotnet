namespace Puniyu.Sender;

/// <summary>
/// 表示频道消息发送者的信息
/// </summary>
/// <remarks>
/// <para>
/// 与好友发送者（<see cref="FriendSender"/>）相比，此类额外提供了频道内角色、频道名片、等级和专属头衔等频道特有属性。
/// </para>
/// <para>
/// 该类型是不可变的，所有属性均在构造时确定，且遵循 <see cref="ISender"/> 接口约定。
/// </para>
/// </remarks>
public sealed class GuildSender : ISender
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
    /// 初始化 <see cref="GuildSender"/> 类的新实例。
    /// </summary>
    /// <param name="userId">发送者的唯一用户标识符。不能为 <c>null</c> 或空白字符串。</param>
    /// <param name="name">发送者的全局昵称（显示名称）。若未设置则为 <c>null</c>。</param>
    /// <param name="sex">发送者的性别。默认为 <see cref="Sex.Unknown"/>。</param>
    /// <param name="age">发送者的年龄（若已知）。默认为 <c>null</c>。</param>
    /// <param name="role">发送者在频道内的角色（如所有者、管理员、成员等）。默认为 <see cref="Role.Unknown"/>。</param>
    /// <param name="card">发送者在频道内的名片（即频道内自定义昵称）。若未设置则为 <c>null</c>。</param>
    /// <param name="level">发送者在频道内的等级（通常基于活跃度）。若未设置则为 <c>null</c>。</param>
    /// <param name="title">发送者在频道内的专属头衔（如“技术顾问”）。若未设置则为 <c>null</c>。</param>
    /// <exception cref="ArgumentException">当 <paramref name="userId"/> 为 <c>null</c> 或仅含空白字符时引发。</exception>
    public GuildSender(
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
    /// 获取发送者在频道内的角色（如群主、管理员、普通成员等）。
    /// </summary>
    /// <returns>
    /// 一个 <see cref="Role"/> 枚举值，表示该用户在频道中的权限等级。
    /// </returns>
    public Role Role() => _role;

    /// <summary>
    /// 获取发送者在频道内的名片（即频道内自定义显示名称）。
    /// </summary>
    /// <returns>
    /// 频道名片字符串；若未设置则返回 <c>null</c>。
    /// </returns>
    /// <remarks>
    /// 频道名片不同于全局昵称（<see cref="Name"/>），仅在当前频道内生效。
    /// </remarks>
    public string? Card() => _card;

    /// <summary>
    /// 获取发送者在频道内的等级（通常基于活跃度或经验值）。
    /// </summary>
    /// <returns>
    /// 等级数值；若未设置或不可用则返回 <c>null</c>。
    /// </returns>
    public uint? Level() => _level;

    /// <summary>
    /// 获取发送者在频道内的专属头衔（如“资深成员”、“技术顾问”等）。
    /// </summary>
    /// <returns>
    /// 专属头衔字符串；若未设置则返回 <c>null</c>。
    /// </returns>
    public string? Title() => _title;
}