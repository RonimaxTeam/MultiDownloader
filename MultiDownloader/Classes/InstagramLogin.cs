using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;

namespace MultiDownloader.Classes
{
    public class InstagramLogin
    {
        public static IInstaApi InstaApi { get; set; }
        public static IResult<InstaLoginResult> InstagramLoginResult { get; set; }


        public static async Task Login(string username, string password)
        {
            var userSession = new UserSessionData
            {
                UserName = username,
                Password = password,
            };

            InstaApi = InstaApiBuilder.CreateBuilder()
                .SetUser(userSession)
                .UseLogger(new DebugLogger(LogLevel.All))
                .Build();

            InstagramLoginResult = await InstaApi.LoginAsync();
        }
    }
}
