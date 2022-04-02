using System;

namespace HtmlBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var htmlPageBuilder = new HtmlPageBuilder();

            var htmlPage = htmlPageBuilder.WithTitle("Tytul")
                                          .AppendHeader("Naglowek")
                                          .AppendParagraph("Paragraf")
                                          .AppendImage("obrazek.png")
                                          .AppendPageSeparator("main.js")
                                          .Build();

            Console.WriteLine(htmlPage);
        }
    }
}
