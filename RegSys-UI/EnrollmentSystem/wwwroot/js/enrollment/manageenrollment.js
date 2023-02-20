var enrollmentHistoryTable;
var blockCourseTable;
var courseTable;
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
    console.log("Enrollment Student Module");
    getEnrolleeList();

    $("#enrollmentNo").val(moment().format("YYYY") + "-" + newGuid());
    $("#enrollmentNo").prop('disabled', true);
    $('#courseEnrollmentModal .modal-body #studentName').prop('disabled', true);
    $('#courseEnrollmentModal .modal-body #studentId').prop('disabled', true);
    $('#courseEnrollmentModal .modal-body #studentNo').prop('disabled', true);
    $('#courseEnrollmentModal .modal-body #program').prop('disabled', true);
    $('#courseEnrollmentModal .modal-body #major').prop('disabled', true);
    $('#courseEnrollmentModal .modal-body #yearLevel').prop('disabled', true);
    $('#courseEnrollmentModal .modal-body #schoolYear').prop('disabled', true);
    $('#courseEnrollmentModal .modal-body #semester').prop('disabled', true);
    $("#enrollmentDate").val(moment().format('MM/DD/YYYY'));
    $("#enrollmentDate").prop('disabled', true);
    getCurrentTerm();
    getCurrentSemester();  

    $("#courseEnrollmentModal").on('hidden.bs.modal', function () {
        $('#enrolledCourseList tbody').empty();
        courseTable.destroy('default', false);
        blockCourseTable.destroy('default', false);
        $("#offeredCourseTableList tbody").empty()
        $("#enrollStudentButton").prop("onclick", null).off("click");
    });
});
//Get the list of block filtered by program and major.
function getCurrentBlockByProgramAndMajor(filter) {
    $("#blocks option:not(:first)").remove();
    $.ajax({
        url: API_URL + "Block/GetList/Program/Major/Blocks",
        method: "GET",
        traditional: true,
        data: filter,
        dataType: "json",
        contentType: "application/json",
        success: function (data) {
            //Populate select box for blocks then display block courses.
            $(data).each(function (index) {
                var blocks = data;
                console.log('blocks data: ', blocks);
                $("#blocks").append($('<option/>', { value: blocks[index].blockId, text: blocks[index].blockName }));
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
//Get the current active term.
function getCurrentTerm() {
    $.ajax({
        url: API_URL + "Term/GetCurrentTerm",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            console.log("Term: " + JSON.stringify(data));
            var term = data;
            $("#activeTermId").val(term.termId);
            $("#schoolYear").val(term.termCode);
        }
    });
}
//Get the current active semester.
function getCurrentSemester() {
    $.ajax({
        url: API_URL + "Semester/CurrentSemester",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            console.log("Semester: " + JSON.stringify(data));
            var semester = data;

            $("#activeSemId").val(semester.semesterId);
            $("#semester").val(semester.semesterName);
        }
    })
}
//Get the list of enrollees.
function getEnrolleeList() {
    $.ajax({
        url: API_URL + "Student/GetList/Enrollees",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            let enrolleeList = [];
            $(data).each(function (index) {
                var enrollees = data;
                console.log('Enrollees DATA: ', enrollees);
                console.log(enrollees[index]);

                var enrollButton = '<a class="enrollStudent" onclick="openEnrollmentModal(\'' + enrollees[index].studentId + '\',\'' + enrollees[index].fullName + '\',\'' + enrollees[index].studentNo + '\',\'' + enrollees[index].course + '\',\'' + enrollees[index].programId + '\',\'' + enrollees[index].major + '\',\'' + enrollees[index].majorId + '\',\'' + enrollees[index].yearLevel + '\')" title="Enroll Student"><i class="fa-solid fa-person-booth text-success"></i></a>';
                var viewDetailsButton = '<a class="viewDetails"  onclick="openEnrollmentInfoForm(\'' + enrollees[index].studentId + '\',\'' + enrollees[index].fullName + '\',\'' + enrollees[index].studentNo + '\',\'' + enrollees[index].course + '\',\'' + enrollees[index].major + '\',\'' + enrollees[index].yearLevel + '\')" title="View Details"><i class="fa-solid fa-circle-info fa-icon-link"></i></a>';

                var enrolleesRecord = new Array(enrollees[index].studentNo, enrollees[index].fullName, enrollees[index].course, enrollees[index].major, enrollees[index].yearLevel, enrollButton + viewDetailsButton);
                enrolleeList.push(enrolleesRecord);
            });

            $('#enrolleesTable').DataTable({
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
//Get the list of students enrollment
function getStudentEnrollmentsByStudentId(studentId) {
    $.ajax({
        url: API_URL + "Student/GetList/Enrollments",
        type: "GET",
        dataType: 'json',
        data: { studentID: studentId },
        contentType: 'application/json',
        success: function (data) {
            var enrollmentList = [];
            $(data).each(function (index) {
                var studentEnrollments = data;
                var enrollmentInfo = '<a class="enrollment-info mr-2" onclick="displayEnrollmentCourseScheduleInfo(\'' + studentEnrollments[index].enrollmentId + '\',\'' + "#enrollmentCourseList" + '\')" title="More Info"><i class="fa-solid fa-circle-info text-info"></i></a>';
                //var updateEnrollment = '<a class="update-enrollment mr-2" title="Update Enrollment"><i class="fa-solid fa-pen-to-square text-success"></i></a>';    
                var updateEnrollment = '<a class="update-enrollment mr-2" title="More Info"><i class="fa-solid fa-pen-to-square text-success"></i></a>';
                var deleteEnrollment = '<a class="delete-enrollment" onclick="deleteEnrollment(\'' + studentEnrollments[index].enrollmentId + '\',\'' + studentId + '\')" title="Delete Enrollment"><i class="fa-solid fa-trash-can text-danger  "></i></a>';
                
                console.log('studentEnrollments ', studentEnrollments);
                var enrollmentListRecord = new Array(studentEnrollments[index].enrollmentId, studentEnrollments[index].enrollmentNo, moment(studentEnrollments[index].enrollmentDate).format("MM/DD/YYYY"), studentEnrollments[index].term, studentEnrollments[index].semester, enrollmentInfo + updateEnrollment);
                enrollmentList.push(enrollmentListRecord);
            });
            enrollmentHistoryTable = $('#enrollmentHistoryTableList').DataTable({
                destroy: true,
                paging: true,
                lengthChange: false,
                searching: false,
                ordering: true,
                info: true,
                autoWidth: false,
                responsive: true,
                columns: [
                    { title: "Enrollment ID", defaultContent: "" },
                    { title: "Enrollment No.", defaultContent: "" },
                    { title: "Enrollment Date", defaultContent: "" },
                    { title: "School Year", defaultContent: "" },
                    { title: "Semester", defaultContent: "" },
                    { title: "", defaultContent: "" }
                ],
                columnDefs: [
                    { className: 'text-center', targets: [0, 1, 2, 3, 4] }, //center align selected columns
                    { visible: false, targets: [0] }
                ],
                data: enrollmentList
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


//Get the list of subject schedules that belong to a block and display it in table.
function getBlockCourseSchedules(blockId) {
    $('#courseEnrollmentModal .courseTable').append('<table id="offeredCourseTableList" class="dataTable data-table-width compact hover row-border stripe"></table>');
    var courses;
    $.ajax({
        url: API_URL + "BlockCourseSchedule/GetList/CourseSchedules",
        type: "GET",
        dataType: 'json',
        data: { "ID": blockId },
        contentType: 'application/json',
        success: function (data) {
            courses = data;
            var offeredCourseList = [];
            $(data).each(function (index) {
                var courseList = data;
                var courseListRecord = new Array(courseList[index].courseSchedules.courseScheduleId, courseList[index].courseSchedules.edpcode, courseList[index].courseSchedules.courseCode, courseList[index].courseSchedules.courseDescription, courseList[index].courseSchedules.units, courseList[index].courseSchedules.day, courseList[index].courseSchedules.timeStart + " " + courseList[index].courseSchedules.midDayTimeStart + " - " + courseList[index].courseSchedules.timeEnd + " " + courseList[index].courseSchedules.midDayTimeEnd, courseList[index].courseSchedules.room);
                offeredCourseList.push(courseListRecord);
            });

            blockCourseTable = $('#offeredCourseTableList').DataTable({
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
                    { title: "EDP Code", defaultContent: "" },
                    { title: "Course Code", defaultContent: "" },
                    { title: "Course Description", defaultContent: "" },
                    { title: "Units", defaultContent: "" },
                    { title: "Day", defaultContent: "" },
                    { title: "Time", defaultContent: "" },
                    { title: "Room", defaultContent: "" }
                ],
                columnDefs: [
                    { className: 'text-center', targets: [0, 1, 2, 3, 4, 5, 6] }, //center align selected columns
                    //{ visible: false, targets: [0] }
                    {
                        'targets': 0,
                        'checkboxes': {
                            'selectRow': true
                        }
                    }
                    /*{ visible: false, targets: [1] }*/
                ],
                'select': {
                    'style': 'multi'
                },
                'order': [[1, 'asc']],
                data: offeredCourseList
            });

            let blockId = $("#blocks").find(":selected").val();
            $("#enrollStudentButton").on('click', function () {
                var selected_rows = blockCourseTable.column(0).checkboxes.selected();
                var Ids = [];
                $.each(selected_rows, function (index, scheduleId) {
                    //params.courseScheduleIds.push(scheduleId);
                    Ids.push(scheduleId);
                    // Ids.push(scheduleId);
                    console.log(Ids);
                })
                let enrollmentDto = {
                    enrollmentNo: $("#enrollmentNo").val(),
                    isActive: true,
                    studentId: $("#studentId").val(),
                    termId: $("#activeTermId").val(),
                    semesterId: $("#activeSemId").val()
                }
                /*console.log("Enrollment Data: " + JSON.stringify(enrollmentDto));*/
                addEnrollment(enrollmentDto, Ids);
                $("#enrollStudentButton").prop("onclick", null).off("click");
            })
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
//Get the list of offered subject schedules and display it in a table.
function getOfferedCourseList() {
    $.ajax({
        url: API_URL + "CourseSchedule/GetList/CurrentOfferedCourses",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            var offeredCourseList = [];
            $(data).each(function (index) {
                var courseList = data;
                //var hiddenId = '<input type="hidden" name="schedId" value="'+ courseList[index].courseScheduleId +'" id="scheduleId">'
                //var checkBox = '<input class="row-checkbox" type="checkbox" value="' + courseList[index].courseScheduleId + '" id="courseCheckBox">'
                var courseListRecord = new Array(courseList[index].courseScheduleId, courseList[index].courseScheduleId, courseList[index].edpcode, courseList[index].courseCode, courseList[index].courseDescription, courseList[index].units, courseList[index].day, courseList[index].timeStart + " " + courseList[index].midDayTimeStart + " - " + courseList[index].timeEnd + " " + courseList[index].midDayTimeEnd, courseList[index].room);
                offeredCourseList.push(courseListRecord);
            });
            var courseTable;
            courseTable = $('#offeredCourseTableList').DataTable({
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
                data: offeredCourseList
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
//Opens the Enrollment Modal
function openEnrollmentModal(studentId, fullName, studentNo, course, courseId, major, majorId, yearLevel) {
    //Filter for displaying blocks by program and major.
    var filter = {
        programId: courseId,
        majorId: majorId,
        termId: $("#activeTermId").val(),
        semesterId: $("#activeSemId").val()
    }
    console.log("Filter DATA: " + JSON.stringify(filter));
    //Displays the list of block of a particular program and major.
    getCurrentBlockByProgramAndMajor(filter);
    console.log("Filter Data: " + JSON.stringify(filter));
    $('#courseEnrollmentModal .modal-body #studentName').val(fullName);
    $('#courseEnrollmentModal .modal-body #studentId').val(studentId);
    $('#courseEnrollmentModal .modal-body #studentNo').val(studentNo);
    $('#courseEnrollmentModal .modal-body #program').val(course);
    $('#courseEnrollmentModal .modal-body #major').val(major);
    $('#courseEnrollmentModal .modal-body #yearLevel').val(yearLevel);
    //Shows the modal
    $('#courseEnrollmentModal').modal('show');
    //Display the subjects of a specific block when the select value is changed.
    $("#blocks").on("change", function () {
        if (!$(this).children('option:first-child').is(':selected')) {
            getBlockCourseSchedules($(this).val());
        }
    });
    //Sets value for printing.
    $(".toprint .enrollmentDate").text($("#courseEnrollmentModal #enrollmentDate").val());
    $(".toprint .schoolYear").text($("#courseEnrollmentModal #schoolYear").val());
    $(".toprint .semester").text($("#courseEnrollmentModal #semester").val());
    $(".toprint .enrollmentNo").text($("#courseEnrollmentModal #enrollmentNo").val());
    $(".toprint .course").text($("#courseEnrollmentModal #program").val());
    $(".toprint .major").text($("#courseEnrollmentModal #major").val());
    $(".toprint .studentName").text($("#courseEnrollmentModal #studentName").val());
    $(".toprint .year").text($("#courseEnrollmentModal #yearLevel").val());
}
//Opens the enrollment info form and display the history of enrollments of a student.
function openEnrollmentInfoForm(studentId, fullName, studentNo, course, major, yearLevel) {

    //Sets value for printing.
    $("#studentEnrollmentInfoModal #studentId").val(studentId);
    $("#studentEnrollmentInfoModal #studentName").val(fullName);
    $("#studentEnrollmentInfoModal #studentNo").val(studentNo);
    $("#studentEnrollmentInfoModal #program").val(course);
    $("#studentEnrollmentInfoModal #major").val(major);
    $("#studentEnrollmentInfoModal #yearLevel").val(yearLevel);
    //Shows the modal
    $("#studentEnrollmentInfoModal").modal("show");
    //Sets value for printing.
    $(".toprint .course").text($("#studentEnrollmentInfoModal #program").val());
    $(".toprint .major").text($("#studentEnrollmentInfoModal #major").val());
    $(".toprint .studentName").text($("#studentEnrollmentInfoModal #studentName").val());
    $(".toprint .year").text($("#studentEnrollmentInfoModal #yearLevel").val());
    //Should be change to get enrollment by student id
    getStudentEnrollmentsByStudentId($('#studentEnrollmentInfoModal #studentId').val());
    //getEnrollmentCourseScheduleByStudentId($('#studentEnrollmentInfoModal #studentId').val());
}
//Add a new enrollment for student.
function addEnrollment(enrollmentDto, courseSchedIds) {
    $.ajax({
        url: API_URL + 'Enrollment/Add', //+ '?' + $.param({ 'schedIds': schedIds }),
        type: "POST",
        dataType: 'json',
        data: JSON.stringify(enrollmentDto),
        //traditional:true,
        contentType: 'application/json',
        success: function (enrollmentId) {
            console.log("Data: " + JSON.stringify(enrollmentId));
            let enrollment = enrollmentId;
            console.log("EnrollmentID: " + JSON.stringify(enrollment.enrollmendId));
            let enrollmentCourseSched = {
                enrollmentId: enrollmentId,
                courseScheduleIds: courseSchedIds
            }
            addEnrollmentCourseSchedules(enrollmentCourseSched);
        },
        error: function (error) {
            console.log('Error: ', error);
            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: JSON.stringify(error.responseText)
            })
        }
    });
}
//Add a subject schedule in an enrollment.
function addEnrollmentCourseSchedules(enrollmentCourseScheds) {
    $.ajax({
        url: API_URL + 'EnrollmentCourseSchedule/Add' /*+ '?' + $.param({ enrollmentCourseSchedDto: enrollmentCourseScheds })*/,
        type: "POST",
        /*traditional: true,*/
        data: JSON.stringify(enrollmentCourseScheds),
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            Swal.fire({
                icon: 'success',
                title: 'Enrollment Successful',
                text: 'Student Enrolled Successfully!'
            })
            //Display the choosen subjects enrolled by student.
            displayEnrollmentCourseScheduleInfo(enrollmentCourseScheds.enrollmentId, '#enrolledCourseList');
        },
        error: function (error) {
            console.log('Error: ', error);
            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: JSON.stringify(error.responseText)
            })
        }
    });
}
//Delete a specific subject from an enrollment.
function removeCourseFromEnrollment(enrollmentId, id) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: API_URL + 'EnrollmentCourseSchedule/Delete/' + id,
                type: 'DELETE',
                //dataType: 'json',
                //data: JSON.stringify({ id: id }),
                contentType: 'application/json',
                success: function (data) {




                    Swal.fire(
                        'Removed!',
                        'Course has been removed!',
                        'success'
                    )
                    getEnrollmentCourses(enrollmentId);
                },
                error: function (error) {
                    console.log('Error: ', error);
                    Swal.fire({
                        icon: 'error',
                        title: 'Oops...',
                        text: JSON.stringify(error)
                    })
                }
            })
        }
    })
}
function openAddCourseModal() {
    $('#enrollmentCoursesModal').modal('show');
}

//Should be change to get enrollment by student id
function getEnrollmentCourseScheduleByStudentId(studentId) {
    console.log("Executed");
    $.ajax({
        url: API_URL + "EnrollmentCourseSchedule/Student/" + studentId,
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            console.log("Enrollment Block Data: " + JSON.stringify(data));
            var enrollmentList = [];
            $(data).each(function (index) {
                var enrollment = data;
                var enrollmentInfo = '<a class="enrollment-info mr-2" onclick="displayEnrollmentCourseScheduleInfo(\'' + enrollment[index].enrollmentId + '\',\'' + "#enrollmentCourseList" + '\')" title="More Info"><i class="fa-solid fa-circle-info text-info"></i></a>';
                //var updateEnrollment = '<a class="update-enrollment mr-2" title="Update Enrollment"><i class="fa-solid fa-pen-to-square text-success"></i></a>';
                var deleteEnrollment = '<a class="delete-enrollment" onclick="deleteEnrollment(\'' + enrollment[index].enrollmentCourseScheduleId + '\',\'' + enrollment[index].enrollment.studentId + '\')" title="Delete Enrollment"><i class="fa-solid fa-trash-can text-danger  "></i></a>';
                console.log('studentEnrollments ', enrollment);
                $(".toprint .enrollmentDate").text(moment(enrollment[index].enrollment.enrollmentDate).format("MM/DD/YYYY"));
                $(".toprint .semester").text(enrollment[index].enrollment.semester);
                $(".toprint .enrollmentNo").text(enrollment[index].enrollment.enrollmentNo);
                $(".toprint .schoolYear").text(enrollment[index].enrollment.term);
                var enrollmentListRecord = new Array(enrollment[index].enrollmentBlockId, enrollment[index].enrollment.enrollmentNo, moment(enrollment[index].enrollment.enrollmentDate).format("MM/DD/YYYY"), enrollment[index].enrollment.term, enrollment[index].enrollment.semester, enrollmentInfo + deleteEnrollment);
                enrollmentList.push(enrollmentListRecord);
            });

            enrollmentHistoryTable = $('#enrollmentHistoryTableList').DataTable({
                destroy: true,
                paging: true,
                lengthChange: false,
                searching: false,
                ordering: true,
                info: true,
                autoWidth: false,
                responsive: true,
                columns: [
                    { title: "Enrollment Block ID", defaultContent: "" },
                    { title: "Enrollment No.", defaultContent: "" },
                    { title: "Enrollment Date", defaultContent: "" },
                    { title: "School Year", defaultContent: "" },
                    { title: "Semester", defaultContent: "" },
                    { title: "", defaultContent: "" }
                ],
                columnDefs: [
                    { className: 'text-center', targets: [0, 1, 2, 3, 4] }, //center align selected columns
                    { visible: false, targets: [0] }
                ],
                data: enrollmentList
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
function deleteEnrollment(enrollmentCourseSchedId, studentId) {
    alert("EB ID: " + enrollmentCourseSchedId + "ST ID: " + studentId);
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: API_URL + "EnrollmentCourseSchedule/Delete/" + enrollmentCourseSchedId,
                type: "DELETE",
                dataType: "json",
                contentType: 'application/json',
                success: function (data) {
                    getStudentEnrollmentsByStudentId(studentId);
                },
                error: function (error) {
                    console.log('Error: ', error);
                    Toast.fire({
                        icon: 'error',
                        title: 'Could not connect to the server!'
                    });
                }
            })
        }
    })
}
function openUnenrolledCourseModal(enrollmentId, courseIds) {
    console.log("Enrollment ID: " + enrollmentId);
    console.log("Course IDs: " + courseIds);
    $('#displayUnenrolledCourseModal').modal('show');
    getUnenrolledCourses(enrollmentId, courseIds);
}
function getUnenrolledCourses(enrollmentId, courseIds) {
    console.log('Course IDS: ' + courseIds);
    $.ajax({
        type: 'GET',
        url: API_URL + 'Enrollment/GetList/UnenrolledCourses',
        traditional: true,
        dataType: 'json',
        data: { enrolledCourseIds: courseIds },
        contentType: 'application/json',
        success: function (data) {
            var unenrolledCourseList = [];
            $(data).each(function (index) {
                var courseList = data;
                console.log('data: ', courseList);

                var courseListRecord = new Array(courseList[index].courseScheduleId, courseList[index].courseScheduleId, courseList[index].edpcode, courseList[index].courseCode, courseList[index].courseDescription, courseList[index].units, courseList[index].day, courseList[index].timeStart + " " + courseList[index].midDayTimeStart + " - " + courseList[index].timeEnd + " " + courseList[index].midDayTimeEnd, courseList[index].room);
                unenrolledCourseList.push(courseListRecord);
            });
            var courseTable;
            courseTable = $('#unenrolledCoursesTable').DataTable({
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
                data: unenrolledCourseList
            });
            $("#btnEnrollCourse").on('click', function () {
                var selected_rows = courseTable.column(0).checkboxes.selected();
                var Ids = [];
                $.each(selected_rows, function (index, scheduleId) {
                    Ids.push(scheduleId);
                });
                addEnrollmentSchedules(enrollmentId, Ids);
            });
            //Refresh table
        },
    });
}
function displayEnrollmentCourseScheduleInfo(enrollmentId, table) {
    $("#enrolledCourseList").remove();
    $("#enrollmentCourseList").remove();   
    $("#courseEnrollmentModal .enrolledCourseListTable").append('"<table id="enrolledCourseList" class="dataTable data-table-width compact hover row-border stripe"></table>"')
    $("#studentEnrollmentInfoModal .enrolledCourseList").append('"<table id="enrollmentCourseList" class="dataTable data-table-width compact hover row-border stripe"></table >"')
    $('.toprint .table .courseData').empty();
    $.ajax({
        url: API_URL + "EnrollmentCourseSchedule/List/CourseSchedules/" + enrollmentId,
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            var enrolledSubjects = data;
            var scheduleList = [];
            $(data).each(function (index) {
                var courseList = data;
                var courseListRecord = new Array(courseList[index].courseSchedules.courseScheduleId, courseList[index].courseSchedules.edpcode, courseList[index].courseSchedules.courseCode, courseList[index].courseSchedules.courseDescription, courseList[index].courseSchedules.units, courseList[index].courseSchedules.day, courseList[index].courseSchedules.timeStart + " " + courseList[index].courseSchedules.midDayTimeStart + " - " + courseList[index].courseSchedules.timeEnd + " " + courseList[index].courseSchedules.midDayTimeEnd, courseList[index].courseSchedules.room);
                scheduleList.push(courseListRecord);
                console.log("COURSE LIST: " + courseList);
            });

            /*$("#studentEnrollmentInfoModal .blockName").text(data[0].blockName);*/

            courseTable = $(table).DataTable({
                destroy: true,
                paging: true,
                lengthChange: false,
                searching: false,
                ordering: true,
                info: true,
                autoWidth: false,
                responsive: true,
                columns: [
                    { title: "Course Schedule ID" },
                    { title: "EDP Code", defaultContent: "" },
                    { title: "Course Code", defaultContent: "" },
                    { title: "Course Description", defaultContent: "" },
                    { title: "Units", defaultContent: "" },
                    { title: "Day", defaultContent: "" },
                    { title: "Time", defaultContent: "" },
                    { title: "Room", defaultContent: "" }
                ],
                columnDefs: [
                    { className: 'text-center', targets: [0, 1, 2, 3, 4, 5, 6] }, //center align selected columns
                    { visible: false, targets: [0] }
                ],
                data: scheduleList
            });

            var totalUnits = 0
            $(enrolledSubjects).each(function (index) {
                var courseList = enrolledSubjects;
                console.log("Button Click Data: " + JSON.stringify(courseList));
                $(".toprint .table .courseData").append('<tr><td>' + courseList[index].courseSchedules.edpcode + '</td><td>' + courseList[index].courseSchedules.courseDescription + '</td><td>' + courseList[index].courseSchedules.room + '</td><td>' + courseList[index].courseSchedules.day + '</td><td>' + courseList[index].courseSchedules.timeStart + " " + courseList[index].courseSchedules.midDayTimeStart + '<td><td>' + courseList[index].courseSchedules.timeEnd + " " + courseList[index].courseSchedules.midDayTimeEnd + '</td><td>' + courseList[index].courseSchedules.units + '</td><td></td></tr>');
                totalUnits += parseFloat(courseList[index].courseSchedules.units);
            })

            $("#totalUnits").text(totalUnits);
            $("#confirmModal #confirmModalTitle").text("Print Study Load");
            $("#confirmModal .confirm-modal-content").text("Would you like to print a study load?");
            $("#confirmModal").modal('show');
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

function handleConfirm() {
    $(".toprint").print({
        noPrintSelector: ".no-print",
    });
    $("#toprint #courseData").empty();
}
function printStudyLoad(enrollmentDetails) {
}