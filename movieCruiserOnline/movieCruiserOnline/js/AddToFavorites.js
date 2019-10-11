function AddToFavorites(movieId, userId) {
    PageMethods.AddMovieToFavorites(movieId, userId, onSuccess, onFailure);
}
function onSuccess(result) {
    document.getElementById('favStatus').innerHTML = "Movie added to favorites successfully";
    setTimeout(function () { document.getElementById("favStatus").innerHTML = "" }, 2500);
    return false;
}

function onFailure(error) {
    alert(error);
}