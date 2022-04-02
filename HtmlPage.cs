namespace HtmlBuilder
{
    public class HtmlPage
    {
        public string Title;
        public string Header;
        public string Paragraph;
        public string Image;
        public string PageSeparator;

        public override string ToString()
        {
            var template = $"<!DOCTYPE html>\n" +
                $"<html lang=\"en\">\n\t" +
                $"<head>\n\t\t" +
                $"<title>{Title}</title>\n\t\t" +
                $"<link rel=\"stylesheet\" href=\"style.css\">\n\t" +
                $"</head>\n\t" +
                $"<body>\n\t\t" +
                $"<h1>{Header}</h1>\n\t\t" +
                $"<p>{Paragraph}</p>\n\t\t" +
                $"<img src=\"{Image}\" alt=\"some alt text\">\n\t\t" +
                $"<script src=\"{PageSeparator}\"></script>\n\t" +
                $"</body>\n" +
                $"</html>";

            return template;
        }
    }
}
