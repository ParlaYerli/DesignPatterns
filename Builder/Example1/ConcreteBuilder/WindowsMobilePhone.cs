using Builder.Example1.Builder;
using Builder.Example1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example1.ConcreteBuilder
{
    /// 3. aşama
    public class WindowsMobilePhone : IBuilderMobilePhone
    {
        MobilePhone mobilePhoneObject;
        public WindowsMobilePhone()
        {
            mobilePhoneObject = new MobilePhone();
        }
        public void GetBattery()
        {
            mobilePhoneObject.Battery = 5200;
        }

        public void GetColor()
        {
            mobilePhoneObject.Color = "Black";
        }

        public MobilePhone GetMobilePhone()
        {
            return mobilePhoneObject;
        }

        public void GetModel()
        {
            mobilePhoneObject.Model = "Xiaomi note 8 pro";
        }

        public void GetOperatingSystem()
        {
            mobilePhoneObject.OperatingSystem = "Android Operating System";
        }

        public void GetScreen()
        {
            mobilePhoneObject.Screen = "Android Screen";
        }
    }
}
