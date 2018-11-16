namespace ConsoleApp2
{
    public class Request
    {
        public string RequestGuid { get; set; }
        public string PackageId { get; set; }
        public int PackageVersion { get; set; }
        public int ResponseVersion { get; set; }
        public Datakeys DataKeys { get; set; }
    }
}