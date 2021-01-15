namespace WebApplicationTest.Infrastructure
{
    public class Utility : object
    {
        public Utility() : base()
        { 
        }

        //public string FixText(string text)
        //{
        //    return text;
        //}

        //public string FixText(string text)
        //{
        //    if(text == null)
        //    {
        //        return string.Empty;
        //    }

        //    return text;
        //}

        //public string FixText(string text)
        //{
        //    if (text == null)
        //    {
        //        return string.Empty;
        //    }

        //    text =
        //        text.Trim();

        //    return text;
        //}

        //public string FixText(string text)
        //{
        //    if (text == null)
        //    {
        //        return string.Empty;
        //    }

        //    text =
        //        text.Trim();

        //    text =
        //        text.Replace("  " , " ");

        //    return text;
        //}

        public string FixText(string text)
        {
            if (text == null)
            {
                return string.Empty;
            }

            text =
                text.Trim();

            while(text.Contains("  "))
            {
                text =
                    text.Replace("  ", " ");
            }

            return text;
        }
    }
}
