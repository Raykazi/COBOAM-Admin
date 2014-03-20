namespace COBOAM_Admin.Classes
{
    abstract class Resource
    {
        public static string Format(string resource, params object[] args)
        {
            if (args.Length <= 0) return resource;
            resource = string.Format(resource, args);
            return resource;
        }
    }
}
