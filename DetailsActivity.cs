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
            var offerJson = Intent.GetStringExtra("OFFER_JSON");

            var offerJsonTextView = FindViewById<TextView>(Resource.Id.textViewOfferJson);
            offerJsonTextView.Text = offerJson;
        }
    }
}