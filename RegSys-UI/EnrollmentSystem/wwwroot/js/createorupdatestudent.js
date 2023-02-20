

$(document).ready(function () {
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

    /*go back to manage student*/
    $("#goBack").click(function () {
        console.log('manage student');
        window.location.href = "ManageStudents";
    });
   

    //addStudentBtn
    $("#saveBtn").click(function () {
        var student = {
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
            yearLevel: "1st Year",
            isActive:true
        }
        console.log(JSON.stringify(student));
        addStudent(student);
    });
    //Clear the modal form
   

});





//GET Functions
function getPrograms() {
    $.ajax({
        url:API_URL + "Program/GetList",
        type:"GET",
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
        $("#major option:not(:first)").remove();
        if (!$(this).children('option:first-child').is(':selected')) {
            console.log($("#program").val());
            $.ajax({
                url: API_URL + "Program/GetList/Majors",
                type: "GET",
                dataType: 'json',
                data: { 'programName': $("#program").val() },
                contentType: 'application/json',
                success: function (data) {
                    console.log('Majors: ' + data)
                    $(data).each(function (index) {
                        var majors = data;
                        console.log('data: ', majors[index].major.majorName);
                        $("#major").append($('<option/>', { value: majors[index].major.majorName, text: majors[index].major.majorName }));
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
        else {         
                $("#major option:not(:first)").remove();           
        }
    });
}
function getBarangaysByCityMunicipality() {
    console.log("List of Barangays");
    $("#citymunicipality").on('change', function(){
        $("#barangay option:not(:first)").remove();
        if (!$("#citymunicipality").children('option:first-child').is(':selected')) {
            $.ajax({
                url: API_URL + "Barangay/GetList/CityMunicipalityBarangays",
                type: "GET",
                dataType: 'json',
                data: { 'cityMunicipalityName': $("#citymunicipality").val() },
                contentType: 'application/json',
                success: function (data) {
                    $(data).each(function (index) {
                        var barangay = data;
                        console.log("Barangays: " + barangay);
                        $("#barangay").append($('<option/>', { value: barangay[index].barangayName, text: barangay[index].barangayName }));
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

    })      
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
function setAge() {
        $("#bddatepicker").on('change.datetimepicker', ({ date, oldDate }) => {
            console.log("Old Date:" + moment(oldDate).format("MM/DD/YYYY"));
            console.log("New Date:" + moment(date).format("MM/DD/YYYY"));
            $("#age").val("");
            $("#age").prop('disabled', false);
            var age = moment().diff(moment(date).format('L'),"years");
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
        data:JSON.stringify(student),
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
function updateStudent(student)
{
   


            
}

function openUpdateStudentForm(student) {
    $("#studentIDNo").val();
    $("#lrn").val();
    $("#firstname").val();
    $("#lastname").val();
    $("#middlename").val();
    $("#maidenname").val();
    $("#nameextension").val();
    $("#birthdate").val();
    $("#birthplace").val();
    $("#age").val();
    $("#gender").val();
    $("#civilstatus").val();
    $("#citizenship").val();
    $("#country").val();
    $("#telephonenumber").val();
    $("#mobilenumber").val();
    $("#email").val();
    $("#houseblocklotno").val();
    $("#street").val();
    $("#subdivisionvillage").val();
    $("#barangay").find(":selected").text();
    $("#citymunicipality").find(":selected").text();
    $("#province").find(":selected").text();
    $("#addresstype").val();
    $("#program").find(":selected").text();
    $("#major").find(":selected").text();
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


  

