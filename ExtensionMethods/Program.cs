using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "blah something else then I spoke to somebody else and blah blah";

            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
        }

    }
}
