#include <MPU6050_tockn.h>
#include <Wire.h>

MPU6050 mpu6050(Wire);

long timer,timer2;
float scalaR;
float interval;

float posX,posY,posZ;
float offsetX,offsetY,offsetZ;
float deltaX,deltaY,deltaZ,deltaT;

void setup() {
  Serial.begin(9600);
  Wire.begin();
  mpu6050.begin();
  mpu6050.calcGyroOffsets(true);
  mpu6050.update();
  offsetX = mpu6050.getAccX(); //so that you readings start 0
  posX = 0;
}

void loop() {
  interval = millis() - timer;
  deltaT = millis() - timer2;
  
  //Serial.print(mpu6050.getGyroY());
  //Serial.println(mpu6050.getGyroX());
  //alternate calculation that tries to smoothen position using an interval
  //posY += mpu6050.getGyroY() * interval; 
  
  //try to smooth the readings
  if(deltaT >=20) {
    mpu6050.update();
    
    deltaX = mpu6050.getAccX()-offsetX;
    deltaY = mpu6050.getAccY()-offsetY;
    if(abs(deltaX) >= 0.02){
      posX += deltaX;
    }
    if(abs(deltaY) >= 0.02) {
      posY += deltaY;
    }
    timer2 = millis();
  }
  //only print every 100 milliseconds
   if(interval >=100) {
    Serial.println(mpu6050.getAngleX());
    Serial.print(posX);//Serial.println(deltaX);
    timer = millis();
  }
}
