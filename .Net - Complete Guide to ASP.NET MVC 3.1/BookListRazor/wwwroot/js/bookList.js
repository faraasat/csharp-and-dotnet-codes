var dataTable;

$(document).ready(function () {
    loadDataTable();
});


// In cloumn>data: we will write lower camel such as if class have NameAbc then we will write nameAbc
function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/book",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "name", "width": "25%" },
            { "data": "author", "width": "25%" },
            { "data": "isbn", "width": "25%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a href="/BookList/Upsert?id=${data}" class="btn btn-success text-white" style="cursor: pointer">Edit<a/>
                            &nbsp;
                            <a class="btn btn-danger text-white" style="cursor: pointer" onclick=Delete('/api/book?id='+${data})>Delete<a/>
                        </div>
                    `
                }, 
                "width": "30%",
            }
        ],
        "language": {
            "emptyTable": "No Data Found"
        },
        "width": "100%",
    });
}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover",
        icon: "warning",
        showCancelButton: true
    }).then((result) => {
        if (result.value) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        $(function () {
                            toastr.success(data.message);
                        });
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    });
}