using System;
using TwitterUCU;

namespace CompAndDel.Filters
{
    // Es un filtro que recibe una imagen, la publica en twitter y devuelve dicha imagen.
   
    public class FilterTwitter : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            PublicarTwitter(image);
            return image;
        }
        async private void PublicarTwitter(IPicture image)
        {
            TwitterImage twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("JoseVarela", @"result.jpg"));

        }
    }
}