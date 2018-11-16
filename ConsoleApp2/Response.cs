namespace ConsoleApp2
{
    public class Response
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public Statusinformation StatusInformation { get; set; }
        public Dataitems DataItems { get; set; }
    }
}