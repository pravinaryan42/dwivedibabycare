﻿using System.Web;
using System.Web.Mvc;
using RKD.Web.Models.Security;

namespace RKD.Web.Code.LIBS
{
    public class BaseViewPage<TModel> : WebViewPage<TModel>
    {
        public CustomPrincipal CurrentUser
        {
            get { return HttpContext.Current.User as CustomPrincipal; }
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }

    public class BaseViewPage : WebViewPage
    {
        public CustomPrincipal CurrentUser
        {
            get { return HttpContext.Current.User as CustomPrincipal; }
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}