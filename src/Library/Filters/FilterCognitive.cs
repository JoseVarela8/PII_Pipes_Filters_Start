
using System;
using System.Drawing;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FilterCognitive : IFilterConditional
    {        public Boolean Filter(IPicture picture)
        {
            PictureProvider provider = new PictureProvider();
            provider.SavePicture(picture, @"picture_Aux.jpg"); //para recibir una IPicture y usarla en CognitiveFace

            CognitiveFace cog = new CognitiveFace(true, Color.GreenYellow);
            cog.Recognize(@"picture_Aux.jpg");
            return cog.FaceFound;
        }
    }
}