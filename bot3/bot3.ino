#include "MPU6050_tockn.h"
#include <SoftwareSerial.h>
#include <Wire.h>
#define trigPin1 13
#define echoPin1 12
#define trigPin2 14
#define echoPin2 15
#define leftWheelUp 3
#define leftWheelDown 2
#define rightWheelUp 9
#define rightWheelDown 4

  int state; //state of the loop
  int line;
  int speed;
  //MPU6050 mpu; 
  //gyro
  //Flexi Force
  float var1 = 19.5;    // caliberation factor

  int var2 = A0;  // FlexiForce sensor is connected analog pin A0 of arduino 

  int var3 = 0;
  float vout;

  void setup() {
  line = 0;
  //initiate BT serial at 38400
  
 
  
  pinMode(var2, INPUT);
  Serial.begin (9600);
  
  pinMode(trigPin1, OUTPUT); //ultrasonic sound sensor1
  pinMode(echoPin1, INPUT);

  pinMode(trigPin2, OUTPUT); //ultrasonic sound sensor2
  pinMode(echoPin2, INPUT);
  //mpu.initialize();
  //gyro
  

  Wire.begin();
}
// Make the wheels move forward
void forward() {
  digitalWrite(leftWheelUp, HIGH);
  digitalWrite(leftWheelDown, LOW);
  digitalWrite(rightWheelUp, HIGH);
  digitalWrite(rightWheelDown, LOW);

  analogWrite(leftWheelUp, 70);
  analogWrite(rightWheelUp, 70);
}
// Make the Wheels move Left
void left() {
  digitalWrite(leftWheelUp, LOW);
  digitalWrite(leftWheelDown, HIGH);
  digitalWrite(rightWheelUp, HIGH);  
  digitalWrite(rightWheelDown, LOW);

  analogWrite(leftWheelUp, 80);
  analogWrite(rightWheelUp, 80);
}
// Make the wheels move right
void right() {
  digitalWrite(leftWheelUp, HIGH);
  digitalWrite(leftWheelDown, LOW);
  digitalWrite(rightWheelUp, LOW);  
  digitalWrite(rightWheelDown, HIGH);

  analogWrite(leftWheelUp, 50);
  analogWrite(rightWheelUp, 50);
}
void backwards() {
  digitalWrite(leftWheelUp, LOW);
  digitalWrite(leftWheelDown, HIGH);
  digitalWrite(rightWheelUp, LOW);  
  digitalWrite(rightWheelDown, HIGH);

  analogWrite(leftWheelUp, 70);
  analogWrite(rightWheelUp, 70);
}
void breaks() {
  digitalWrite(leftWheelUp, LOW);
  digitalWrite(leftWheelDown, LOW);
  digitalWrite(rightWheelUp, LOW);
  digitalWrite(rightWheelDown, LOW);
}


void loop() {

  
 
  delay(80);

//Flexi Force ------- Calculate the weight

var3 = analogRead(var2);
vout = (var3 * 5.0) / 1023.0;
vout = vout * var1;
vout = vout * 100;

//send weight to server

delay(100);

//if full or not ----- Ultrasonic sensor

  long duration, distance;
  digitalWrite(trigPin2, LOW);  
  delayMicroseconds(2); 
  digitalWrite(trigPin2, HIGH);

  delayMicroseconds(10); 
  digitalWrite(trigPin2, LOW);
  duration = pulseIn(echoPin2, HIGH);
  distance = (duration/2) / 29.1;

  if(distance > 6.5) {
    //bin empty
    }
    
    if (distance >= 0 && distance <= 6.5){
    //bin full
    //avoid obstacles
    long duration, distance;
    digitalWrite(trigPin1, LOW);  
    delayMicroseconds(2); 
    digitalWrite(trigPin1, HIGH);

    delayMicroseconds(10); 
    digitalWrite(trigPin1, LOW);
    duration = pulseIn(echoPin1, HIGH);
    distance = (duration/2) / 29.1;

    if(distance > 20) {
    forward();
    }
    
    if (distance >= 0 && distance <= 25){
    breaks();
    delay(1000);
    backwards();
    delay(150);
    right();
    
    }
  }
  delay(80);
}  
