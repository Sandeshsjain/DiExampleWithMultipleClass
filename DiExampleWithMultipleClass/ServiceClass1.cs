using System.Reflection.Metadata.Ecma335;

namespace DiExampleWithMultipleClass
{
    public class ServiceClass1 : MyService
    {
        public string GetMessage()
        {
            return "My message from ServiceClass1";
        }
    }
}
