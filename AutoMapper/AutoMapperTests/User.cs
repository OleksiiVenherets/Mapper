namespace AutoMapperTests
{
    /// <summary>
    /// Class to saving data about user
    /// </summary>
    public class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Log Logs { get; set; }

        /// <summary>
        ///  Nested class to saving loginning data
        /// </summary>
        public class Log
        {
            public string Login { get; set; }
            public string Pass { get; set; }
        }
    }
}
