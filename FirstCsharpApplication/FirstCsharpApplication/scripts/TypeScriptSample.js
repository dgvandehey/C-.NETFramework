var Guest = (function () {
    function Guest() {
    }
    Guest.prototype.Constructor = function (name) {
        this.name = name;
    };
    return Guest;
}());
window.onload = function () {
    var guest = new Guest('stranger');
    alert(guest.name);
};
