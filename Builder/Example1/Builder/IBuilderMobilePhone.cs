using Builder.Example1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example1.Builder
{
    /// 2. aşama
    public interface IBuilderMobilePhone
    {
        void GetScreen();
        void GetBattery();
        void GetOperatingSystem();
        void GetColor();
        void GetModel();
        MobilePhone GetMobilePhone();
    }
}
