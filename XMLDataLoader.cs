using Android.Util;
using Offers.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

                    var nodeId = nodeItem.Attributes["id"].Value;
                    var nodeType = nodeItem.Attributes["type"].Value;
                    var nodeBid = nodeItem.Attributes["bid"].Value;
                    var nodeAvailable = nodeItem.Attributes["available"].Value;

                    var nodeUrl = nodeItem.SelectSingleNode("url").InnerText;
                    var nodePrice = nodeItem.SelectSingleNode("price").InnerText;
                    var nodeCurrencyId = nodeItem.SelectSingleNode("currencyId").InnerText;
                    var nodeCategoryIdType = nodeItem.SelectSingleNode("categoryId").Attributes["type"].Value;
                    var nodeCategoryId = nodeItem.SelectSingleNode("categoryId").InnerText;
                    var nodePicture = nodeItem.SelectSingleNode("picture").InnerText;
                    var nodeDescription = nodeItem.SelectSingleNode("description").InnerText;

                    switch (nodeType.ToString())
                    {
                        case "vendor.model":
                            offerClasses.Add(new VendorModel
                            {
                                Id = nodeId,
                                OfferType = nodeType,
                                Bid = nodeBid,
                                Cbid = nodeItem.Attributes["cbid"].Value,
                                Available = nodeAvailable,
                                Url = nodeUrl,
                                Price = nodePrice,
                                CurrencyId = nodeCurrencyId,
                                CategoryIdType = nodeCategoryIdType,
                                CategoryId = nodeCategoryId,
                                Picture = nodePicture,
                                Description = nodeDescription,
                                Delivery = nodeItem.SelectSingleNode("delivery").InnerText,
                                LocalDeliveryCost = nodeItem.SelectSingleNode("local_delivery_cost").InnerText,
                                TypePrefix = nodeItem.SelectSingleNode("typePrefix").InnerText,
                                Vendor = nodeItem.SelectSingleNode("vendor").InnerText,
                                VendorCode = nodeItem.SelectSingleNode("vendorCode").InnerText,
                                Model = nodeItem.SelectSingleNode("model").InnerText
                            });
                            break;
                        case "book":
                            offerClasses.Add(new Book
                            {
                                Id = nodeId,
                                OfferType = nodeType,
                                Bid = nodeBid,
                                Available = nodeAvailable,
                                Url = nodeUrl,
                                Price = nodePrice,
                                CurrencyId = nodeCurrencyId,
                                CategoryIdType = nodeCategoryIdType,
                                CategoryId = nodeCategoryId,
                                Picture = nodePicture,
                                Description = nodeDescription,
                                Delivery = nodeItem.SelectSingleNode("delivery").InnerText,
                                LocalDeliveryCost = nodeItem.SelectSingleNode("local_delivery_cost").InnerText,
                                Author = nodeItem.SelectSingleNode("author").InnerText,
                                Name = nodeItem.SelectSingleNode("name").InnerText,
                                Publisher = nodeItem.SelectSingleNode("publisher").InnerText,
                                Series = nodeItem.SelectSingleNode("series").InnerText,
                                Year = nodeItem.SelectSingleNode("year").InnerText,
                                ISBN = nodeItem.SelectSingleNode("ISBN").InnerText,
                                Volume = nodeItem.SelectSingleNode("volume").InnerText,
                                Part = nodeItem.SelectSingleNode("part").InnerText,
                                Language = nodeItem.SelectSingleNode("language").InnerText,
                                Binding = nodeItem.SelectSingleNode("binding").InnerText,
                                PageExtent = nodeItem.SelectSingleNode("page_extent").InnerText,
                                Downloadable = nodeItem.SelectSingleNode("downloadable").InnerText
                            });
                            break;
                        case "audiobook":
                            offerClasses.Add(new Audiobook
                            {
                                Id = nodeId,
                                OfferType = nodeType,
                                Bid = nodeBid,
                                Available = nodeAvailable,
                                Url = nodeUrl,
                                Price = nodePrice,
                                CurrencyId = nodeCurrencyId,
                                CategoryIdType = nodeCategoryIdType,
                                CategoryId = nodeCategoryId,
                                Picture = nodePicture,
                                Description = nodeDescription,
                                Author = nodeItem.SelectSingleNode("author").InnerText,
                                Name = nodeItem.SelectSingleNode("name").InnerText,
                                Publisher = nodeItem.SelectSingleNode("publisher").InnerText,
                                Year = nodeItem.SelectSingleNode("year").InnerText,
                                ISBN = nodeItem.SelectSingleNode("ISBN").InnerText,
                                Language = nodeItem.SelectSingleNode("language").InnerText,
                                PerformedBy = nodeItem.SelectSingleNode("performed_by").InnerText,
                                PerformanceType = nodeItem.SelectSingleNode("performance_type").InnerText,
                                Storage = nodeItem.SelectSingleNode("storage").InnerText,
                                Format = nodeItem.SelectSingleNode("format").InnerText,
                                RecordingLength = nodeItem.SelectSingleNode("recording_length").InnerText,
                                Downloadable = nodeItem.SelectSingleNode("downloadable").InnerText
                            });
                            break;
                        case "artist.title":
                            var nodeMedia = nodeItem.SelectSingleNode("media").InnerText;

                            if (nodeMedia == "CD")
                            {
                                offerClasses.Add(new ArtistTitleCD
                                {
                                    Id = nodeId,
                                    OfferType = nodeType,
                                    Bid = nodeBid,
                                    Available = nodeAvailable,
                                    Url = nodeUrl,
                                    Price = nodePrice,
                                    CurrencyId = nodeCurrencyId,
                                    CategoryIdType = nodeCategoryIdType,
                                    CategoryId = nodeCategoryId,
                                    Picture = nodePicture,
                                    Description = nodeDescription,
                                    Delivery = nodeItem.SelectSingleNode("delivery").InnerText,
                                    Artist = nodeItem.SelectSingleNode("artist").InnerText,
                                    Title = nodeItem.SelectSingleNode("title").InnerText,
                                    Year = nodeItem.SelectSingleNode("year").InnerText,
                                    Media = nodeItem.SelectSingleNode("media").InnerText
                                });

                            }
                            else if (nodeMedia == "DVD")
                            {
                                offerClasses.Add(new ArtistTitleDVD
                                {
                                    Id = nodeId,
                                    OfferType = nodeType,
                                    Bid = nodeBid,
                                    Available = nodeAvailable,
                                    Url = nodeUrl,
                                    Price = nodePrice,
                                    CurrencyId = nodeCurrencyId,
                                    CategoryIdType = nodeCategoryIdType,
                                    CategoryId = nodeCategoryId,
                                    Picture = nodePicture,
                                    Description = nodeDescription,
                                    Delivery = nodeItem.SelectSingleNode("delivery").InnerText,
                                    Title = nodeItem.SelectSingleNode("title").InnerText,
                                    Year = nodeItem.SelectSingleNode("year").InnerText,
                                    Media = nodeItem.SelectSingleNode("media").InnerText,
                                    Starring = nodeItem.SelectSingleNode("starring").InnerText,
                                    Director = nodeItem.SelectSingleNode("director").InnerText,
                                    OriginalName = nodeItem.SelectSingleNode("originalName").InnerText,
                                    Country = nodeItem.SelectSingleNode("country").InnerText
                                });
                            }
                            break;
                        case "tour":
                            offerClasses.Add(new Tour
                            {
                                Id = nodeId,
                                OfferType = nodeType,
                                Bid = nodeBid,
                                Available = nodeAvailable,
                                Url = nodeUrl,
                                Price = nodePrice,
                                CurrencyId = nodeCurrencyId,
                                CategoryIdType = nodeCategoryIdType,
                                CategoryId = nodeCategoryId,
                                Picture = nodePicture,
                                Description = nodeDescription,
                                Delivery = nodeItem.SelectSingleNode("delivery").InnerText,
                                LocalDeliveryCost = nodeItem.SelectSingleNode("local_delivery_cost").InnerText,
                                WorldRegion = nodeItem.SelectSingleNode("worldRegion").InnerText,
                                Country = nodeItem.SelectSingleNode("country").InnerText,
                                Region = nodeItem.SelectSingleNode("region").InnerText,
                                Days = nodeItem.SelectSingleNode("days").InnerText,
                                DataTourBegin = nodeItem.SelectNodes("dataTour").Item(0).InnerText,
                                DataTourEnd = nodeItem.SelectNodes("dataTour").Item(1).InnerText,
                                Name = nodeItem.SelectSingleNode("name").InnerText,
                                HotelStars = nodeItem.SelectSingleNode("hotel_stars").InnerText,
                                Room = nodeItem.SelectSingleNode("room").InnerText,
                                Meal = nodeItem.SelectSingleNode("meal").InnerText,
                                Included = nodeItem.SelectSingleNode("included").InnerText,
                                Transport = nodeItem.SelectSingleNode("transport").InnerText
                            });
                            break;
                        case "event-ticket":
                            offerClasses.Add(new EventTicket
                            {
                                Id = nodeId,
                                OfferType = nodeType,
                                Bid = nodeBid,
                                Available = nodeAvailable,
                                Url = nodeUrl,
                                Price = nodePrice,
                                CurrencyId = nodeCurrencyId,
                                CategoryIdType = nodeCategoryIdType,
                                CategoryId = nodeCategoryId,
                                Picture = nodePicture,
                                Description = nodeDescription,
                                Delivery = nodeItem.SelectSingleNode("delivery").InnerText,
                                LocalDeliveryCost = nodeItem.SelectSingleNode("local_delivery_cost").InnerText,
                                Name = nodeItem.SelectSingleNode("name").InnerText,
                                Place = nodeItem.SelectSingleNode("place").InnerText,
                                Hall = nodeItem.SelectSingleNode("hall").InnerText,
                                HallPlan = nodeItem.SelectSingleNode("hall").Attributes["plan"].Value,
                                HallPart = nodeItem.SelectSingleNode("hall_part").InnerText,
                                Date = nodeItem.SelectSingleNode("date").InnerText,
                                IsPremiere = nodeItem.SelectSingleNode("is_premiere").InnerText,
                                IsKids = nodeItem.SelectSingleNode("is_kids").InnerText
                            });
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