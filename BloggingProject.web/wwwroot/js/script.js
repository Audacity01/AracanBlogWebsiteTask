// Add JavaScript code here if needed, for example, to handle the navbar collapse/expand behavior
document.querySelector('.navbar-toggler').addEventListener('click', function () {
    this.parentElement.querySelector('.collapse').classList.toggle('show');
});
