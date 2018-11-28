var SearchResultModel = function () {
    var self = this;
    self.Comboes = ko.observableArray([]);

    function Search() {
        var urlParam = window.location.toString();
        var arr = urlParam.split("=");
        var idthuonghieu = arr[1].split("&")[0];
        //alert(idthuonghieu);
        var idmausac = arr[2].split("&")[0];
        //alert(idmausac);
        var kieudang = arr[3];
        //alert(kieudang);
        
        if (idthuonghieu !== null && idthuonghieu !== "" && idmausac !== null && idmausac !== null && kieudang !== "" && kieudang !== null) {
            $.ajax({
                type: "GET",
                url: "/api/apicombo/search?idthuonghieu=" + idthuonghieu + "&idmausac=" + idmausac + "&kieudang=" + kieudang,
                contentType: "application/json; charset=utf-8",
                //data: { idthuonghieu: idthuonghieu, idmausac: idmausac, kieudang: kieudang },
                dataType: "json",
                success: function (data) {
                    if (data.length === 0)
                    {
                        alert("No record was found!!");
                    }else
                    self.Comboes(data);
                },
                error: function (error) {
                    alert(error.status + " " + error.statusText);
                }
            });
        }

    }
    Search();
};
ko.applyBindings(new SearchResultModel(), document.getElementById("result"));