﻿using RKD.Data;
using RKD.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RKD.Web.Code.Attributes
{
    public class ManageExceptionFilter : FilterAttribute, IExceptionFilter
    {

        public void OnException(ExceptionContext filterContext)
        {
           //to do logic to log error 
        }
    }
}