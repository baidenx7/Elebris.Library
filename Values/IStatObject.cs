namespace Elebris.Library.Values
{
    public interface IStatObject
    {
        void CalculateBaseValue(AttributeObject[] attributeObjects, int level);
        void DependantEventCalled(int level);
    }



}