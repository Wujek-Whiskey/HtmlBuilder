namespace HtmlBuilder
{
    public class HtmlPageBuilder
    {
        private readonly HtmlPage _htmlpage = new HtmlPage();

        public HtmlPageBuilder WithTitle(string title)
        {
            _htmlpage.Title = title;
            return this;
        }

        public HtmlPageBuilder AppendHeader(string header)
        {
            _htmlpage.Header = header;
            return this;
        }

        public HtmlPageBuilder AppendParagraph(string paragraph)
        {
            _htmlpage.Paragraph = paragraph;
            return this;
        }

        public HtmlPageBuilder AppendImage(string image)
        {
            _htmlpage.Image = image;
            return this;
        }

        public HtmlPageBuilder AppendPageSeparator(string pageSeparator)
        {
            _htmlpage.PageSeparator = pageSeparator;
            return this;
        }

        public HtmlPage Build()
        {
            return _htmlpage;
        }
    }
}
