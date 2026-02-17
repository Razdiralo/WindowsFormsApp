namespace WindowsFormsApp3
{
    public class CommandItem
    {
        public string Name { get; set; } = "";

        public bool IsChecked { get; set; }

        public override string ToString() => Name;
    }
}