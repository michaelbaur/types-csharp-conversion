namespace yWorks.Blunter.Annotations
{
    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    [BlunterExclude]
    public class StubAttribute : Attribute { }

    /// <summary>
    ///   Marks types and members that are completely ignored by Blunter.
    /// </summary>
    [BlunterExclude]
    public sealed class BlunterExcludeAttribute : Attribute { }
}