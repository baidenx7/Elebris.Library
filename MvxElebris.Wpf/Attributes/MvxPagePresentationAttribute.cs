using MvvmCross.Presenters.Attributes;

namespace MvxElebris.Wpf.Presenters
{
    public class MvxPagePresentationAttribute : MvxBasePresentationAttribute
    {
        public static bool DefaultWrapInNavigationController = false;
        public bool WrapInNavigationController { get; set; } = DefaultWrapInNavigationController;
    }

    public enum SplitPanePosition
    {
        Pane,
        Content
    }
}
