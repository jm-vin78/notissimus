using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Offers
{
    [Activity(Label = "DetailsActivity")]
    internal class DetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_details);
            var itemId = Intent.GetStringExtra("ITEM_ID");

            var itemIdTextView = FindViewById<TextView>(Resource.Id.textViewItemId);
            itemIdTextView.Text = itemId;
        }
    }
}