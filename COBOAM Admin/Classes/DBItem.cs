namespace COBOAM_Admin.Classes
{
    public class DBItem
    {
        public string Text { private get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

    }
}