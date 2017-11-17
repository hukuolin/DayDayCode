using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Mvc;
using System.Collections.Specialized;
using System.Web.Routing;
namespace WebHelper
{
    public class MvcRequestHelperAttribute:System.Web.Http.Filters.ActionFilterAttribute
    {
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            //如果请求不符合要求不让进入请求接口

            var request = System.Web.HttpContext.Current.Request;
            NameValueCollection nameValue = request.Params;
            string[] requestParams= request.Form.AllKeys;//请求参数列表
            NameValueCollection dic = request.Form;
            foreach (var item in dic)
            {
                 
            }
            base.OnActionExecuting(actionContext);
        }
    }
    public class MvcActionResultHelperAttribute : System.Web.Mvc.ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {//此处理并非是客户端直接传递过来的参数，而是经过代码处理后的结果
            RequestContext request = filterContext.RequestContext;
            
            IDictionary<string,object> apiParamList= filterContext.ActionParameters;//进入接口传递的参数
            RouteData rd = filterContext.RouteData;
            if (apiParamList.Count == 0)
            {
                return;
            }
            base.OnActionExecuting(filterContext);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            RequestContext request = filterContext.RequestContext;
           
            base.OnResultExecuting(filterContext);
        }
    }
}
