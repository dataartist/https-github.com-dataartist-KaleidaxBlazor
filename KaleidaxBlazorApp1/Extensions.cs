using System.Collections.Generic;

namespace KaleidaxBlazorApp1
{
    public static class Extensions
    {
        public static string ToggleImage(this string image, bool forceOff = false)
        {
            return image.IndexOf("Selected") >= 0 || forceOff ? image.Replace("Selected", "") : image.Replace(".", "Selected.");
        }

        public static List<Scope> ToScopes(this ImagePath[] images)
        {
            var scopes = new List<Scope>();

            foreach (var i in images)
            {
                scopes.Add(new Scope { ImageUrl = i.ImageUrl, AudioUrl = i.AudioUrl });
            }
            return scopes;
        }
    }
}