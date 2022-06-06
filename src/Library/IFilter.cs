using System;

namespace CompAndDel
{

    // Un filtro que recibe, procesa y retorna imágenes. El filtro puede retornar la misma imagen o una nueva imagen
    // afectada por el filtro en cuestión.
    public interface IFilter
    {
        IPicture Filter(IPicture image);
    }
}
