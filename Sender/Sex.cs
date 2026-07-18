namespace Puniyu.Sender;

/// <summary>
/// 性别枚举。
/// </summary>
public enum Sex
{
    /// <summary>
    /// 男性。
    /// </summary>
    Male = 0,

    /// <summary>
    /// 女性。
    /// </summary>
    Female = 1,

    /// <summary>
    /// 性别未知或未指定。
    /// </summary>
    Unknown = 2
}

/// <summary>
/// <see cref="Sex"/> 枚举的扩展方法。
/// </summary>
public static class SexExtensions
{
    /// <summary>
    /// 判断当前性别是否为男性。
    /// </summary>
    /// <param name="sex">要检查的性别枚举值。</param>
    /// <returns>如果是 <see cref="Sex.Male"/>，则为 <c>true</c>；否则为 <c>false</c>。</returns>
    public static bool IsMale(this Sex sex)
    {
        return sex == Sex.Male;
    }

    /// <summary>
    /// 判断当前性别是否为女性。
    /// </summary>
    /// <param name="sex">要检查的性别枚举值。</param>
    /// <returns>如果是 <see cref="Sex.Female"/>，则为 <c>true</c>；否则为 <c>false</c>。</returns>
    public static bool IsFemale(this Sex sex)
    {
        return sex == Sex.Female;
    }

    /// <summary>
    /// 判断当前性别是否为未知。
    /// </summary>
    /// <param name="sex">要检查的性别枚举值。</param>
    /// <returns>如果是 <see cref="Sex.Unknown"/>，则为 <c>true</c>；否则为 <c>false</c>。</returns>
    public static bool IsUnknown(this Sex sex)
    {
        return sex == Sex.Unknown;
    }
}