namespace Puniyu.Sender;

/// <summary>
/// 用户角色枚举。
/// </summary>
public enum Role
{
    /// <summary>
    /// 群主/频道主。
    /// </summary>
    Owner,
    /// <summary>
    /// 管理员。
    /// </summary>
    Admin,
    /// <summary>
    /// 群成员、频道成员。
    /// </summary>
    Member,
    /// <summary>
    /// 未知角色。
    /// </summary>
    Unknown
}

/// <summary>
/// <see cref="Role"/> 枚举的扩展方法。
/// </summary>
public static class RoleExtensions
{
    /// <summary>
    /// 判断当前角色是否为群主/频道主。
    /// </summary>
    /// <param name="role">要检查的角色枚举值。</param>
    /// <returns>如果是 <see cref="Role.Owner"/>，则为 <c>true</c>；否则为 <c>false</c>。</returns>
    public static bool IsOwner(this Role role)
    {
        return role == Role.Owner;
    }

    /// <summary>
    /// 判断当前角色是否为管理员。
    /// </summary>
    /// <param name="role">要检查的角色枚举值。</param>
    /// <returns>如果是 <see cref="Role.Admin"/>，则为 <c>true</c>；否则为 <c>false</c>。</returns>
    public static bool IsAdmin(this Role role)
    {
        return role == Role.Admin;
    }

    /// <summary>
    /// 判断当前角色是否为群成员/频道成员。
    /// </summary>
    /// <param name="role">要检查的角色枚举值。</param>
    /// <returns>如果是 <see cref="Role.Member"/>，则为 <c>true</c>；否则为 <c>false</c>。</returns>
    public static bool IsMember(this Role role)
    {
        return role == Role.Member;
    }

    /// <summary>
    /// 判断当前角色是否为未知角色。
    /// </summary>
    /// <param name="role">要检查的角色枚举值。</param>
    /// <returns>如果是 <see cref="Role.Unknown"/>，则为 <c>true</c>；否则为 <c>false</c>。</returns>
    public static bool IsUnknown(this Role role)
    {
        return role == Role.Unknown;
    }
}