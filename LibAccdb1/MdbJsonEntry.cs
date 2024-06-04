namespace LibAccdb1
{
    public class MdbJsonEntry
    {
        public long Id { get; set; }
        public long ParentId { get; set; }
        public int Type { get; set; }
        public string? Name { get; set; }
        public JetBlob? Lv { get; set; }
    }
}
