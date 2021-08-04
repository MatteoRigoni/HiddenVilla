window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, 'Operation Successfull')
    }
    if (type === "error") {
        toastr.error(message, 'Operation Failed')
    }
}

function ShowDeleteConfirmationnModal() {
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationnModal() {
    $('#deleteConfirmationModal').modal('hide');
}