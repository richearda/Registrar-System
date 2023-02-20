$(document).ready(function () {
    getOfferedCourseList();
    $("#enrollmentNo").val(moment().format("YYYY") + "-" + newGuid());
    $("#enrollmentNo").prop('disabled', true);
    $("#enrollmentDate").val(moment().format('MM/DD/YYYY'));
    getCurrentTerm();
    getCurrentSemester();
});

function getOfferedCourseList() {
    $.ajax({
        url: API_URL + "CourseSchedule/GetList/CurrentOfferedCourses",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            let offeredCourseList = [];
            $(data).each(function (index) {
                let courseList = data;
                console.log('data: ', courseList);              
                let courseListRecord = new Array(courseList[index].courseScheduleId, courseList[index].courseScheduleId, courseList[index].edpcode, courseList[index].courseCode, courseList[index].courseDescription, courseList[index].units, courseList[index].day, courseList[index].timeStart + " " + courseList[index].midDayTimeStart + " - " + courseList[index].timeEnd + " " + courseList[index].midDayTimeEnd, courseList[index].room);
                offeredCourseList.push(courseListRecord);
            });
            let courseTable;
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
                //select: {
                //    style: 'multi',
                //    selector: 'td:first-child'
                //    /*className:'selected-row'*/
                //},
                //order: [[1, 'asc']],
                'select': {
                    'style': 'multi'
                },
                'order': [[1, 'asc']],
                data: offeredCourseList
            });
            $("#enrollStudentButton").on('click', function () {
                let enrollmentDto = {
                    enrollmentNo: $("#enrollmentNo").val(),
                    //enrollmentDate: $("#enrollmentDate").val(),
                    isActive: true,
                    studentId: $("#studentId").val()
                }
                let selected_rows = courseTable.column(0).checkboxes.selected();
                //var params = { enrollmentId:5, courseScheduleIds:[] };
                let Ids = [];
                $.each(selected_rows, function (index, scheduleId) {
                    //params.courseScheduleIds.push(scheduleId);
                    Ids.push(scheduleId);
                    // Ids.push(scheduleId);
                    console.log(Ids);
                });
                console.log("Enrollment Data: " + JSON.stringify(enrollmentDto));
                console.log("Course Schedule IDs: " + Ids);
                //params.enrollmentId = 5;
                //addEnrollmentSchedules(5, Ids);
                addEnrollment(enrollmentDto, Ids);
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
function getCurrentTerm() {
    $.ajax({
        url: API_URL + "Term/GetCurrentTerm",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            console.log("Term: " + JSON.stringify(data));
            var term = data;
            $("#schoolYear").val(term.termCode);
        }
    });
}
function getCurrentSemester() {
    $.ajax({
        url: API_URL + "Semester/CurrentSemester",
        type: "GET",
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            console.log("Term: " + JSON.stringify(data));
            var semester = data;
            $("#semester").val(semester.semesterName);
        }
    })
}