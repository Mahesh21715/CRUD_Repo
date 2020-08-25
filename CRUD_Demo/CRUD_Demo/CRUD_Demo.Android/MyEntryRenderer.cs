using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CRUD_Demo.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]
namespace CRUD_Demo.Droid
{
    public class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }

        [Obsolete]
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.SetBackgroundColor(global::Android.Graphics.Color.Gray);
                //Control.SetHeight(10);

                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.LightGray);
                gd.SetCornerRadius(15);
                //gd.SetStroke(2, global::Android.Graphics.Color.LightGray);
                Control.SetBackgroundDrawable(gd);

            }
            
        }
    }
}