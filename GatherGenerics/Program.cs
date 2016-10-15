using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatherGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var foo = new List<IParser<BaseValue>>();
            foo.Add(new ParserTypeA());
            foo.Add(new ParserTypeB());
        }
    }

    public class BaseValue
    {
        // some content
    }

    public class ValueTypeA : BaseValue
    {
        // some content
    }

    public class ValueTypeB : BaseValue
    {
        // some content
    }

    public class ParserTypeA : ValueTypeA
    {
        public ValueTypeA Parse(string value) { return new ValueTypeA(); }
    }

    public class ParserTypeB : ValueTypeB
    {
        public ValueTypeB Parse(string value) { return new ValueTypeB(); }
    }

    interface IParser<T>
    {
        BaseValue Parse(string value);
    }
}
