using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace CDIS.Clients
{
    public static class ClientExtensions
    {
        public static ImageSource GetImageSource(this Client client)
        {
            return ImageSource.FromResource(client.ImageUrl);
        }
    }
}
