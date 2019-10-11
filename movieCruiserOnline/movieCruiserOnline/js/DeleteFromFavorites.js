function DeleteFromFavorites(movieId, userId) {
    PageMethods.DeleteMovieFromFavorites(movieId, userId, onSuccess, onFailure);
}
function onSuccess(result) {
    document.getElementById('cartStatus').innerHTML = "Item added to cart successfully";
    setTimeout(function () { document.getElementById("cartStatus").innerHTML = "" }, 2500);
    window.location = "ShowFavorites.aspx";
}

function onFailure(error) {
    alert(error);
}