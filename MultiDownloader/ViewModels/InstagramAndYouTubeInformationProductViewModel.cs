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
using System.Windows;
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
                                            ComboBoxItems.Add(new ComboBoxItem() { SlideOrProductType = $"Slide ({i + 1}) - ", ProductTypeAndProductTimeOrQuality = "Type : ( Image )", ComboBoxImageItem = "../Resource/ImageDark.png" });
                                            ComboBoxVisibility = "Visible";
                                        });
                                    }
                                    else
                                    {
                                        LinkDownloadMultiPageMedia.Add(media.Value[0].Carousel[i].Videos[0].Uri.ToString());
                                        System.Windows.Application.Current.Dispatcher.Invoke(delegate
                                        {

                                            TextBlockMediaTypeInformationText = "Multi Page";
                                            ComboBoxItems.Add(new ComboBoxItem() { SlideOrProductType = $"Slide ({i + 1}) - ", ProductTypeAndProductTimeOrQuality = "Type : ( Video )", ComboBoxImageItem = "../Resource/VideoDark.png" });
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
            try
            {
                var getvideo = await YoutubeClient.Videos.GetAsync(InputURL);
                var INFO = await YoutubeClient.Videos.Streams.GetManifestAsync(InputURL);
                //actully,author and page name is same shit ,so i put title instead pagename))
                TextBlockAuthorInformationText = getvideo.Author.ToString().ToLower();
                TextBlockPageNameInformationText = getvideo.Title;
                
                if (getvideo != null && INFO != null)
                {
                    //alert loading or somthing
                    Application.Current.Dispatcher.Invoke(delegate { Alert.Show("Load", Form_Alert.enmType.Progress); });
                    try
                    {
                        var mux = INFO.GetMuxed().ToArray();
                        var audio = INFO.GetAudioOnly().ToArray();
                        var video = INFO.GetVideoOnly().ToArray();
                        //list mux 
                        if (mux != null)
                        {
                            //list mux
                            for (int ien = 0; ien < mux.Length; ien++)
                            {
                                Application.Current.Dispatcher.Invoke(delegate { ComboBoxItems.Add(new ComboBoxItem() { SlideOrProductType = "MixMode -", ProductTypeAndProductTimeOrQuality = $"({mux[ien].VideoQualityLabel})", Size = mux[ien].Size.ToString(), ComboBoxImageItem = "../Resource/VideoDark.png", }); });
                            }
                        }
                        else { return; }

                        if (audio != null)
                        { // need some emage for audio))
                            //list audio
                            for (int len = 0; len < audio.Length; len++)
                            {
                                Application.Current.Dispatcher.Invoke(delegate { ComboBoxItems.Add(new ComboBoxItem() { SlideOrProductType = "Audio Only -", ProductTypeAndProductTimeOrQuality = $"({audio[len].AudioCodec})", Size = audio[len].Size.ToString(), ComboBoxImageItem = "" }); });
                            }
                        }
                        else { return; }
                        if (video != null)
                        {
                            //list video
                            for (int ven = 0; ven < video.Length; ven++)
                            {
                                Application.Current.Dispatcher.Invoke(delegate { ComboBoxItems.Add(new ComboBoxItem() { SlideOrProductType = "Video Only -", ProductTypeAndProductTimeOrQuality = $"({video[ven].VideoQualityLabel})", Size = video[ven].Size.ToString(), ComboBoxImageItem = "../Resource/VideoDark.png" }); });
                            }
                        }
                        if (ComboBoxItems.Count > 1) { ComboBoxVisibility = "Visible"; }
                        Application.Current.Dispatcher.Invoke(delegate { Alert.Show("Success", Form_Alert.enmType.Success); });
                    }
                    catch (Exception z)
                    {//delete after debug
                        Application.Current.Dispatcher.Invoke(delegate { Alert.Show(z.Message.ToString() + "|" + z.StackTrace.ToString(), Form_Alert.enmType.Error); });
                        return;
                    }
                }//delete after debug
                else { Application.Current.Dispatcher.Invoke(delegate { Alert.Show("getvideo,info null", Form_Alert.enmType.Error); }); }

                TextBlockMediaTypeInformationText = "Video";
            }
            catch (Exception x)
            {
                //delete after debug
                Application.Current.Dispatcher.Invoke(delegate { Alert.Show(x.Message.ToString() + "|" + x.StackTrace.ToString(), Form_Alert.enmType.Error); }); 
                throw;
            }
        }


        #endregion
    }
}
