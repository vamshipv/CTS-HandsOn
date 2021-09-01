var VirtualPoint = /** @class */ (function () {
    function VirtualPoint(x, y) {
        this.x = x;
        this.y = y;
    }
    return VirtualPoint;
}());
var newVPoint = new VirtualPoint(13, 56);
console.log(newVPoint); // logs "13, 56"