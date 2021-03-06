
   
using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Parte 1 y 2

            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");

            PipeNull pipeNull = new PipeNull();

            //Filtro para guardar en cualquiera de sus pasos intermedios
            IFilter filterSave = new FilterSave();
            IPipe pipeserial3 = new PipeSerial(filterSave, pipeNull);

            IFilter filterNegative = new FilterNegative();
            IPipe pipeSerial2 = new PipeSerial(filterNegative, pipeserial3);

            IFilter filterGreyscale = new FilterGreyscale();
            IPipe pipeSerial1 = new PipeSerial(filterGreyscale, pipeSerial2);

            IPicture result = pipeSerial1.Send(picture);



/*
            //Parte 3: (publicar en twitter)

            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");

            PipeNull pipeNull = new PipeNull();

            IFilter filterTwitter = new FilterTwitter();
            IPipe pipeserial4 = new PipeSerial(filterTwitter, pipeNull);

            IFilter filterSave = new FilterSave();
            IPipe pipeserial3 = new PipeSerial(filterSave, pipeserial4);

            IFilter filterNegative = new FilterNegative();
            IPipe pipeSerial2 = new PipeSerial(filterNegative, pipeserial3);

            IFilter filterGreyscale = new FilterGreyscale();
            IPipe pipeSerial1 = new PipeSerial(filterGreyscale, pipeSerial2);

            IPicture result = pipeSerial1.Send(picture);
*/

/*
            //Parte 4 (comprobar si tiene cara)

            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");

            PipeNull pipeNull = new PipeNull();

            //Si la imagen tiene cara
            IFilter filterSave = new FilterSave();
            IPipe pipeserial1 = new PipeSerial(filterSave, pipeNull);

            //Si la imagen no tiene cara 
            IFilter filterSave1 = new FilterSave();
            IPipe pipeserial4 = new PipeSerial(filterSave1, pipeserial1);

            IFilter filterNegative = new FilterNegative();
            IPipe pipeserial3 = new PipeSerial(filterNegative, pipeserial4);

            IFilter filterGrey = new FilterGreyscale();
            IPipe pipeserial2 = new PipeSerial(filterGrey, pipeserial3);

            IPipe pipeA = new PipeSerial(filterSave, pipeserial1); 
            IPipe pipeB = new PipeSerial(filterGrey, pipeserial2); 

            IFilterConditional filterConditional = new FilterCognitive();
            IPipeConditional pipeConditional = new PipeCognitive(filterConditional, pipeA, pipeB);

            IPicture result = pipeConditional.Send(picture);
        }
*/

    }
    }
}