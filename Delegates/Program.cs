namespace Delegates
{
    internal class Program
    {
        delegate void mDelegate();

        // 3 types of delegate

        // 1. Action, 2. Func, 3. Pred

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            M2(M1);
            // or
            Action action = M1;
            action.Invoke();
            M2(action);
        }

        static void M1()
        {
            Console.WriteLine("M1");
        }        
        static void M2(Action action)
        {
            action();
            Console.WriteLine("M2");
        }
    }
}
