using System;

namespace MTD_Laba_3
{
    public sealed class Singleton
    {
        private static volatile Singleton singletonInstance = null;
        private static readonly Object syncRoot = new Object();
        private string _value;
        private Singleton()
        {
            _value = " ";
        }
        public static Singleton GetInstance()
        {
            if (singletonInstance == null)
                lock (syncRoot)
                {
                    if (singletonInstance == null)
                    {
                        singletonInstance = new Singleton();
                    }
                }
            return singletonInstance;
        }
         public string WriteNumber(int a)
        {
            if (_value == " ")
                lock (syncRoot)
                {
                    if (_value == " ")
                    {
                        _value += a.ToString();
                    }
                }
            return _value;
        }
    }
}
