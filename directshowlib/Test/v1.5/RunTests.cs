using System;

namespace v1._5
{
    class Class1
    {
        [STAThread]
        static void Main(string[] args)
        {
            // IAMTimecodeReaderTest t1 = new IAMTimecodeReaderTest();
            // t1.DoTests();

            // IAMBufferNegotiationTest t2 = new IAMBufferNegotiationTest();
            // t2.DoTests();

            //IObjectWithSiteTest t3 = new IObjectWithSiteTest();
            //t3.DoTests();

            //IAMGraphBuilderCallbackTest t4 = new IAMGraphBuilderCallbackTest();
            //t4.DoTests();

            IServiceProviderTest t5 = new IServiceProviderTest();
            t5.DoTests();

        }
    }
}