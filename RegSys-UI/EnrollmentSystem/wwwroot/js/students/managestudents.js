
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
    //create new student
    getEnrolleeList();
    $("#createStudent").click(function () {
        $("createUpdateStudentModalTitle").text('Add new student.');
        $("#createUpdateStudentModal").modal('show');

        console.log('creating student');
    });
    $('#bddatepicker').datetimepicker({
        format: 'L',
        defaultDate: '01/01/2022',
    });
    $("#studentIDNo").val(moment().format("YYYY") + "-" + newGuid());
    getPrograms();
    getMajorByProgram();

    getBarangaysByCityMunicipality();
    getProvinces();
    setAge();
    //Save Student Info to Database
    $("#createUpdateStudentModalSaveButton").click(function () {
        let student = {
            //studentId: $("#studentId").val(),
            studentNo: $("#studentIDNo").val(),
            lrnno: $("#lrn").val(),
            person: {
                firstName: $("#firstname").val(),
                lastName: $("#lastname").val(),
                middleName: $("#middlename").val(),
                maidenName: $("#maidenname").val(),
                nameExtension: $("#nameextension").val(),
                birthDate: moment($("#birthdate").val()).format('YYYY-MM-DDTHH:mm:ss.SSS'),
                birthPlace: $("#birthplace").val(),
                age: $("#age").val(),
                gender: {
                    genderName: $("#gender").val()
                },
                civilStatus: {
                    civilStatusType: $("#civilstatus").val()
                },
                citizenship: {
                    citizenshipStatus: $("#citizenship").val()
                },
                country: {
                    countryName: $("#country").val()
                },
                telephoneNo: $("#telephonenumber").val(),
                mobileNo: $("#mobilenumber").val(),
                emailAddress: $("#email").val(),
                address: {
                    houseBlkLotNo: $("#houseblocklotno").val(),
                    street: $("#street").val(),
                    subdivisionVillage: $("#subdivisionvillage").val(),
                    barangay: {
                        barangayName: $("#barangay").find(":selected").text()
                    },
                    cityMunicipality: {
                        cityMunicipalityName: $("#citymunicipality").find(":selected").text()
                    },
                    province: {
                        provinceName: $("#province").find(":selected").text()
                    },
                    addressType: {
                        addressTypeName: $("#addresstype").val()
                    }
                }
            },
            program: {
                programName: $("#program").find(":selected").text()
            },
            major: {
                majorName: $("#major").find(":selected").text()
            },
            yearLevel: $("#yearLevel").find(":selected").text(),
            isActive: true
        }
        console.log(JSON.stringify(student));
        console.log("This is the ID: " + student.studentId);

        addStudent(student);

    });
    $("#clearButton").click(function () {
        clear();
    });
    $('#selectpicker').selectpicker();
});

