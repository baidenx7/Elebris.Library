using MvvmCross.Presenters.Attributes;

namespace MvxElebris.Wpf.Presenters
{
    public class MvxSplitViewPresentationAttribute : MvxBasePresentationAttribute
    {

        public MvxSplitViewPresentationAttribute() : this(SplitPanePosition.Content)
        {

        }

        public MvxSplitViewPresentationAttribute(SplitPanePosition position)
        {
            Position = position;
        }

        public SplitPanePosition Position { get; set; }
    }
}
