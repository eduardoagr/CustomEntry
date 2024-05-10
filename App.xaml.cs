using CustomEntry.Controls;

namespace CustomEntry;

public partial class App : Application
{
	public App() {
		InitializeComponent();

		MainPage = new AppShell();

		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("BorderlessEntry", (handler, view) => {
			if (view is BorderlessEntry) {

#if ANDROID
				handler.PlatformView.Background = null;
				handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);

#elif IOS || MACCATALYST

				handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
                handler.PlatformView.Layer.BorderWidth = 0;
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;


#elif WINDOWS
				
				handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);


#endif

            }
        });
	}
}
