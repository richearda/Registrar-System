$(document).ready(function () {
    getBlockList();
});
function getBlockList() {
    $.ajax({                                        //connect to the API via AJAX
        url: API_URL + 'Block/GetList',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {                  //data (in JSON form) contains the list of college records retrieved from the API
            var blockData = data;
            console.log('data: ', blockData);
            //for each tuitionfeerate record, convert to datatable set
            var blockSet = [];
            $(blockData).each(function (index, item) {
                var editAction = '<a href="#" onclick="openBlockSubjectModal(' + blockData[index].blockId + ',\'' + blockData[index].blockName + '\',\'' + blockData[index].program + '\',\'' + blockData[index].major + '\',\'' + blockData[index].term + '\',\'' + blockData[index].semester + '\')" data-toggle="tooltip" data-placement="top" title="Edit"><i class="fa fa-edit fa-icon-link"></i></a>';              
                var blockRecord = new Array(blockData[index].blockId, blockData[index].blockName, blockData[index].program, blockData[index].major, blockData[index].term, blockData[index].semester, editAction);
                blockSet.push(blockRecord);
            });
            //initialize datatable with the data set
            $('#tblBlockList').DataTable({
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

//this function opens the tuitionfeerate modal
function openBlockSubjectModal(blockId, blockName, blockProgram, blockMajor, term, semester) {
    //clearModalForm();               //reset form
    if (blockId != 0) {			//edit
        console.log('Block to Edit: ' + blockId + ' ' + blockName + ' ' + blockProgram + ' ' + blockMajor + ' ' + term + ' ' + semester);
        $('#operationType').val('edit');
        $('#blockSubjectModalTitle').text('Add Subject');
        $('#blockSubjectID').val(blockId);
        $('#manageBlockSubjectModal #blockName').val(blockName);
        $('#manageBlockSubjectModal #blockProgram').val(blockProgram);
        $('#manageBlockSubjectModal #blockMajor').val(blockMajor).val(blockMajor);
        $('#manageBlockSubjectModal #blockTerm').val(term);
        $('#manageBlockSubjectModal #blockSemester').val(semester);
    }
    //set form data

    $('#manageBlockSubjectModal').modal('show'); //show block modal

    $("[data-toggle='tooltip']").tooltip('hide');           //hide dangling bootstrap tooltip
}