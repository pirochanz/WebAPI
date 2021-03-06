using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Web.Mvc;

namespace MvcApl.Extensions
{
    public class ButtonAttribute : ActionMethodSelectorAttribute
    {
        //アクションメソッド付加時に設定したボタン名を保存
        public string ButtonName { get; set; }

        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            //設定したボタン名と同名のデータが存在するかチェック(Requestで返ってきているか）
            return controllerContext.Controller.ValueProvider.GetValue(ButtonName) != null;
        }
    }
}