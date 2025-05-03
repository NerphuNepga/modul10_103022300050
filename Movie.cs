namespace modul10_103022300050
{
    public class Movies
    {
        public string Title {  get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }

        public Movies(string title, string director, List<string> stars, string description)
        {
            this.Title = title;
            this.Director = director;
            this.Stars = stars;
            this.Description = description;
        }
    }
}
