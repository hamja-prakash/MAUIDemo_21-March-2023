namespace MAUISampleDemo.Model
{
    public class Schedule
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Hour { get; set; }
        public List<Features> Features { get; set; }
    }

    public class Features
    {
        public string Name { get; set; }
        public Color BGColor { get; set; }
        public Color TxColor { get; set; }
    }
}
