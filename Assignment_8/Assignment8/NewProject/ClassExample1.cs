
namespace Testing
{
    public class ClassExample1
    {
        protected string firstName;
        private string lastName;
        internal int age;
        public string fullName;

        public string GetMyName(string first, string last)
        {
            this.firstName = first;
            this.lastName = last;
            this.fullName = first + " " + last;
            return this.fullName;
        }

    }
}
