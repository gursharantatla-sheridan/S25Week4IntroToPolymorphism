namespace S25Week4IntroToPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass objBase;

            objBase = new BaseClass();
            objBase.Show();

            objBase = new DerivedClass();
            objBase.Show();


            //DerivedClass objDerived = new BaseClass();
        }
    }
}
