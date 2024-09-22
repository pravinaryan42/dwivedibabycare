

(function ($) {
    function ManageSideBar() {
        var $this = this;
        
        function InitializeSideBar()
        {
            SetActiveMenu();
            $(".tabcontainer").click(function () {
                
                $(this).find('ul').show("slow");
            })
        }
        function SetActiveMenu() {            
            
            var urlPath = window.location.href.replace(domain, '');
            var ActiveId = urlPath.split('/')[1]; 
            var ActiveSubMenuId = (urlPath.split('/')).length > 2 ? urlPath.split('/')[2]:''; 

            if (ActiveId != undefined) {
                if (ActiveId != "SubscriptionPackage?UserRoleId=2" && ActiveId != "SubscriptionPackage?UserRoleId=3") {

                 
                        $('#' + ActiveId).addClass('active');
                        if ($('#' + ActiveId).parents().closest('li').attr('id') == "UserTab") {
                            $(".tabcontainer").addClass('active');
                            $(".tabcontainer").find('ul').show("slow");
                        }
                        else if ($('#' + ActiveId).parents().closest('li').attr('id') == "OtherTab") {
                            $(".tabothercontainer").addClass('active');
                            $(".tabothercontainer").find('ul').show("slow");
                        }
                        else if (ActiveId == "Subscription") {
                            $(".tabcontainerSub").addClass('active');
                            $(".tabcontainerSub").find('ul').show("slow");
                            var ActiveSubId = window.location.pathname.split('/')[3];
                            if (ActiveSubId != "SubscriptionPlan")
                                $(".tabcontainerSub ul li#" + ActiveSubId).addClass('active');
                            else
                                if (window.location.href.split('?')[1] == "roleId=2") {
                                    $(".tabcontainerSub ul li#SubscriptionPlan").addClass('active');
                                }
                                else {
                                    $(".tabcontainerSub ul li#SubscriptionPatientPlan").addClass('active');
                                }
                        }

                        else if (ActiveId == "PromoCode") {
                            var ActiveSubId = urlPath.split('/')[2];
                            $(".tabcontainerSub ul li#" + ActiveSubId).addClass('active');
                        }
                        else if (ActiveId == "statewiselegalstatus") {
                            $('#statewise').addClass('active menu-open');
                        }
                        else if (ActiveId == "trackinghistory") {
                            $('#tracking').addClass('active menu-open');
                        }
                        else if (ActiveId == "VettedCareSettings") {
                            $('#vettedcaresettings').addClass('active menu-open');
                        }

                        else {
                            $(".tabcontainer").removeClass('active');
                            $(".tabcontainer").find('ul').hide("slow");
                        }
                   
                  
                }

               
                else {
                  if (ActiveId == "SubscriptionPackage?UserRoleId=2" || ActiveId == "SubscriptionPackage?UserRoleId=3") {
                      if (window.location.href.split('?')[1] == "UserRoleId=2") {
                          $(".tabcontainerSub ul li#DoctorSubscriptionPackage").addClass('active');
                        }
                        else {
                          $(".tabcontainerSub ul li#PatientSubscriptionPackage").addClass('active');
                        }
                    }

                }
               
              
            }
            if (urlPath.includes('reports')) {
                $('#ReportsTab').addClass('active menu-open');
            }
            else if (urlPath.includes('statewiselegalstatus') || urlPath.includes('trackinghistory') || urlPath.includes('VettedCareSettings')) {

                if (ActiveId == 'trackinghistory' && ActiveSubMenuId == 'clickcountindex') {
                    $("li").removeClass('active');
                    $("li#clickcountindex").addClass('active');
                }

                else if (ActiveId == 'trackinghistory' && ActiveSubMenuId == 'visitcountindex') {
                    $("li").removeClass('active');
                    $("li#visitcountindex").addClass('active');
                }
                else {
                    $('#VettedTab').addClass('active menu-open');
                }
                
            }
            else {
                $('.dashboard').addClass('active');
            }
        }


        $(document).off("click", "#ReportsTab.treeview").on("click", "#ReportsTab.treeview", function () {           
                $('#ReportsTab .productcoa').addClass('active');
                window.location.href = domain + 'admin/reports/index';           
        });
        

        $this.init = function () {
            InitializeSideBar();
        }
    }

    $(function () {
        var self = new ManageSideBar();
        self.init();

        $('#admsignot').click(function () {
            localStorage.clear();            
        })

        $('#ProductTab li#product').click(function () {
            localStorage.removeItem('productfilter');
            localStorage.removeItem('AllPRoductIDs');
        })
    });
}(jQuery));