
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;

namespace CompAndDel.Pipes
{
    public class PipeCognitive : IPipeConditional
    {
        protected IFilterConditional filtro;
        protected IPipe nextPipeA;
        protected IPipe nextPipeB;


        // El Pipe recibe una imagen, le aplica un filtro y la envía a la siguiente pipe

        public PipeCognitive(IFilterConditional filtro, IPipe nextPipeA, IPipe nextPipeB)
        {
            this.nextPipeA = nextPipeA;
            this.nextPipeB = nextPipeB;

            this.filtro = filtro;
        }

        // Devuelve el proximo IPipe

        public IPipe NextA
        {
            get { return this.nextPipeA; }
        }
        public IPipe NextB
        {
            get { return this.nextPipeB; }
        }
        // Devuelve el IFilterCondition que aplica este pipe

        public IFilterConditional Filter
        {
            get { return this.filtro; }
        }
        // Recibe una imagen, le aplica un filtro y la envía al siguiente Pipe

        public IPicture Send(IPicture picture)
        {

            Boolean condicion = this.filtro.Filter(picture);
            Console.WriteLine(">>>> " + condicion);
            if (condicion)
            {
                return this.nextPipeA.Send(picture);
            }
            else
            {
                return this.nextPipeB.Send(picture);
            }
        }
    }
}