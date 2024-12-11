namespace UnoPlatformAttatchedPropertyDemo.Presentation;

public static class Uids
{
    public static readonly DependencyProperty UidProperty =
        DependencyProperty.RegisterAttached(
            "Uid",
            typeof(string),
            typeof(Uids),
            new PropertyMetadata(default));

    public static string GetUid(DependencyObject obj) => (string)obj.GetValue(UidProperty);

    public static void SetUid(DependencyObject obj, string value) => obj.SetValue(UidProperty, value);
}

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        Loaded += MainPage_Loaded;
    }

    private void MainPage_Loaded(object sender, RoutedEventArgs e)
    {
        var buttonUid = Uids.GetUid(GoToSecondButton);
        GoToSecondButton.Content = buttonUid;
    }
}
