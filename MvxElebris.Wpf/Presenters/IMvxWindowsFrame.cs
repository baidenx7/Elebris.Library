namespace MvxElebris.Wpf.Presenters
{
    public interface IMvxWindowsFrame
    {
        Control UnderlyingControl { get; }
        object Content { get; }
        bool CanGoBack { get; }
        bool Navigate(Type viewType, object parameter);
        void GoBack();
        void ClearValue(DependencyProperty property);
        object GetValue(DependencyProperty property);
        void SetValue(DependencyProperty property, object value);
        void SetNavigationState(string state);
        string GetNavigationState();
    }

}