function getEnrolleeList() {
    $.ajax({
        url: API_URL + "Student/GetList/Enrollees",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            var enrolleeList = [];
            $(data).each(function (index) {
                var enrollees = data;
                console.log('data: ', enrollees);
                console.log(enrollees[index]);

                var updateButton = '<a class="updateStudentInfo" onclick="getStudentInfo(' + enrollees[index].studentId + ')" title="Update Student Information"><i class="fa-solid fa-file-circle-check fa-icon-link"></i></a>';
                var deactivateButton = '<a class="deactivateStudent"  onclick="deactivateStudent(' + enrollees[index].studentId + ') " title="Deactivate Student"><i class="fa-solid fa-circle-info fa-icon-link"></i></a>';

                var enrolleesRecord = new Array(enrollees[index].studentNo, enrollees[index].fullName, enrollees[index].course, enrollees[index].major, enrollees[index].yearLevel, updateButton + deactivateButton);
                enrolleeList.push(enrolleesRecord);
            });

            $('#studentListTable').DataTable({
                destroy: true,
                paging: true,
                lengthChange: false,
                searching: true,
                ordering: true,
                info: true,
                autoWidth: false,
                responsive: true,
                columns: [
                    { title: "Student No", defaultContent: "" },
                    { title: "Student Name", defaultContent: "" },
                    { title: "Program", defaultContent: "" },
                    { title: "Major", defaultContent: "" },
                    { title: "Year Level", defaultContent: "" },
                    { title: "Action", orderable: false }
                ],
                columnDefs: [
                    { className: 'text-center', targets: '_all' }  //center align selected columns
                    //{ visible: false, targets: [1, 7, 8, 9, 10, 11, 12, 13] }
                ],
                data: enrolleeList
            });
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

function deactivateStudent(studentId) {
    alert('Deactivate student with ID: ' + studentId);
}

//GET Functions
function getPrograms() {
    $.ajax({
        url: API_URL + "Program/GetList",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            $(data).each(function (index) {
                var programs = data;
                console.log('data: ', programs);
                $("#program").append($('<option/>', { value: programs[index].programName, text: programs[index].programName }));
            });
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
function getMajorByProgram() {
    $("#program").on('change', function () {
        if (!$(this).children('option:first-child').is(':selected')) {
            $("#major option:not(:first)").remove();
            console.log($("#program").val());
            $.ajax({
                url: API_URL + "Program/GetList/Majors",
                type: "GET",
                dataType: 'json',
                data: { 'programName': $("#program").val() },
                cache: false,
                contentType: 'application/json',
                success: function (data) {
                    $(data).each(function (index) {
                        var majors = data;
                        console.log('data: ', majors[index].major.majorName);
                        $("#major").append($('<option/>', { value: majors[index].major.majorName, text: majors[index].major.majorName }));
                    });
                },
                //complete: function () {
                //    if (callback) { callback(); }
                //},
                error: function (error) {
                    console.log('Error: ', error);
                    Toast.fire({
                        icon: 'error',
                        title: 'Could not connect to the server!'
                    });
                }
            });
        }
        else {
            $("#major option:not(:first)").remove();
        }
    });
}
function getProvinces() {
    $.ajax({
        url: API_URL + "Province/GetList",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            $(data).each(function (index) {
                var province = data;
                $("#province").append($('<option/>', { value: province[index].provinceName, text: province[index].provinceName }));
            });
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
function getCityMunicipalities() {
    $.ajax({
        url: API_URL + "CityMunicipality/GetList",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            $(data).each(function (index) {
                var cityMunicipality = data;
                $("#citymunicipality").append($('<option/>', { value: cityMunicipality[index].cityMunicipalityName, text: cityMunicipality[index].cityMunicipalityName }));
            });
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
function getBarangaysByCityMunicipality(/*callback*/) {
    console.log("List of Barangays");
    $("#citymunicipality").on('change', function () {
        $("#barangay option:not(:first)").remove();
        if (!$(this).children('option:first-child').is(':selected')) {
            $.ajax({
                url: API_URL + "Barangay/GetList/CityMunicipalityBarangays",
                type: "GET",
                dataType: 'json',
                data: { 'cityMunicipalityName': $("#citymunicipality").val() },
                contentType: 'application/json',
                success: function (data) {
                    $(data).each(function (index) {
                        var barangay = data;
                        $("#barangay").append($('<option/>', { value: barangay[index].barangayName, text: barangay[index].barangayName }));
                    });
                },
                //complete: function () {
                //    if (callback) { callback(); }
                //},
                error: function (error) {
                    console.log('Error: ', error);
                    Toast.fire({
                        icon: 'error',
                        title: 'Could not connect to the server!'
                    });
                }
            });
        }
        //else {
        //    $("#barangay option:not(:first)").remove();
        //}
    })
}
/*need changes*/
function getStudentInfo(studentId) {
    let major;
    let barangay;
    $.ajax({
        url: API_URL + "Student/Get/" + studentId,
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            console.log(JSON.stringify(data));
            $("#studentId").val(data.studentId);
            $("#studentIDNo").val(data.studentNo);
            $("#lrn").val(data.lrnno);
            $("#firstname").val(data.person.firstName);
            $("#lastname").val(data.person.lastName);
            $("#middlename").val(data.person.middleName);
            $("#maidenname").val(data.person.maidenName);
            $("#yearLevel").val(data.yearLevel);
            $("#nameextension").val(data.person.nameExtension);
            $("#birthdate").val(moment(data.person.birthDate).format('MM/DD/YYYY')).change();
            $("#birthplace").val(data.person.birthPlace);
            //$("#age").val();
            $("#gender").val(data.person.gender.genderName).change();
            $("#civilstatus").val(data.person.civilStatus.civilStatusType).change();
            $("#citizenship").val(data.person.citizenship.citizenshipStatus).change();
            $("#country").val(data.person.country.countryName).change();
            $("#telephonenumber").val(data.person.telephoneNo);
            $("#mobilenumber").val(data.person.mobileNo);
            $("#email").val(data.person.emailAddress);
            $("#houseblocklotno").val(data.person.address.houseBlkLotNo);
            $("#street").val(data.person.address.street);
            $("#subdivisionvillage").val(data.person.address.subdivisionVillage);
            $("#province").val(data.person.address.province.provinceName).change();
            $("#addresstype").val(data.person.address.addressType.addressTypeName);
            $("#program").val(data.program.programName).change();
            $("#citymunicipality").val(data.person.address.cityMunicipality.cityMunicipalityName).change();
            major = data.major.majorName;
            barangay = data.person.address.barangay.barangayName;
        },
        complete: function () {
            $("#major").text(major).prop('selected', true);
            $("#barangay").val(barangay).attr('selected', 'selected');
            $("#createUpdateStudentModal").modal('show');
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

function setAge() {
    $("#bddatepicker").on('change.datetimepicker', ({ date, oldDate }) => {
        console.log("Old Date:" + moment(oldDate).format("MM/DD/YYYY"));
        console.log("New Date:" + moment(date).format("MM/DD/YYYY"));
        $("#age").val("");
        $("#age").prop('disabled', false);
        var age = moment().diff(moment(date).format('L'), "years");
        $("#age").val(age);
        $("#age").prop('disabled', true);
    });
}
//POST Functions
function addStudent(student) {
    console.log("From add student: " + JSON.stringify(student));
    $.ajax({
        url: API_URL + "Student/Add",
        type: 'POST',
        accepts: 'application/json',
        data: JSON.stringify(student),
        contentType: 'application/json',
        success: function (data) {
            Swal.fire(
                'Success!',
                'Student added successfully!',
                'success'
            )
            clear();
            $("#student-info-tab").prop('active', true);
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
//Update Functions
function updateStudent(student) {
    $.ajax({
        url: API_URL + 'Student/Edit',
        type: 'PUT',
        accepts: 'application/json',
        data: JSON.stringify(student),
        contentType: 'application/json',
        success: function (data) {
            Swal.fire(
                'Success!',
                'Student info successfully updated!',
                'success'
            )
            clear();
            $("#student-info-tab").prop('active', true);
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



function clear() {
    $("#studentIDNo").val("");
    $("#studentIDNo").val(moment().format("YYYY") + "-" + newGuid());

    $("#lrn").val("");
    $("#firstname").val("");
    $("#lastname").val("");
    $("#middlename").val("");
    $("#maidenname").val("");
    $("#nameextension").val("");
    $('#bddatepicker').datetimepicker({
        format: 'L',
        defaultDate: '01/01/2022',
    });
    $("#birthplace").val("");
    $("#age").val("");
    $("#gender").val($("#gender option:first").val());
    $("#civilstatus").val($("#civilstatus option:first").val());
    $("#citizenship").val($("#citizenship option:first").val());
    $("#country").val($("#country option:first").val());
    $("#telephonenumber").val("");
    $("#mobilenumber").val("");
    $("#email").val("");
    $("#houseblocklotno").val("");
    $("#street").val("");
    $("#subdivisionvillage").val("");
    $("#barangay").val($("#barangay option:first").val());
    $("#citymunicipality").val($("#citymunicipality option:first").val());
    $("#province").val($("#province option:first").val());
    $("#addresstype").val($("#addresstype option:first").val());
    $("#program").val($("#program option:first").val());
    $("#major").val($("#major option:first").val());
}