var loginFormValidator;


$(document).ready(function () {
    if (window.localStorage.getItem('userDetails') !== null) {
        window.localStorage.removeItem('userDetails');
    }
    console.log('login handler executed');
    $('[data-toggle="tooltip"]').tooltip();             //enable bootstrap tooltip
    //initialize form validator
    $.validator.setDefaults({
        submitHandler: function () {
            submitCredentials();
        }
    });
    loginFormValidator = $('#loginForm').validate({
        rules: {
            username: {
                required: true
            },
            password: {
                required: true
            }
        },
        messages: {
            username: {
                required: "Please provide your username"
            },
            password: {
                required: "Please provide your password"
            }
        },
        errorElement: 'span',
        errorPlacement: function (error, element) {
            error.addClass('invalid-feedback');
            element.closest('.input-group').append(error);
        },
        highlight: function (element, errorClass, validClass) {
            $(element).addClass('is-invalid');
        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).removeClass('is-invalid');
        }
    });
});

function AuthenticateUser(username, password) {
    //var userDto = {
    //    Username: username,
    //    Password: password
    //}
    $.ajax({
        url: API_URL + "Authentication/Login",
        type: "POST",
        data: JSON.stringify({ "username": username, "password": password }),
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.name === null) {
                Toast.fire({
                    icon: 'error',
                    title: 'Incorrect login details!'
                });
            }
            else {
                if (data.role == "Admin") {
                    window.localStorage.setItem('userDetails', JSON.stringify(data));
                    window.location.replace('http://localhost:5001/RegistrarAdmin/ManageEnrollment');

                    Toast.fire({
                        icon: 'info',
                        title: 'Login Successfull!'
                    });
                }
                else if (data.role == "Assistant") {
                    window.localStorage.setItem('userDetails', JSON.stringify(data));
                    window.location.replace('RegistrarAssistant/ManageEnrollment');

                    Toast.fire({
                        icon: 'info',
                        title: 'Login Successfull!'
                    });
                }
                else if (data.role == "StudentAssistant") {
                    window.localStorage.setItem('userDetails', JSON.stringify(data));
                    window.location.replace('http://localhost:5001/RegistrarAssistant/ManageEnrollment');

                    Toast.fire({
                        icon: 'info',
                        title: 'Login Successfull!'
                    });
                }
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log('An error occurred: ' + errorThrown);
        }
    }) 
}

function submitCredentials() {
    console.log('login credentials submitted');
    var loginData = {
        username: $('#loginUsername').val().trim(),
        password: $('#loginPassword').val().trim()
    };
    console.log('login data: ', loginData);
}

function clearModalForm() {
    if (collegeFormValidator != null) {
        collegeFormValidator.resetForm();
        if ($("input").hasClass("is-invalid"))
            $("input").removeClass("is-invalid");
        console.log("form cleared");
    }
}