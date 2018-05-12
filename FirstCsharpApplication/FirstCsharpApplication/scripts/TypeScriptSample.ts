class Guest
{
    name: string

    Constructor(name: string)
    {
        this.name = name;
    }
}

window.onload = function ()
{
    var guest = new Guest('stranger');
    alert(guest.name);
}