
using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    public class FilterSave : IFilter
    {
        // Un filtro que guarda y retorna la imagen recibida.
        public IPicture Filter(IPicture image)
        {
            PictureProvider provider = new PictureProvider();
            provider.SavePicture(image, @"result.jpg");
            return image;
        }
    }
}