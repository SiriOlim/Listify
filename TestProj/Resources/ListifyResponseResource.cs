namespace TestProj.Resources
{
    public class ListifyResponseResource
    {
        public int BegRange { get; set; }
        public int EndRange { get; set; }
        public int Index { get; set; }
        public int Value { get; set; }
        public List<int>? Listified { get; set; }
    }
}
