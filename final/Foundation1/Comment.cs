public class Comment
{
    private string commenters_name;
    private string text;

    public Comment(string commenters_name, string text)
    {
        this.commenters_name = commenters_name;
        this.text = text;
    }

    public override string ToString()
    {
            return $"{commenters_name}: {text}";
    }
}