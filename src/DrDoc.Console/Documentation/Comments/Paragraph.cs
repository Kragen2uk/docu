using DrDoc.Documentation.Comments;

namespace DrDoc.Documentation.Comments
{
    public class Paragraph : IComment
    {
        public Paragraph(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}