namespace AutoMapperTests
{
    /// <summary>
    ///  Class to saving data about person
    /// </summary>
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Log Logs { get; set; }

        /// <summary>
        /// Parametrless constructor for class Person
        /// </summary>
        public Person()
        {
            Logs = new Log() { Login = null };
        }

        /// <summary>
        ///  Nested class to saving loginning data
        /// </summary>
        public class Log
        {
            public string Login { get; set; }

            /// <summary>
            /// Parametrless constructor for class Log
            /// </summary>
            public Log() { }
        }
    }
}
