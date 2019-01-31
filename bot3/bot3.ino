//Connection to a wifi network is initialized here.

#ifndef __CREDENTIALS_H__
#define __CREDENTIALS_H__
char passphrase[] = "pass_WIFI"; //password Wi-Fi
char ssid[] = "name_WIFI"; //name Wi-Fi

//Definition of all the libraries are done here.

#include "MPU6050_tockn.h"
#include <SPI.h>
#include <SoftwareSerial.h>

//Server connection

byte server[] = { 66, 249, 89, 104 };

WiFlyClient client("", 80);

//Definitions of all the right pins

#define trigPin1 13 //First Ultrasonic sensor in front of the robot
#define echoPin1 12 //First Ultrasonic sensor in front of the robot
#define trigPin2 11 //Second Ultrasonic sensor Inside the bin
#define echoPin2 10 //Second Ultrasonic sensor Inside the bin

//Motor driver pin definitions ******

int IN4 = 3; 
int IN3 = 2;
int IN2 = 5;
int IN1 = 4;

//*******

//GYRO definitions

long timer,timer2;
float scalaR;
float interval;

float posX,posY,posZ;
float offsetX,offsetY,offsetZ;
float deltaX,deltaY,deltaZ,deltaT;

//********

//Definition of some of the Variables used

int state; //state of the loop
int line;
int speed;

long duration;
long distance;

float timer;
 

float var1 = 19.5;    // caliberation factor for FlexiForce

int var2 = A0;  // FlexiForce sensor is connected analog pin A0 of arduino 

int var3 = 0;
float weight; //Flexiforce reading

String bin_state; //This is the Status of the bin IF full or NOt


//Setup
void setup() {
  
WiFly.begin(); //Start the Wifly

//Establishing the WIFI connection****

//Check if connection was successful
if (!WiFly.join(ssid, passphrase)) {
    Serial.println("Association failed.");
    while (1) {
      // Hang on failure.
    }
  }  

  Serial.println("connecting...");

  if (client.connect()) {
    Serial.println("connected");
    client.println("GET /search?q=arduino HTTP/1.0");
    client.println();
  } else {
    Serial.println("connection failed");
  }
  
  //GYRO Setup
  mpu6050.begin();
  mpu6050.calcGyroOffsets(true);
  mpu6050.update();
  offsetX = mpu6050.getAccX(); //so that you readings start 0
  posX = 0;
}

pinMode(var2, INPUT); //Flexi force
Serial.begin (9600);
  
pinMode(trigPin1, OUTPUT); //ultrasonic sound sensor1
pinMode(echoPin1, INPUT);

pinMode(trigPin2, OUTPUT); //ultrasonic sound sensor2
pinMode(echoPin2, INPUT);

pinMode(IN4, OUTPUT); //Motor Drivers
pinMode(IN3, OUTPUT);
pinMode(IN2, OUTPUT);
pinMode(IN1, OUTPUT);


}


// Make the wheels move forward
void forward() {
  digitalWrite(IN4, HIGH);
  digitalWrite(IN3, LOW);
  digitalWrite(IN2, HIGH);
  digitalWrite(IN1, LOW);

  analogWrite(IN4, 70);
  analogWrite(IN2, 70);
  analogWrite(IN3, 70);
  analogWrite(IN1, 70);
}
// Make the Wheels move Left
void left() {
  digitalWrite(IN4, LOW);
  digitalWrite(IN3, HIGH);
  digitalWrite(IN2, HIGH);
  digitalWrite(IN1, LOW);

  analogWrite(IN4, 70);
  analogWrite(IN2, 70);
  analogWrite(IN3, 70);
  analogWrite(IN1, 70);
}
// Make the wheels move right
void right() {
  digitalWrite(IN4, HIGH);
  digitalWrite(IN3, LOW);
  digitalWrite(IN2, LOW);
  digitalWrite(IN1, HIGH);

  analogWrite(IN4, 70);
  analogWrite(IN2, 70);
  analogWrite(IN3, 70);
  analogWrite(IN1, 70);;
}
// Make the Wheels reverse
void backwards() {
  digitalWrite(IN4, LOW);
  digitalWrite(IN3, HIGH);
  digitalWrite(IN2, LOW);
  digitalWrite(IN1, HIGH);

  analogWrite(IN4, 50);
  analogWrite(IN2, 50);
  analogWrite(IN3, 50);
  analogWrite(IN1, 50);
}
// Make the Wheels break
void breaks() {
  digitalWrite(IN4, LOW);
  digitalWrite(IN3, LOW);
  digitalWrite(IN2, LOW);
  digitalWrite(IN1, LOW);
}

void loop() {
//Flexi Force ------- Calculate the weight

var3 = analogRead(var2);
weight = (var3 * 5.0) / 1023.0;
weight = weight * var1;
weight = weight * 100;

//send weight to server

if (client.connect()) {
    client.print("GET /write_data.php?");
    client.print("weight="); 
    client.print(weight);
    client.println(" HTTP/1.1"); // Part of the GET request
    client.println("Host: 81.169.200.100,1433");
    client.println("Connection: close"); // Part of the GET request telling the server that we are over transmitting the message
    client.println(); //empty line
    client.stop(); //Closing connection to the server
}
delay(10000); //Delay to let the server process the input

//if full or not ----- Ultrasonic sensor

  long duration, distance;
  digitalWrite(trigPin2, LOW);  
  delayMicroseconds(2); 
  digitalWrite(trigPin2, HIGH);

  delayMicroseconds(10); 
  digitalWrite(trigPin2, LOW);
  duration = pulseIn(echoPin2, HIGH);
  distance = (duration/2) / 29.1;
  
  if (distance >= 0 && distance <= 6.5){
    //bin full
     bin_state = "Full";
    }
   
//	send bin state to server

	if (client.connect()) {
		client.print("GET /write_data.php?");
		client.print("bin_state="); 
		client.print(bin_state);
		client.println(" HTTP/1.1"); // Part of the GET request
    client.println("Host: 81.169.200.100,1433");
		client.println("Connection: close"); // Part of the GET request telling the server that we are over transmitting the message
		client.println(); //empty line
		client.stop(); //Closing connection to the server
	}
	else {
    // If Arduino can't connect to the server 
		Serial.println("--> connection failed\n");
	}

	 delay(10000); //Delay to let the server process the input
	
//GYRO
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

  
