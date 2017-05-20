namespace BootstrapModalPartialViewCore.Models
{
    public class CloseModal
    {
        public bool ShouldClose { get; set; }
        public bool FetchData { get; set; }
        public string Destination { get; set; }
        public string Target { get; set; }
        public string OnSuccess { get; set; }
    }
}
