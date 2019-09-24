using System;

namespace Lib
{
    public abstract class Class1<T>
    {
        public Class1()
        {
            var dispossable = new System.IO.StreamWriter("file.txt", append: true);
            dispossable.WriteLineAsync();
        }

        public static T SomeProperty { get; set; }

        public static T SomeField;
    }
}
