namespace Elebris.Actions.Library.Actions.Component
{
    /// <summary>
    /// This is a generic enum, each game should decide what system it wants to use
    /// </summary>
    public enum ActionTargetType
    {
        None,
        SingleTarget,
        SingleTargetOverTime,
        Area,
        AreaOverTime,
    }
}