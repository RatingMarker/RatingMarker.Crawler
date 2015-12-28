using System.IO;

namespace RatingMarker.Crawler.Workflow.FileSystem
{
    public class ConvertFileToString
    {
        public string GetContent(byte[] bytes)
        {
            string text;

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                StreamReader reader = new StreamReader(memoryStream);

                text = reader.ReadToEnd();
            }

            return text;
        }
    }
}