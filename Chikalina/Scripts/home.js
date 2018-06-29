var grid = new Grid({
    element: '#photos',
    columns: 6,
    margin: 2
});

//https://github.com/jimoong/mosaigrid
//http://json2csharp.com/

window.addEventListener('load', function () {
    grid.items[0].spanX = 3;
    grid.items[0].spanY = 2;
    grid.items[5].spanX = 2;
    grid.items[5].spanY = 4;
    grid.draw();
}, false);
