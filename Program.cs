namespace Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton s2 = Singleton.Getinstance;
            //s2.Printdetails("From s2 second message");
            //Singleton s1 = Singleton.Getinstance;
            //s1.Printdetails("From s1");
            //---------- by calling s1 and s2 we are getting count value 1 because we are using same instance


            Parallel.Invoke( //it is used to call multiple methods at the same time to solve this we are gona use lock
                () => Student1(),
                () => Student2()
                );

        }

        private static void Student2()
        {
            Singleton s2 = Singleton.Getinstance;
            s2.Printdetails("From s2 second message");
        }

        private static void Student1()
        {
            Singleton s1 = Singleton.Getinstance;
            s1.Printdetails("From s1");
        }
    }
}
