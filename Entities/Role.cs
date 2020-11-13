namespace vectorBackend.Entities
{
    public class Role
    {
        public int Id { get; set; }

        public string Key { get; set; }
        

        public static Role User = new Role { Id = 1, Key = Keys.User };
        public static Role Admin = new Role { Id = 2, Key = Keys.Admin };

        public static class Keys
        {
            public const string Admin = "admin";
            public const string User = "user";
        }
    }

    
}