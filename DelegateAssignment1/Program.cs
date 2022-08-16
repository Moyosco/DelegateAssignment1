namespace DelegateAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        internal class Delegates1
        {
            public delegate bool Predicate(XClass x);

            void LambdaExpansion()
            {

                var likelyUsername = "Oloruntobi";

                Predicate classwork = (XClass x) =>
                {
                    if (x.UserName == likelyUsername)  //check if Username is equal to LikelyUsername
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };
            }
        }
       
    }

    class XClass
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string UserName { get; set; }

    }
}
    
