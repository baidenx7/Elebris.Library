using MvvmCross.Presenters.Attributes;

namespace MvxElebris.Wpf.Presenters
{
    public sealed class MvxRegionPresentationAttribute : MvxBasePresentationAttribute
    {
        public MvxRegionPresentationAttribute(string regionName = null)
        {
            Name = regionName;
        }

        public string Name { get; private set; }
    }

}
