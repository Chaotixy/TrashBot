
#include "MPU6050_tockn.h"
#include <SPI.h>
#include <SoftwareSerial.h>
#include <Wire.h>
#include "WiFly.h"

#define trigPin1 13
#define echoPin1 12
#define trigPin2 11
#define echoPin2 10
#define leftWheelUp 3
#define leftWheelDown 2
#define rightWheelUp 5
#define rightWheelDown 4

int state; //state of the loop
int line;
int speed;
 

float var1 = 19.5;    // caliberation factor

int var2 = A0;  // FlexiForce sensor is connected analog pin A0 of arduino 

int var3 = 0;
float weight; //Flexiforce reading

String bin_state; //This is the Status of the bin IF full or NOt


//Setup
void setup() {
line = 0;

pinMode(var2, INPUT); //Flexi force
Serial.begin (9600);
  
pinMode(trigPin1, OUTPUT); //ultrasonic sound sensor1
pinMode(echoPin1, INPUT);

pinMode(trigPin2, OUTPUT); //ultrasonic sound sensor2
pinMode(echoPin2, INPUT);

WiFly.begin();

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


//Flexi Force ------- Calculate the weight

var3 = analogRead(var2);
weight = (var3 * 5.0) / 1023.0;
weight = weight * var1;
weight = weight * 100;

//send weight to server
//if (client.connect()) {
//    client.print("GET /write_data.php?");
//    client.print("value="); 
//    client.print(weight);
//    client.println(" HTTP/1.1"); // Part of the GET request
//    client.println("Host: 81.169.200.100,1433");
//    client.println("Connection: close"); // Part of the GET request telling the server that we are over transmitting the message
//    client.println(); //empty line
//    client.stop(); //Closing connection to the server
//}
//else {
//    // If Arduino can't connect to the server 
//    Serial.println("--> connection failed\n");
//  }

delay(10000);

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
	
//	send bin state to server
//	if (client.connect()) {
//		client.print("GET /write_data.php?");
//		client.print("value="); 
//		client.print(bin_state);
//		client.println(" HTTP/1.1"); // Part of the GET request
//    client.println("Host: 81.169.200.100,1433");
//		client.println("Connection: close"); // Part of the GET request telling the server that we are over transmitting the message
//		client.println(); //empty line
//		client.stop(); //Closing connection to the server
//	}
//	else {
//    // If Arduino can't connect to the server 
//		Serial.println("--> connection failed\n");
//	}

	delay(10000);
	
	//INSERT GYRO CODE HERE//
 
  }
}  
