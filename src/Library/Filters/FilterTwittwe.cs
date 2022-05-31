using TwitterUCU;
using System;
namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que publica una imagen en la cuenta de twitter POO UCU.
    /// </summary>
    public class FilterTwitter : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            TwitterImage twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("condicional1", @"filteredpicture.jpg"));
            return image;
        }

    }
}