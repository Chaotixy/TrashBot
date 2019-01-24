#ifndef __CREDENTIALS_H__
#define __CREDENTIALS_H__
char passphrase[] = "pass_WIFI"; //password Wi-Fi
char ssid[] = "name_WIFI"; //name Wi-Fi

#include "MPU6050_tockn.h"
#include <SPI.h>
#include <SoftwareSerial.h>
#include <Wire.h>
#include "WiFly.h"

#define trigPin1 13
#define echoPin1 12
#define trigPin2 11
#define echoPin2 10

int IN4 = 3;
int IN3 = 2;
int IN2 = 5;
int IN1 = 4;

int state; //state of the loop
int line;
int speed;

long duration;
long distance;

float timer;
 

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

pinMode(IN4, OUTPUT);
pinMode(IN3, OUTPUT);
pinMode(IN2, OUTPUT);
pinMode(IN1, OUTPUT);

WiFly.begin();

}


// Make the wheels move forward
void forward() {
  digitalWrite(IN4, HIGH);
  digitalWrite(IN3, LOW);
  digitalWrite(IN2, HIGH);
  digitalWrite(IN1, LOW);

  analogWrite(IN4, 10);
  analogWrite(IN2, 10);
}
// Make the Wheels move Left
void left() {
  digitalWrite(IN4, LOW);
  digitalWrite(IN3, HIGH);
  digitalWrite(IN2, HIGH);
  digitalWrite(IN1, LOW);

  analogWrite(IN4, 70);
  analogWrite(IN2, 70);
}
// Make the wheels move right
void right() {
  digitalWrite(IN4, HIGH);
  digitalWrite(IN3, LOW);
  digitalWrite(IN2, LOW);
  digitalWrite(IN1, HIGH);

  analogWrite(IN4, 70);
  analogWrite(IN2, 70);
}

void backwards() {
  digitalWrite(IN4, LOW);
  digitalWrite(IN3, HIGH);
  digitalWrite(IN2, LOW);
  digitalWrite(IN1, HIGH);

  analogWrite(IN4, 70);
  analogWrite(IN2, 70);
}

void breaks() {
  digitalWrite(IN4, LOW);
  digitalWrite(IN3, LOW);
  digitalWrite(IN2, LOW);
  digitalWrite(IN1, LOW);
}

void loop() {
  timer = millis();
  while(timer > 10000){
  forward();
  }

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
else {
     If Arduino can't connect to the server 
    Serial.println("--> connection failed\n");
    }

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

  Serial.print("Distance: ");
  Serial.println(distance);

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

	 delay(10000);
	
	//INSERT GYRO CODE HERE//
 
  // }
}  
