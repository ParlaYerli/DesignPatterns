using Builder.Example1.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example1.Director
{
    public class DirectorMobilePhone
    {
        IBuilderMobilePhone iBuilderMobilePhone;
        public DirectorMobilePhone(IBuilderMobilePhone iBuilderMobilePhone)
        {
            this.iBuilderMobilePhone = iBuilderMobilePhone;
        }
        public void Construction()
        {
            iBuilderMobilePhone.GetBattery();
            iBuilderMobilePhone.GetColor();
            iBuilderMobilePhone.GetModel();
            iBuilderMobilePhone.GetOperatingSystem();
            iBuilderMobilePhone.GetScreen();
          
        }
    }
}
