var NhomHang = function (id, name) {
    this.idnhomhang = id;
    this.namenhomhang = name;
};
var ThuongHieu = function (id, name) {
    this.idthuonghieu = id;
    this.namethuonghieu = name;
};
var MauSac = function (id, name) {
    this.idmausac = id;
    this.namemausac = name;
};
var KieuDang = function (id, name) {
    this.idkieudang = id;
    this.namekieudang = name;
};
var SearchBarModel = function () {
    var self = this;
    var uriNhomHang = "/api/apinhomhang/getall";
    var uriGetAllTH = "/api/apithuonghieu/getall";
    var uriGetTHByNhomHang = "/api/apithuonghieu/bynhomhang?id=";
    var uriGetAllMS = "/api/apimausac/getallms";
    var uriGetAllKD = "/api/apikieudang/getallkd";
    //var uriGetMSByNhomHang = "api/apimausac/getbynhomhang?idnh=?";
    //var uriGetMSByThuongHieu = "api/apimausac/getbythuonghieu?idth=?";
    //var uriGetMSByNHAndTH = "api/apimausac/getby?nh=";
    self.thvalue = ko.observable("-1");
    self.msvalue = ko.observable("-1");
    self.kdvalue = ko.observable("-1");
    self.NhomHangs = ko.observableArray([]);

    self.ThuongHieus = ko.observableArray([]);

    self.MauSacs = ko.observableArray([]);

    self.KieuDangs = ko.observableArray([]);

    self.BindingThuongHieu = function () {
        getThuongHieu();
    };
    self.GetThuongHieuValue = function () {
        var th = $('#thuonghieu').val();
        if (th === "") {
            th = -1;
        }
        self.thvalue(th);
    };
    self.GetMauSacValue = function () {
        var ms = $('#mausac').val();
        if (ms === "") {
            ms = -1;
        }
        self.msvalue(ms);
    };
    self.GetKieuDangValue = function () {
        var kd = $('#kieudang').val();
        if (kd === "") {
            kd = -1;
        }
        self.kdvalue(kd);
    }
    
    //self.applySearch = function () {
    //    ko.cleanNode($("#index-area")[0]);
    //    alert("dont click me !!!");
    //    viewresult = new SearchResultModel();
    //    ko.applyBindings(viewresult, document.getElementById("index-area"));
        
    //}
    function ajaxHelper(uri, method, data) {
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null,
            async: false
        }).fail(function (jqXHR, textStatus, errorThrown) {

        });
    }

    function getNhomHang() {
        var nhomhangs = new Array();
        ajaxHelper(uriNhomHang, 'GET').done(function (nhomhangresult) {
            for (var i = 0; i < nhomhangresult.length; i++) {
                var nh = new NhomHang(nhomhangresult[i].IDNhomHang, nhomhangresult[i].TenNhomHang);
                nhomhangs.push(nh);
            }
            self.NhomHangs(nhomhangs);
        });
    }


    function getThuongHieu() {
        var thuonghieus = new Array();
        var idnhomhang = $('#nhomhang').val();
        if (idnhomhang === "" || idnhomhang === null) {
            ajaxHelper(uriGetAllTH, 'GET').done(function (result) {
                for (var i = 0; i < result.length; i++) {
                    var th = new ThuongHieu(result[i].IDThuongHieu, result[i].TenThuongHieu);
                    thuonghieus.push(th);
                }
                self.ThuongHieus(thuonghieus);
            });
        }
        else {
            ajaxHelper(uriGetTHByNhomHang + idnhomhang, 'GET').done(function (result) {
                for (var i = 0; i < result.length; i++) {
                    var th = new ThuongHieu(result[i].IDThuongHieu, result[i].TenThuongHieu);
                    thuonghieus.push(th);
                }
                self.ThuongHieus(thuonghieus);
            });
        }

    }


    function getMauSac() {        
        var mausacs = new Array();
        ajaxHelper(uriGetAllMS, 'GET').done(function (result) {
            for (var i = 0; i < result.length; i++) {
                var ms = new MauSac(result[i].IDMauSac, result[i].C_MauSac);
                mausacs.push(ms);
            }
            self.MauSacs(mausacs);
        });
    }
    function getKieuDang() {
        var kieudangs = new Array();
        ajaxHelper(uriGetAllKD, 'GET').done(function (result) {
            for (var i = 0; i < result.length; i++) {
                var kd = new KieuDang(result[i].IDDacDiem, result[i].C_DacDiem);
                kieudangs.push(kd);
            }
            self.KieuDangs(kieudangs);
        });
    }

    getNhomHang();
    getThuongHieu();
    getMauSac();
    getKieuDang()
};

ko.applyBindings(new SearchBarModel(), document.getElementById("search-bar-area"));
//ko.cleanNode(document.getElementById("index-area"));
