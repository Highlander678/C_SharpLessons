using System;

namespace WCF_Служба
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to...
    // NOTE: In order to launch WCF Test Client for testing this service,...
    public class Service1 : IService1
    {
        public String ВводИмени(String Имя)
        {
            return Имя + ", вы увлекаетесь WCF ?";
        }
    }
}
