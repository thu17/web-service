
var ViewModel = function () {
    
    var self = this;
    //self.TenCombo = ko.observable();
    //self.Gia = ko.observable();
    //self.Anh = ko.observable();

    self.Comboes = ko.observableArray([]);

    GetAllComboHasAnItem();

    //var ComboObject = {
    //    TenCombo: self.TenCombo,
    //    Gia: self.Gia,
    //    Anh: self.Anh
    //}

    function GetAllComboHasAnItem() {
        $.ajax({
            type: "GET",
            url: "/api/apicombo/getlistitems",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                self.Comboes(data)
            },
            error: function (error) {
                alert(error.status + " " + error.statusText);
            }
        });
    }
}
//ko.cleanNode(document.getElementById("search-bar-area"));
ko.applyBindings(new ViewModel(), document.getElementById("index-area"));