class VirtualPoint {
    x: number;
    y: number;
   
    constructor(x: number, y: number) {
      this.x = x;
      this.y = y;
    }
  }
   
  const newVPoint = new VirtualPoint(13, 56);
  console.log(newVPoint); // logs "13, 56"

// function logPoint(newVPoint: VirtualPoint) {
//   throw new Error("Function not implemented.");
// }

