using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Newtonsoft.Json;
using Offers.Models;

namespace Offers
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    internal class MainActivity : AppCompatActivity
    {
        private ArrayAdapter<string> _adapter;
        private List<OfferBase> _offerClasses;
        private bool isProcessing;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            var listView = FindViewById<ListView>(Resource.Id.myListView);
            _adapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, new List<string>());
            listView.Adapter = _adapter;
            listView.TextFilterEnabled = true;
            listView.ItemClick += OnListItemClick;

            Task.Run(LoadDataFromXML);
        }

        protected override void OnResume()
        {
            base.OnResume();
            isProcessing = false;
        }

        private void OnListItemClick(object sender, AdapterView.ItemClickEventArgs args)
        {
            if (!isProcessing)
            {
                isProcessing = true;
                var intent = new Intent(this, typeof(DetailsActivity));
                var itemId = ((TextView)args.View).Text;
                var item = _offerClasses.SingleOrDefault(x => x.Id == itemId);
                var itemJson = JsonConvert.SerializeObject(item, Newtonsoft.Json.Formatting.Indented);
                intent.PutExtra("ITEM_ID", itemJson);
                StartActivity(intent);
            }
        }

        public void LoadDataFromXML()
        {
            var dataLoader = new XMLDataLoader();
            _offerClasses = dataLoader.LoadDataFromXML();

            Handler handler = new Handler(Looper.MainLooper);
            handler.Post(() =>
            {
                _adapter.Clear();
                foreach (var elem in _offerClasses)
                {
                    _adapter.Add(elem.Id);
                }
                _adapter.NotifyDataSetChanged();
            });
        }
    }
}
