#include "MPU6050_tockn.h"
#include <SoftwareSerial.h>
#include <Wire.h>
#define trigPin 13
#define echoPin 12
#define led 11
#define led2 10
#define leftWheelUp 3
#define leftWheelDown 2
#define rightWheelUp 9
#define rightWheelDown 4
#define LS 11 //left sensor
#define RS 10 //Right sensor



#define bt_power 7
#define bt_key_power 8
SoftwareSerial BT(A0, A1); //setup bluetooth
int state; //state of the loop
int line;
int speed;
//MPU6050 mpu; 
//gyro
float var1 = 19.5;    // caliberation factor

int var2 = A0;  // FlexiForce sensor is connected analog pin A0 of arduino 

int var3 = 0;
float vout;

void setup() {
  line = 0;
  //initiate BT serial at 38400
  BT.begin(38400);
  pinMode(bt_power, OUTPUT);
  pinMode(bt_key_power, OUTPUT);
  pinMode(var2, INPUT);
  Serial.begin (9600);
  digitalWrite(bt_power, LOW);
  digitalWrite (bt_key_power, LOW);
  //key low
  delay(100);

  //key high
  digitalWrite(bt_key_power, HIGH);

  delay(100);

  //power BT
  digitalWrite(bt_power, HIGH);
  
  pinMode(trigPin, OUTPUT); //ultrasonic sound sensor
  pinMode(echoPin, INPUT);
  pinMode(led, OUTPUT); 
  pinMode(led2, OUTPUT);
  pinMode(LS, INPUT); //left sensor
  pinMode(RS, INPUT); // right sensor
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

  analogWrite(leftWheelUp, 80);
  analogWrite(rightWheelUp, 80);
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
//linefollow function
void lineFollow() {
    if(!(digitalRead(LS)) && !(digitalRead(RS))) { //forward
    forward();
    } 
    if(digitalRead(LS) && !(digitalRead(RS))) {//right
    left();
    }
    if(!(digitalRead(LS)) && digitalRead(RS)) { //left 
    right();
    }
    if(digitalRead(LS) && digitalRead(RS)) { //breaks 
    breaks();
    }
    
  }

 
//function to move to the next game
void autoMode() {
  forward();
  delay(6000);
  left();
  delay(500);
  breaks();
  delay(100);
  forward();
  delay(200);
}

void loop() {
//Bluetooth
if(BT.available()>0) {
  state = BT.read();
}

//takes input from buttons by the BT device in ASCII
if(state == 57) //breaks
{
breaks();
} 

else if(state == 55) { //bump wall game
  long duration, distance;
  digitalWrite(trigPin, LOW);  
  delayMicroseconds(2); 
  digitalWrite(trigPin, HIGH);

  delayMicroseconds(10); 
  digitalWrite(trigPin, LOW);
  duration = pulseIn(echoPin, HIGH);
  distance = (duration/2) / 29.1;

   if(distance > 30) {
    forward();
    }
    
    if (distance >= 0 && distance <= 87){
    breaks();
    backwards();
    right();
    right();
    }
 }
  delay(80);

//Flexi Force

var3 = analogRead(var2);
vout = (var3 * 5.0) / 1023.0;
vout = vout * var1;
vout = vout * 100;
Serial.print("Flexi Force sensor: ");
Serial.print(vout,3);
Serial.println("");
delay(100);
}
  
