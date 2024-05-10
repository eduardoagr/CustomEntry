namespace CustomEntry.Controls;

public partial class CustomEntry : ContentView {
    public CustomEntry() {
        InitializeComponent();
    }


    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(
        nameof(CornerRadius), typeof(int), typeof(CustomEntry));

    public int CornerRadius {
        get => (int)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }


    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text), typeof(string), typeof(CustomEntry));

    public string Text {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }


    public static readonly BindableProperty HintProperty = BindableProperty.Create(
        nameof(Hint), typeof(string), typeof(CustomEntry));

    public string Hint {
        get => (string)GetValue(HintProperty);
        set => SetValue(HintProperty, value);
    }


    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(
        nameof(BorderColor), typeof(Brush), typeof(CustomEntry),
        BindingMode.TwoWay);

    public Brush BorderColor {
        get => (Brush)GetValue(BorderColorProperty);
        set => SetValue(BorderColorProperty, value);
    }

}