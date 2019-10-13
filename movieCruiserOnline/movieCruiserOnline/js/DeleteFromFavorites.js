function DeleteFromFavorites(movieId, userId) {
    PageMethods.DeleteMovieFromFavorites(movieId, userId, onSuccess, onFailure);
}
function onSuccess(result) {
    document.getElementById('favStatus').innerHTML = "Movie removed from favorites successfully";
    setTimeout(function () { document.getElementById("favStatus").innerHTML = "" }, 2500);
    window.location = "ShowFavorites.aspx";
}

function onFailure(error) {
    alert(error);
}