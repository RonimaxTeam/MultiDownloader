using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Caliburn.Micro;
using CustomAlertBoxDemo;
using MultiDownloader.Classes;
using MultiDownloader.Views;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace MultiDownloader.ViewModels
{
    public partial class InstagramAndYouTubeInformationProductViewModel : Screen
    {

        public InstagramAndYouTubeInformationProductViewModel()
        {
            InitializeComponent();
            Task.Run(() => GetInformationFromInputURL());
        }

        #region Methods

        public void ButtonStart()
        {

        }

        public void ButtonBack()
        {

        }

        public async Task GetInformationFromInputURL()
        {
            if (string.Equals(ProductStatus, "Instagram"))
            {
               await GetInformationFromInstagram();
            }
            else if (string.Equals(ProductStatus, "Youtube"))
            {
               await GetInformationFromYoutube();
            }
        }

        public async Task GetInformationFromInstagram()
        {
                Uri uri = new Uri(InputURL);

                try
                {
                    var mediaid = await InstagramLogin.InstaApi.MediaProcessor.GetMediaIdFromUrlAsync(uri);
                    var media = await InstagramLogin.InstaApi.MediaProcessor.GetMediaByIdsAsync(mediaid.Value);
                    string mediatype = media.Value[0].MediaType.ToString();

                    try
                    {
                        //get Author and page name information
                        System.Windows.Application.Current.Dispatcher.Invoke(delegate
                        {

                            TextBlockAuthorInformationText = media.Value[0].User.UserName;
                            TextBlockPageNameInformationText = media.Value[0].User.UserName;
                        });

                        //get link download as property IGTV
                        if (media.Value[0].ProductType == "igtv")
                        {
                            LinkDownloadSingleMedia = media.Value[0].Videos[0].Uri.ToString();
                            System.Windows.Application.Current.Dispatcher.Invoke(delegate
                            {

                                TextBlockMediaTypeInformationText = $"IGTV  (  {(media.Value[0].VideoDuration / 60).ToString("##")}  )  Minutes";
                            });
                        }
                        else
                        {
                            switch (mediatype)
                            {
                                //get link download Single Video
                                case "Video":
                                    LinkDownloadSingleMedia = media.Value[0].Videos[0].Uri.ToString();
                                    System.Windows.Application.Current.Dispatcher.Invoke(delegate
                                    {

                                        TextBlockMediaTypeInformationText = $"Video  ( {media.Value[0].VideoDuration.ToString("##")} )  Seconds";
                                    });

                                    break;

                                //get link download Single Image
                                case "Image":
                                    LinkDownloadSingleMedia = media.Value[0].Images[0].Uri.ToString();
                                    System.Windows.Application.Current.Dispatcher.Invoke(delegate
                                    {

                                        TextBlockMediaTypeInformationText = "Image";
                                    });

                                    break;

                                case "Carousel":

                                    for (int i = 0; i < media.Value[0].Carousel.Count; i++)
                                    {

                                        if (media.Value[0].Carousel[i].MediaType.ToString() == "Image")
                                        {

                                            LinkDownloadMultiPageMedia.Add(media.Value[0].Carousel[i].Images[0].Uri.ToString());
                                            System.Windows.Application.Current.Dispatcher.Invoke(delegate
                                            {

                                                TextBlockMediaTypeInformationText = "Multi Page";
                                                ComboBoxItems.Add(new ComboBoxItem() { Slide = $"Slide ({i + 1}) - ", ProductTypeAndProductTime = "Type : ( Image )", ComboBoxImageItem = "../Resource/ImageDark.png" });
                                                ComboBoxVisibility = "Visible";
                                            });
                                        }
                                        else
                                        {
                                            LinkDownloadMultiPageMedia.Add(media.Value[0].Carousel[i].Videos[0].Uri.ToString());
                                            System.Windows.Application.Current.Dispatcher.Invoke(delegate
                                            {

                                                TextBlockMediaTypeInformationText = "Multi Page";
                                                ComboBoxItems.Add(new ComboBoxItem() { Slide = $"Slide ({i + 1}) - ", ProductTypeAndProductTime = "Type : ( Video )", ComboBoxImageItem = "../Resource/VideoDark.png" });
                                                ComboBoxVisibility = "Visible";
                                            });
                                        }
                                    }

                                    ComboBoxText = "The Pages added";
                                    break;
                            }
                        }
                    }
                    catch
                    {
                        Alert.Show("Unknown error", Form_Alert.enmType.Error);
                    }
                }
                catch
                {
                    Alert.Show("Can not connect in the server", Form_Alert.enmType.Error);
                }
            
        }

        //Not Completed
        public async Task GetInformationFromYoutube()
        {


        }

        #endregion
    }
}
