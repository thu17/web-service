var LoginModel = function () {
    self = this;
    self.checkLogin = function () {
        checkLogin();
    }
    function checkLogin() {
        var email = $("#email").val();
        alert(email);
        var pwd = $('#pwd').val();
        alert(pwd);
        $.ajax({
            type: 'GET',
            url: '/api/apilogin/login?email=' + email + '&pwd=' + pwd,
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            success: function (data) {
                if (data !== null) {
                    //localStorage.setItem('email', data.Email);
                    //localStorage.setItem('pwd', data.Password);
                    //localStorage.setItem('type', data.Type);
                    alert("Correct!!");
                }
            }
        });
    }
};
ko.applyBindings(new LoginModel(), document.getElementById("login-area"));