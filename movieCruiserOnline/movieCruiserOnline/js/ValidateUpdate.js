function validateMovieItemForm() {
    var regex = "/^[0-9]+$/";
    var itemName = document.getElementById('ContentPlaceHolder1_txtMovieName').value;
    var itemPrice = document.getElementById('ContentPlaceHolder1_txtGross').value;
    if (itemName == "") {
        alert("Please Enter Movie Name");
        return false;
    }
    if (itemPrice == "") {
        alert("Please Enter Budget");
        return false;
    }
    if (!Number(itemPrice)) {
        alert("Price should have only numeric values");
        return false;
    }
}