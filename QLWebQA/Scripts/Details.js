/// <reference path="knockout-3.4.2.js" />
var obj = function (index, sp, mss, kcs, ms_selected) {
    this.index = index;
    this.sp = sp;
    this.mss = ko.observableArray(mss);
    this.kcs = ko.observableArray(kcs);
    this.ms_selected = ko.observable(ms_selected);
}
var sanpham = function (id, name) {
    this.id = id;
    this.name = name;
}

var  mausac = function(id, name)
{
    this.id = id;
    this.name = name;
}

var kichco = function(id, name)
{
    this.idkichco = id;
    this.tenkichco = name;
}

//ko.observableArray.fn.find = function (prop, data) {
//    var valueToMatch = data[prop];
//    return ko.utils.arrayFirst(this(), function (item) {
//        return item[prop] === valueToMatch;
//    });
//};
//function msChoice(objs,obj)
//{
//    this.objs = ko.observableArray(objs);
//    this.obj = ko.observable(this.objs.find('id'),obj);
//}
var ViewModel = function () {
    /////////////////
    var self = this;
    self.error = ko.observable();
    var comboUri = "/api/apicombo/getanitembyid?id=";
    var spUri = "/api/apisanpham/getlistsanphambycomboid?id=";
    var msUri = "/api/apimausac/getlistmausacbysanphamid?id=";
    var kcUri = "/api/apikichco/getlistkichcobyidsanphamanhidmausac?sp=";
    var urlParam = window.location.toString();
    var arr = urlParam.split("=", 10)[1];
    var idvalue = arr[0].toString();
    /////////////////
    /////////////////
    /////////////////
    function ajaxHelper(uri, method, data) {
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null,
            async: false
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }
    /////////////////
    /////////////////
    /////////////////
    self.TenItem = ko.observable();
    self.Gia = ko.observable();
    self.Image = ko.observable();
    self.SoLuong = ko.observable();
    function GetComboInfo() {

        ajaxHelper(comboUri + idvalue, 'GET').done(function (data) {
            self.TenItem(data.TenItem);
            self.Gia(data.Gia);
            self.Image(data.Image);
            self.SoLuong(data.SoLuong);
        });
    }
    GetComboInfo();
    //va day
    //tu day
    /////////////////
    /////////////////
    /////////////////    
    self.objArray = ko.observableArray();
    self.msid = ko.observable();
    self.msArray = ko.observableArray();
    self.kcArray = ko.observableArray();
    var objArrayLocal = new Array();
    ShowSanPhamOptions();
    function ShowSanPhamOptions() {
        ajaxHelper(spUri + idvalue, 'GET').done(function (spresult) {
            for (var i = 0; i < spresult.length; i++) {
                var sp = new sanpham(spresult[i].IDSanPham, spresult[i].TenSanPham);
                var mss = new Array();
                ajaxHelper(msUri + sp.id, 'GET').done(function (msresult) {
                    for (var j = 0; j < msresult.length; j++) {
                        var ms = new mausac(msresult[j].IDMauSac, msresult[j].C_MauSac);
                        mss.push(ms);
                    }
                });
                var o = new obj(i,sp, mss, [], "");
                objArrayLocal.push(o);
            }
            self.objArray(objArrayLocal);
        });
    }

    self.ShowKichCoBySanPhamAnhMauSac = function (index) {
        //alert(index)
        ajaxHelper(spUri + idvalue, 'GET').done(function (spresult) {
            for (var i = 0; i < spresult.length; i++) {
                if (i == index) {
                    var sp = new sanpham(spresult[i].IDSanPham, spresult[i].TenSanPham);
                    var mss = new Array();
                    ajaxHelper(msUri + sp.id, 'GET').done(function (msresult) {
                        for (var j = 0; j < msresult.length; j++) {
                            var ms = new mausac(msresult[j].IDMauSac, msresult[j].C_MauSac);
                            mss.push(ms);
                        }
                    });
                    var mscurrent = $("#ms" + sp.id).val();
                    var kcArrayLocal = new Array();
                    if (mscurrent == "" || mscurrent == undefined)
                    { }
                    else {
                        ajaxHelper(kcUri + sp.id + '&ms=' + mscurrent, 'GET').done(function (kcresult) {
                            for (var k = 0; k < kcresult.length; k++) {
                                var kc = new kichco(kcresult[k].IDKichCo, kcresult[k].C_KichCo);
                                kcArrayLocal.push(kc);
                            }
                            var newobj = new obj(i,sp, mss, kcArrayLocal, mscurrent);
                            self.objArray.replace(self.objArray()[i], newobj);
                            
                        });
                    }
                    return;
                }
                
            }            
        });
    }
}
ko.applyBindings(new ViewModel(),document.getElementById("combo-detail-area"));