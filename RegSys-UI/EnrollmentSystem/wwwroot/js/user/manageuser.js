var personDetails = JSON.parse(window.localStorage.getItem('userDetails'));
$(document).ready(function () {
    if (window.localStorage.getItem('userDetails') == null) {
        Toast.fire({
            icon: 'error',
            title: 'Unauthorized Login!'
        });
        setTimeout(function () {
            window.location.replace('http://localhost:5001/Login/Index');
        }, 2000);
    }
    $(".info .personName").text(personDetails.name);
    $(".brand-link .role").text(personDetails.role);
    getUsers();
    getRoles();
    $("#createUser").on('click', function () {
        $("#userModal").modal('show');
        $("#saveUserInfo").on('click', function () {
            var user = {
                "userId": 0,
                "username": $("#userModal #username").val(),
                "password": $("#userModal #password").val(),
                "roleId": $("#userModal #role").find(":selected").val(),
                "firstName": $("#userModal #firstname").val(),
                "lastName": $("#userModal #lastname").val()
            }

            saveUser(user);
        })
    });
})

function getUsers() {
    $.ajax({
        url: API_URL + "User/GetList",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            var userData = [];
            $(data).each(function (index) {
                var users = data;            
                var updateButton = '<a class="updateUser" onclick="openManageUserModal(\'' + users[index].userId + '\',\'' + users[index].username + '\',\'' + users[index].password + '\',\'' + users[index].roleId + '\',\'' + users[index].role + '\',\'' + users[index].personId + '\',\'' + users[index].firstName + '\',\'' + users[index].lastName + '\')" title="Update User"><i class="fa-regular fa-pen-to-square"></i></a>';
                var deactivateButton = '<a class="deleteUser" /*onclick="openUpdateModal()"*/ title="Delete User"><i class="fa-regular fa-trash-can"></i></a>';
                var userRecord = new Array(users[index].userId, users[index].firstName + " " + users[index].lastName, users[index].username, users[index].password, users[index].role, updateButton + deactivateButton);
                userData.push(userRecord);
            })

            $('#tblUserList').DataTable({
                destroy: true,
                paging: true,
                lengthChange: false,
                searching: true,
                ordering: true,
                info: true,
                autoWidth: false,
                responsive: true,
                columns: [
                    { title: "User ID", defaultContent: "" },
                    { title: "Name", defaultContent: "" },
                    { title: "Username", defaultContent: "" },
                    { title: "Password", defaultContent: "" },
                    { title: "Role", defaultContent: "" },
                    { title: "Action", defaultContent: "" }

                ],
                columnDefs: [
                    { className: 'text-center', targets: '_all' },  //center align selected columns
                    { visible: false, targets: [0] }
                ],
                data: userData
            })
        },
        error: function (error) {
        }
    })
}
function getRoles() {
    $.ajax({
        url: API_URL + "Role/GetList",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            var roles = data;
            $(data).each(function (index) {
                $("#role").append($('<option/>', { value: roles[index].roleId, text: roles[index].roleName }));
            })
        },
        error: function (error) {
        }
    })
}
function openManageUserModal(userId, username, password, roleId, role, personId, firstName, lastName) {
    $("#userModal #firstname").val(firstName);
    $("#userModal #lastname").val(lastName);
    $("#userModal #username").val(username);
    $("#userModal #password").val(password);
    $("#userModal #role").val(roleId);

    $("#userModal").modal('show');
    $("#saveUserInfo").on('click', function () {
        var user = {
            "userId": userId,
            "username": $("#userModal #username").val(),
            "password": $("#userModal #password").val(),
            "roleId": $("#userModal #role").find(":selected").val(),
            "personId": personId,
            "firstName": $("#userModal #firstname").val(),
            "lastName": $("#userModal #lastname").val()
        }

        saveUser(user);
    })
}
function updateUser(user) {
    $.ajax({
        url: API_URL + "User/Edit",
        type: "PUT",
        data: JSON.stringify(user),
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            Swal.fire(
                'Success!',
                'User has been updated successfully!',
                'success'
            )
            getUsers();
            clearModal();
        }
    })
}
function addUser(user) {
    $.ajax({
        url: API_URL + "User/Add",
        type: "POST",
        data: JSON.stringify(user),
        dataType: 'json',
        contentType: 'application/json',
        success: function () {
            Swal.fire(
                'Success!',
                "Subjects has been added successfully!",
                'success'
            )

            getUsers();
            clearModal();
        },
        error: function (error) {
            console.log('Error: ', error);
            Toast.fire({
                icon: 'error',
                title: 'Could not connect to the server!'
            });
        }
    });
}
function saveUser(user) {
    console.log("USER DATA: " + JSON.stringify(user));
    console.log("USER ID: " + user.userId);
    if (user.userId) {
        updateUser(user);
    } else {
        addUser(user);
    }
}
function clearModal() {
    $("#userModal #firstname").text("");
    $("#userModal #lastname").text("");
    $("#userModal #username").text("");
    $("#userModal #password").text("");
    $("#userModal #role option:first").attr('selected', 'selected');
}