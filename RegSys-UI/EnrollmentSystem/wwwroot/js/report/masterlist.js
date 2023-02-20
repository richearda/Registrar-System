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
    getSchoolYear("#schoolYear");
    getSemester("#semester");
    $("#search").on('click', function () {
        getSubjectList($("#schoolYear").find(":selected").val(), $("#semester").find(":selected").val());
    });
    $("#masterListInfoModal").on('hidden.bs.modal', function () {
        $(".subjectStudentList").empty();
    });
    printMasterList();
})

function getSchoolYear(controlId) {
    $.ajax({
        url: API_URL + "Term/GetList",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            $(data).each(function (index) {
                var terms = data;
                console.log('data: ', terms);
                $(controlId).append($('<option/>', { value: terms[index].termId, text: terms[index].termCode }));
                if (terms[index].isCurrent && terms[index].isActive) {
                    $(controlId).val(terms[index].termId).change();
                }
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
function getSemester(controlId) {
    $.ajax({
        url: API_URL + "Semester/GetList",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            $(data).each(function (index) {
                var semesters = data;
                console.log('data: ', semesters);
                $(controlId).append($('<option/>', { value: semesters[index].semesterId, text: semesters[index].semesterName }));

                if (semesters[index].isCurrent && semesters[index].isActive) {
                    $(controlId).val(semesters[index].semesterId).change();
                }
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
function getSubjectList(termId, semesterId) {
    $.ajax({
        url: API_URL + "TeacherCourseSchedule/Get/Subjects/Schedule",
        type: "GET",
        traditional: true,
        data: { "termId": termId, "semesterId": semesterId },
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            var subjectData = [];
            $(data).each(function (index) {
                var subjects = data;
                /*var updateButton = '<a class="addPayable" onclick="openLedgerInfoModal(' + enrollees[index].studentId + ',\'' + enrollees[index].studentNo + '\',\'' + enrollees[index].fullName + '\',\'' + enrollees[index].course + '\',\'' + enrollees[index].major + '\',\'' + enrollees[index].yearLevel + '\')" title="Ledger Info"><i class=" ml-2 fa-solid fa-info"></i></a>';*/
                var printMasterList = '<a class="printMasterList" title="Print Subject Masterlist" onclick="openMasterListInfoModal(\'' + subjects[index].name + '\',\'' + subjects[index].courseSchedule.courseScheduleId + '\',\'' + subjects[index].courseSchedule.edpcode + '\',\'' + subjects[index].courseSchedule.courseCode + '\',\'' + subjects[index].courseSchedule.courseDescription + '\',\'' + subjects[index].courseSchedule.day + '\',\'' + subjects[index].courseSchedule.timeStart + '\',\'' + subjects[index].courseSchedule.midDayTimeStart + '\',\'' + subjects[index].courseSchedule.timeEnd + '\',\'' + subjects[index].courseSchedule.midDayTimeEnd + '\',\'' + subjects[index].courseSchedule.units + '\',\'' + subjects[index].courseSchedule.room + '\')"><i class=" ml-2 fa-solid fa-info"></i></a>';

                var subjectRecord = new Array(subjects[index].courseSchedule.courseScheduleId, subjects[index].courseSchedule.edpcode, subjects[index].courseSchedule.courseCode, subjects[index].courseSchedule.courseDescription, subjects[index].courseSchedule.units, subjects[index].courseSchedule.day, subjects[index].courseSchedule.timeStart + " " + subjects[index].courseSchedule.midDayTimeStart + " - " + subjects[index].courseSchedule.timeEnd + " " + subjects[index].courseSchedule.midDayTimeEnd, subjects[index].courseSchedule.room, printMasterList);
                subjectData.push(subjectRecord);
            })

            $(subjectListTable).DataTable({
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
                    { title: "Room", defaultContent: "" },
                    { title: "Action", defaultContent: "" }

                ],
                columnDefs: [
                    { className: 'text-center', targets: [0, 1, 2, 3, 4, 5, 6, 7, 8] }, //center align selected columns
                    { visible: false, targets: [0] }
                ],
                data: subjectData
            });
        }
    })
}
function getSubjectStudentList(termId, semesterId, courseSchedId) {
    $.ajax({
        url: API_URL + "EnrollmentCourseSchedule/Subject/StudentList",
        type: "GET",
        data: { termId: termId, semesterId: semesterId, courseSchedId: courseSchedId },
        dataType: "json",
        contentType: "application/json",
        success: function (data) {
            var counter = 1;
            var studentRecord = [];
            $(data).each(function (index) {
                var students = data;
                $(".subjectStudentList").append('<tr><td>' + counter + '</td ><td>' + students[index].studentNo + '</td><td>' + students[index].studentName + '</td><td>' + students[index].course + " - " + students[index].major + '</td><td>' + students[index].yearLevel + '</td></tr>')
                //var studentList = new Array(students[index].studentNo, students[index].studentName, students[index].course + " - " + students[index].major, students[index].yearLevel)
                counter++;
            });
        }
    })
}
function openMasterListInfoModal(name, courseschedid, edpcode, coursecode, coursedescription, day, timestart, middaytimestart, timeend, middaytimeend, units, room) {
    getSubjectStudentList($("#schoolYear").find(":selected").val(), $("#semester").find(":selected").val(), courseschedid);
    $(".subjectInfo .edpCodeValue").text(edpcode);
    $(".subjectInfo .dayValue").text(day);
    $(".subjectInfo .courseCodeValue").text(coursecode);
    $(".subjectInfo .timeScheduleValue").text(timestart + " " + middaytimestart + "-" + timeend + " " + middaytimeend);
    $(".subjectInfo .roomValue").text(room);
    $(".subjectInfo .facultyValue").text(name);
    $(".subjectInfo .unitsValue").text(units);
    $("#masterListInfoModal").modal('show');
}
function printMasterList() {
    $("#printMasterListButton").on('click', function () {
        $(".printmasterlist").print({
            noPrintSelector: ".no-print",
        });
    });
}