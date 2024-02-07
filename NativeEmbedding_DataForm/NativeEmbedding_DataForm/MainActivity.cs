using Microsoft.Maui.Embedding;
using Android.App;
using Android.OS;
using Syncfusion.Maui.DataForm;
using Microsoft.Maui.Platform;
using Syncfusion.Maui.Core.Hosting;

namespace NativeEmbedding_DataForm
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        MauiContext? _mauiContext;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            MauiAppBuilder builder = MauiApp.CreateBuilder();
            builder.UseMauiEmbedding<Microsoft.Maui.Controls.Application>();
            builder.ConfigureSyncfusionCore();
            MauiApp mauiApp = builder.Build();
            _mauiContext = new MauiContext(mauiApp.Services, this);

            SfDataForm dataForm = new SfDataForm()
            {
                DataObject = new DataFormModel()
            };
            Android.Views.View view = dataForm.ToPlatform(_mauiContext);

            SetContentView(view);
        }
    }
}