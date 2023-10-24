class Car {
  constructor(make, model, year) {
    this.make = make;
    this.model = model;
    this.year = year;
    this.engineOn = false;
    this.currentSpeed = 0;
  }

  startEngine() {
    if (this.engineOn) {
      console.log("Engine is already running.");
      return;
    }
    this.engineOn = true;
    console.log("Engine started.");
  }

  stopEngine() {
    if (!this.engineOn) {
      console.log("Engine is already off.");
      return;
    }
    this.engineOn = false;
    this.currentSpeed = 0;
    console.log("Engine stopped.");
  }

  accelerate(speed) {
    if (!this.engineOn) {
      console.log("Cannot accelerate, engine is off.");
      return;
    }
    this.currentSpeed += speed;
    console.log(`Accelerated to ${this.currentSpeed} mph.`);
  }

  decelerate(speed) {
    if (this.currentSpeed <= 0) {
      console.log("Cannot decelerate, car is already at rest.");
      return;
    }
    this.currentSpeed -= speed;
    if (this.currentSpeed < 0) {
      this.currentSpeed = 0;
    }
    console.log(`Decelerated to ${this.currentSpeed} mph.`);
  }

  displayCurrentSpeed() {
    console.log(`Current speed: ${this.currentSpeed} mph`);
  }
}
