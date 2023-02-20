var blockFormValidator;
var currentBlockSubjectsTable;
var subjectsNotInBlockTable

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
    console.log('manage block handler executed');
    $('[data-toggle="tooltip"]').tooltip();             //enable bootstrap tooltip
    getActiveBlockList();                                //load tuitionfeerate list
    getPrograms();
    getMajorByProgram();
    getTerms();
    getSemesters();
    //getFeeTypes();
    //initialize form validator
    $.validator.setDefaults({
        submitHandler: function () {
            submitBlock();
        }
    });
    blockFormValidator = $('#blockForm').validate({
        rules: {
            blockname: {
                required: true
            },
            blockprogram: {
                required: true
            }
            ,
            blockmajor: {
                required: true
            }
            ,
            blockterm: {
                required: true
            }
            ,
            blocksemester: {
                required: true
            }
        },
        messages: {
            blockname: {
                required: "Please enter block name."
            },
            blockprogram: {
                required: "Please select program."
            }
            ,
            blockmajor: {
                required: "Please select major."
            }
            ,
            blockterm: {
                required: "Please select term."
            }
            ,
            blocksemester: {
                required: "Please select semester."
            }
        },
        errorElement: 'span',
        errorPlacement: function (error, element) {
            error.addClass('invalid-feedback');
            element.closest('.form-group').append(error);
        },
        highlight: function (element, errorClass, validClass) {
            $(element).addClass('is-invalid');
        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).removeClass('is-invalid');
        }
    });
});
//Get
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
                $("#blockProgram").append($('<option/>', { value: programs[index].programId, text: programs[index].programName }));
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
    $("#blockProgram").on('change', function () {
        $("#blockMajor option:not(:first)").remove();
        if (!$(this).children('option:first-child').is(':selected')) {
            console.log("Selected Program: " + $('#blockProgram').find(':selected').val().trim());
            $.ajax({
                url: API_URL + "Program/GetList/Majors",
                type: "GET",
                dataType: 'json',
                data: { 'programName': $('#blockProgram').find(':selected').text().trim() },
                contentType: 'application/json',
                success: function (data) {
                    console.log('Majors: ' + data)
                    $(data).each(function (index) {
                        var majors = data;
                        console.log('data: ', majors[index].major.majorName + majors[index].major.majorId);
                        $("#blockMajor").append($('<option/>', { value: majors[index].major.majorId, text: majors[index].major.majorName }));
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
            $("#blockMajor option:not(:first)").remove();
        }
    });
}
function getTerms() {
    $.ajax({
        url: API_URL + "Term/GetList",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            $(data).each(function (index) {
                var terms = data;
                $("#blockTerm").append($('<option/>', { value: terms[index].termId, text: terms[index].termCode }));
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
function getSemesters() {
    $.ajax({
        url: API_URL + "Semester/GetList",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            $(data).each(function (index) {
                var semesters = data;
                $("#blockSemester").append($('<option/>', { value: semesters[index].semesterId, text: semesters[index].semesterName }));
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
//display active fee rate
function getActiveBlockList() {
    $.ajax({                                        //connect to the API via AJAX
        url: API_URL + 'Block/GetActive',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {                  //data (in JSON form) contains the list of college records retrieved from the API
            var blockData = data;
            console.log('data: ', blockData);
            //for each tuitionfeerate record, convert to datatable set
            var blockSet = [];
            $(blockData).each(function (index, item) {
                var addSubjectAction = '<a href="#" onclick="openBlockSubjectModal(\'add\',' + blockData[index].blockId + ',\'' + blockData[index].blockName + '\',\'' + blockData[index].program + '\',\'' + blockData[index].major + '\',\'' + blockData[index].term + '\',\'' + blockData[index].semester + '\')" data-toggle="tooltip" data-placement="top" title="Add Block Subject"><i class="fa-solid fa-plus text-success"></i></a>';
                var editAction = '<a href="#" onclick="openBlockModal(' + blockData[index].blockId + ',\'' + blockData[index].blockName + '\',\'' + blockData[index].program + '\',\'' + blockData[index].major + '\',\'' + blockData[index].term + '\',\'' + blockData[index].semester + '\')" data-toggle="tooltip" data-placement="top" title="Edit"><i class="fa fa-edit fa-icon-link text-success"></i></a>';
                var deactivateAction = '<a href="#" onclick="openConfirmModal(\'deactivate\',' + blockData[index].blockId + ',\'' + blockData[index].blockName + '\')" data-toggle="tooltip" data-placement="top" title="Deactivate"><i class="fa fa-remove fa-icon-link text-success"></i></a>';
                var deleteAction = '<a href="#" onclick="openConfirmModal(\'delete\',' + blockData[index].blockId + ',\'' + blockData[index].blockName + '\')" data-toggle="tooltip" data-placement="top" title="Delete"><i class="fa fa-trash fa-icon-link text-success"></i></a>';
                var blockRecord = new Array(blockData[index].blockId, blockData[index].blockName, blockData[index].program, blockData[index].major, blockData[index].term, blockData[index].semester, addSubjectAction + editAction + deactivateAction + deleteAction);
                blockSet.push(blockRecord);
            });
            //initialize datatable with the data set
            $('#tblActiveBlock').DataTable({
                destroy: true,
                paging: true,
                lengthChange: true,
                searching: true,
                ordering: true,
                info: true,
                autoWidth: false,
                responsive: true,
                columns: [
                    { title: "Block ID", defaultContent: "N/A" },
                    { title: "Block Name", defaultContent: "N/A" },
                    { title: "Program", defaultContent: "N/A" },
                    { title: "Major", defaultContent: "N/A" },
                    { title: "School Year", defaultContent: "N/A" },
                    { title: "Semester", defaultContent: "N/A" },
                    { title: "", orderable: false }                     //disable sorting
                ],
                columnDefs: [
                    { className: 'text-center', targets: [1, 6] },      //center align selected columns
                    { visible: false, targets: [0] }                    //hide first column
                ],
                data: blockSet
            });
            $('[data-toggle="tooltip"]').tooltip();                     //enable bootstrap tooltip for datatable entries
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
//this function will get the deactivted block records from the API
function getInactiveBlockList() {
    $.ajax({                                        //connect to the API via AJAX
        url: API_URL + 'Block/GetInactive',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {                  //data (in JSON form) contains the list of college records retrieved from the API
            var blockData = data;
            console.log('data: ', blockData);
            //for each tuitionfeerate record, convert to datatable set
            var blockSet = [];
            $(blockData).each(function (index, item) {
                //var editAction = '<a href="#" onclick="openFeeRateModal(' + blockData[index].blockId + ',\'' + blockData[index].blockName + '\',\'' + blockData[index].program + '\',\'' + blockData[index].major + '\',\'' + blockData[index].term + '\',\'' + blockData[index].semester + '\')" data-toggle="tooltip" data-placement="top" title="Edit"><i class="fa fa-edit fa-icon-link"></i></a>';
                var activateAction = '<a href="#" onclick="openConfirmModal(\'activate\',' + blockData[index].blockId + ',\'' + blockData[index].blockName + '\')" data-toggle="tooltip" data-placement="top" title="Activate"><i class="fa fa-remove fa-icon-link"></i></a>';
                //var deleteAction = '<a href="#" onclick="openConfirmModal(\'delete\',' + blockData[index].blockId + ',\'' + blockData[index].blockName + '\')" data-toggle="tooltip" data-placement="top" title="Delete"><i class="fa fa-trash fa-icon-link"></i></a>';
                var blockRecord = new Array(blockData[index].blockId, blockData[index].blockName, blockData[index].program, blockData[index].major, blockData[index].term, blockData[index].semester, activateAction);
                blockSet.push(blockRecord);
            });
            //initialize datatable with the data set
            $('#tblInactiveBlock').DataTable({
                destroy: true,
                paging: true,
                lengthChange: true,
                searching: true,
                ordering: true,
                info: true,
                autoWidth: false,
                responsive: true,
                columns: [
                    { title: "Block ID", defaultContent: "N/A" },
                    { title: "Block Name", defaultContent: "N/A" },
                    { title: "Program", defaultContent: "N/A" },
                    { title: "Major", defaultContent: "N/A" },
                    { title: "School Year", defaultContent: "N/A" },
                    { title: "Semester", defaultContent: "N/A" },
                    { title: "", orderable: false }                     //disable sorting
                ],
                columnDefs: [
                    { className: 'text-center', targets: [0, 5] },      //center align selected columns
                    { visible: false, targets: [0] }                    //hide first column
                ],
                data: blockSet
            });
            $('[data-toggle="tooltip"]').tooltip();                     //enable bootstrap tooltip for datatable entries
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
function getSubjectsNotInBlock(blockId, subjectIds) {
    $.ajax({
        url: API_URL + "BlockCourseSchedule/GetList/CourseNotInBlock",
        type: "GET",
        traditional: true,
        dataType: 'json',
        data: { Ids: subjectIds },
        contentType: 'application/json',
        success: function (data) {
            var courseNotInList = [];
            $(data).each(function (index) {
                var courseList = data;
                console.log('data: ', courseList);
                var courseListRecord = new Array(courseList[index].courseScheduleId, courseList[index].courseScheduleId, courseList[index].edpcode, courseList[index].courseCode, courseList[index].courseDescription, courseList[index].units, courseList[index].day, courseList[index].timeStart + " " + courseList[index].midDayTimeStart + " - " + courseList[index].timeEnd + " " + courseList[index].midDayTimeEnd, courseList[index].room);
                courseNotInList.push(courseListRecord);
            });

            var courseTable = $('#tblBlockSubjects').DataTable({
                destroy: true,
                paging: true,
                lengthChange: false,
                searching: true,
                ordering: true,
                info: true,
                autoWidth: false,
                responsive: true,
                columns: [
                    {},
                    { title: "Schedule ID", defaultContent: "" },
                    { title: "EDP Code", defaultContent: "" },
                    { title: "Course Code", defaultContent: "" },
                    { title: "Course Description", defaultContent: "" },
                    { title: "Units", defaultContent: "" },
                    { title: "Day", defaultContent: "" },
                    { title: "Time", defaultContent: "" },
                    { title: "Room", defaultContent: "" }
                ],
                columnDefs: [
                    { className: 'text-center', targets: [1, 2, 3, 4, 5, 6, 7] }, //center align selected columns
                    /*{ className: 'select-checkbox', targets: 0 },*/
                    {
                        'targets': 0,
                        'checkboxes': {
                            'selectRow': true
                        }
                    },
                    { visible: false, targets: [1] }
                ],
                'select': {
                    'style': 'multi'
                },
                'order': [[1, 'asc']],
                data: courseNotInList
            });
            $("#addBlockSubjectBtn").on('click', function () {
                let selected_rows = courseTable.column(0).checkboxes.selected();
                let selectedSchedIds = [];
                $.each(selected_rows, function (index, selectedScheduleId) {
                    selectedSchedIds.push(selectedScheduleId);
                    console.log("Selected Schedules : " + selectedSchedIds);
                });
                let addBlockSubjectDto = {
                    blockId: blockId,
                    courseScheduleIds: selectedSchedIds
                }
                addBlockSubject(addBlockSubjectDto);
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
function getBlockSubjects(blockId) {
    $.ajax({
        url: API_URL + "BlockCourseSchedule/GetList/CourseSchedules",
        type: "GET",
        dataType: 'json',
        data: { "ID": blockId },
        contentType: 'application/json',
        success: function (data) {
            var blockCourses = [];
            var courseIds = []
            $(data).each(function (index) {
                var courseList = data;
                console.log('data: ', courseList);
                courseIds.push(courseList[index].courseSchedules.courseScheduleId);
                var deleteButton = '<a class="deleteBlockSubject"  onclick="deleteBlockSubject(' + blockId + ',' + courseList[index].blockCourseScheduleId + ') " title="Delete this subject"><i class="fa-solid fa-trash-can"></i></a>';
                var courseListRecord = new Array(courseList[index].courseSchedules.courseScheduleId, courseList[index].courseSchedules.courseScheduleId, courseList[index].courseSchedules.edpcode, courseList[index].courseSchedules.courseCode, courseList[index].courseSchedules.courseDescription, courseList[index].courseSchedules.units, courseList[index].courseSchedules.day, moment(courseList[index].courseSchedules.timeStart).format("l") + " " + courseList[index].courseSchedules.midDayTimeStart + " - " + courseList[index].courseSchedules.timeEnd + " " + courseList[index].courseSchedules.midDayTimeEnd, courseList[index].courseSchedules.room, deleteButton);
                blockCourses.push(courseListRecord);
            });

            currentBlockSubjectsTable = $('#tblBlockCurrentSubjects').DataTable({
                destroy: true,
                paging: true,
                lengthChange: false,
                searching: false,
                ordering: true,
                info: true,
                autoWidth: false,
                responsive: true,
                columns: [
                    {},
                    { title: "Schedule ID", defaultContent: "" },
                    { title: "EDP Code", defaultContent: "" },
                    { title: "Course Code", defaultContent: "" },
                    { title: "Course Description", defaultContent: "" },
                    { title: "Units", defaultContent: "" },
                    { title: "Day", defaultContent: "" },
                    { title: "Time", defaultContent: "" },
                    { title: "Room", defaultContent: "" },
                    { title: "Action", defaultContent: "" }
                ],
                columnDefs: [
                    { className: 'text-center', targets: [2, 3, 4, 5, 6, 7, 8, 9] }, //center align selected columns
                    { visible: false, targets: [0, 1] }
                ],
                data: blockCourses
            });
            getSubjectsNotInBlock(blockId, courseIds);
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
function deleteBlockSubject(blockId, blockCourseScheduleId) {
    Swal.fire({
        title: 'Do you want to remove this subject from block?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Remove'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: API_URL + "BlockCourseSchedule/Delete/" + blockCourseScheduleId,
                type: "DELETE",
                dataType: 'json',
                contentType: 'application/json',
                success: function (data) {
                    Swal.fire(
                        'Removed!',
                        'Subject has been remove.',
                        'success'
                    )
                    getBlockSubjects(blockId);
                    getSubjectsNotInBlock(blockId);
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
//this function opens the block modal
function openBlockModal(blockId, blockName, blockProgram, blockMajor, term, semester) {
    clearModalForm();               //reset form
    if (blockId != 0) {			//edit
        console.log('Block to Edit: ' + blockId + ' ' + blockName + ' ' + blockProgram + ' ' + blockMajor + ' ' + term + ' ' + semester);
        $('#operationType').val('edit');
        $('#blockModalTitle').text('Edit Block');
        $('#blockID').val(blockId);
        $('#blockName').val(blockName);
        $('#blockProgram option:contains(' + blockProgram + ')').attr('selected', 'selected').change();
        $('#blockMajor option:contains(' + blockMajor + ')').attr('selected', 'selected');
        $('#blockTerm option:contains(' + term + ')').attr('selected', 'selected');
        $('#blockSemester option:contains(' + semester + ')').attr('selected', 'selected');
    }
    else {                          //add
        $('#operationType').val('add');
        $('#blockModalTitle').text('Add Block');
    }

    //set form data

    $('#manageBlockModal').modal('show'); //show block modal

    $("[data-toggle='tooltip']").tooltip('hide');           //hide dangling bootstrap tooltip
}
//this function opens the block subject modal
function openBlockSubjectModal(operation, blockId, blockName, blockProgram, blockMajor, term, semester) {
    console.log('Block to Edit: ' + blockId + ' ' + blockName + ' ' + blockProgram + ' ' + blockMajor + ' ' + term + ' ' + semester);
    $('#operationType').val('edit');
    $('#blockSubjectModalTitle').text('Add Subject');
    $('#blockSubjectID').val(blockId);
    $('#manageBlockSubjectModal #blockName').val(blockName);
    $('#manageBlockSubjectModal #blockProgram').val(blockProgram);
    $('#manageBlockSubjectModal #blockMajor').val(blockMajor).val(blockMajor);
    $('#manageBlockSubjectModal #blockTerm').val(term);
    $('#manageBlockSubjectModal #blockSemester').val(semester);
    $('#manageBlockSubjectModal').modal('show'); //show block modal
    console.log("Modal Shown");
    $("#manageBlockSubjectModal").ready(function () {
        getBlockSubjects(blockId);
    });
    console.log("Display Courses not in Block");

    //$("[data-toggle='tooltip']").tooltip('hide');           //hide dangling bootstrap tooltip
}
function addBlockSubject(addBlockCourseSchedDto) {
    $.ajax({
        url: API_URL + "BlockCourseSchedule/Add",
        type: "POST",
        data: JSON.stringify(addBlockCourseSchedDto),
        dataType: 'json',
        contentType: 'application/json',
        success: function () {
            Swal.fire(
                'Success!',
                "Subjects has been added successfully!",
                'success'
            )

            getBlockSubjects(JSON.stringify(addBlockCourseSchedDto.blockId))
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
//this function handles the add/edit submission of block record to the API
function submitBlock() {
    var message;

    console.log('submit block');
    if ($('#blockForm').valid()) {                        //check if form is valid
        console.log('Form is valid');
        var blockDto = {                                 //get form data
            blockID: $('#blockID').val().trim(),
            blockName: $('#blockName').val().trim(),
            programId: $('#blockProgram').find(':selected').val().trim(),
            majorId: $('#blockMajor').find(':selected').val().trim(),
            termId: $('#blockTerm').find(':selected').val().trim(),
            semesterId: $('#blockSemester').find(':selected').val().trim(),
            isActive: true
        };
        var submitUrl = API_URL + 'block/add';            //add URL
        var operation = $('#operationType').val();
        var httpType = 'POST';

        if (operation == 'edit') {          //edit
            submitUrl = API_URL + 'block/edit';           //edit URL
            httpType = 'PUT';
        }

        console.log('data to submit: ', blockDto);
        console.log('url: ' + submitUrl);
        console.log('operation: ' + $('#operationType').val());

        $.ajax({                                            //submit data to the API via AJAX
            method: httpType,
            accepts: 'application/json',
            contentType: 'application/json',
            url: submitUrl,
            data: JSON.stringify(blockDto),
            success: function (response) {
                console.log('response: ', response);
                $('#blockModal').modal('hide');
                if (operation == 'add')
                    message = 'Block added successfully!';
                else
                    message = 'Block updated successfully!';
                console.log('Success: ' + message);
                getActiveBlockList();
                Swal.fire(
                    'Success!',
                    message,
                    'success'
                )
                //reload block list
            },
            error: function (error) {
                console.log('Error: ', error);
                if (error.status == 400 || error.status == 404)
                    message = error.responseJSON.result;           //error message from the API
                else
                    message = 'Could not connect to the server!';
                console.log('Error: ' + message);
                Toast.fire({
                    icon: 'error',
                    title: message
                });
            }
        });
    }
}

function openConfirmModal(confirmType, blockID, blockName) {
    var title = confirmType.charAt(0).toUpperCase() + confirmType.slice(1);     //capitalize first letter for the modal heading
    var message = `Are you sure you want to ${confirmType} ${blockName}?`;
    $('#confirmModal').modal('show');
    $('#confirmModal').modal({                                                  //show alert modal with the corresponding heading and message
        backdrop: 'static',
        keyboard: false
    });
    $("[data-toggle='tooltip']").tooltip('hide');       //hide dangling bootstrap tooltip
    $('#confirmType').val(confirmType);                 //set confirm type
    $('#recordID').val(blockID);                       //set record ID
    $('#confirmModalTitle').text(title);
    $('.confirm-modal-content').text(message);
}

//this function handles the deletion/deactivation/activation of college record to the API
function handleConfirm() {
    var blockID = $('#recordID').val();           //get tuitionfeerate ID from the confirm modal
    var confirmType = $('#confirmType').val();      //get confirm type from the confirm modal
    var confirmUrl = API_URL + 'block/' + confirmType + '/' + blockID;     //confirm URL
    var httpType = 'DELETE';
    var message;

    console.log(`Block ID to ${confirmType}:` + blockID);
    console.log('Confirm url: ' + confirmUrl);

    if (confirmType != 'delete')
        httpType = 'PUT';

    $.ajax({
        method: httpType,
        accepts: 'application/json',
        contentType: 'application/json',
        url: confirmUrl,
        success: function (response) {
            console.log('response: ', response);
            $('#confirmModal').modal('hide');
            if (confirmType == 'deactivate')
                message = 'Block deactivated successfully!'
            else if (confirmType == 'activate')
                message = 'Block activated successfully!'
            else
                message = 'Block deleted successfully!'
            console.log('Success: ' + message);
            Swal.fire(
                'Success!',
                message,
                'success'
            )
            if (confirmType == 'activate')
                getInactiveBlockList();                 //reload inactive tuitionfeerate list
            else
                getActiveBlockList();                       //reload tuitionfeerate list
        },
        error: function (error) {
            console.log('Error: ', error);
            if (error.status == 404)
                message = error.responseJSON.result;            //error message from the API
            else
                message = 'Could not connect to the server!';
            console.log('Error: ' + message);
            Toast.fire({
                icon: 'error',
                title: message
            });
        }
    });
}

function clearModalForm() {
    if (blockFormValidator != null) {
        blockFormValidator.resetForm();
        if ($("input").hasClass("is-invalid"))
            $("input").removeClass("is-invalid");
        console.log("form cleared");
    }
}