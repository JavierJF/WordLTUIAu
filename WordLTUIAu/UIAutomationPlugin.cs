using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLTUIAu
{
    enum ErrorType
    {
        TargetNotAvailable,
        PropertiesNotFound,
        OptionsNotTriggered
    }

    class UIAutomationPluginError
    {
        private ErrorType err { get; }
        
        private String msg { get; }

        public UIAutomationPluginError(ErrorType err, String msg)
        {
            this.err = err;
            this.msg = msg;
        }
    }

    interface UIAutomationPlugin
    {
        UIAutomationPluginError watch();
    }
}
