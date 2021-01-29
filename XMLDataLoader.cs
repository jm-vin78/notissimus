using Android.Util;
using Offers.Models;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Offers
{
    internal class XMLDataLoader
    {
        public List<OfferBase> LoadDataFromXML()
        {
            XmlDocument xmlDoc = new XmlDocument();
            var offerClasses = new List<OfferBase>();

            try
            {
                xmlDoc.Load("http://partner.market.yandex.ru/pages/help/YML.xml");

                for (var i = 0; i < xmlDoc.SelectNodes("//offer").Count; i++)
                {
                    var nodeItem = xmlDoc.SelectNodes("//offer").Item(i);
                    var nodeType = nodeItem.Attributes["type"].Value;

                    switch (nodeType.ToString())
                    {
                        case "vendor.model":
                            offerClasses.Add(new VendorModel(nodeItem, nodeType));
                            break;
                        case "book":
                            offerClasses.Add(new Book(nodeItem, nodeType));
                            break;
                        case "audiobook":
                            offerClasses.Add(new Audiobook(nodeItem, nodeType));
                            break;
                        case "artist.title":
                            var nodeMedia = nodeItem.SelectSingleNode("media").InnerText;

                            if (nodeMedia == "CD")
                            {
                                offerClasses.Add(new ArtistTitleCD(nodeItem, nodeType));
                            }
                            else if (nodeMedia == "DVD")
                            {
                                offerClasses.Add(new ArtistTitleDVD(nodeItem, nodeType));
                            }
                            break;
                        case "tour":
                            offerClasses.Add(new Tour(nodeItem, nodeType));
                            break;
                        case "event-ticket":
                            offerClasses.Add(new EventTicket(nodeItem, nodeType));
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error("LoadDataFromXML", e.Message);
            }

            return offerClasses;
        }
    }
}