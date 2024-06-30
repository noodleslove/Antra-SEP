using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Director
    {
        private IBuilder? _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            if (_builder is null)
            {
                throw new NullReferenceException("Builder is not set");
            }

            _builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            if (_builder is null)
            {
                throw new NullReferenceException("Builder is not set");
            }

            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }
}