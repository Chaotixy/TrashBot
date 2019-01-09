#include "MPU6050_tockn.h"
#include <SPI.h>
#include <Ethernet.h>
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

byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };
 
// Enter the IP address for Arduino

IPAddress ip(xxx,xxx,x,xx);
  
//Flexi Force
float var1 = 19.5;    // caliberation factor

int var2 = A0;  // FlexiForce sensor is connected analog pin A0 of arduino 

int var3 = 0;
float weight; //Flexiforce reading

String bin_state; //This is the Status of the bin IF full or NOt

//Server IP
char server[] = "81.169.200.100,1433";

//Initializing the Ethernet server library
EthernetClient client;

//Setup
void setup() {
line = 0;

pinMode(var2, INPUT); //Flexi force
Serial.begin (9600);
  
pinMode(trigPin1, OUTPUT); //ultrasonic sound sensor1
pinMode(echoPin1, INPUT);

pinMode(trigPin2, OUTPUT); //ultrasonic sound sensor2
pinMode(echoPin2, INPUT);

Ethernet.begin(mac, ip); //start the Ethernet connection
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
weight = (var3 * 5.0) / 1023.0;
weight = weight * var1;
weight = weight * 100;

//send weight to server
if (client.connect(server, 80)) {
    client.print("GET /write_data.php?");
    client.print("value="); 
    client.print(weight);
    client.println(" HTTP/1.1"); // Part of the GET request
    client.println("Host: DBMSSOCN");
    client.println("Connection: close"); // Part of the GET request telling the server that we are over transmitting the message
    client.println(); //empty line
    client.stop(); //Closing connection to the server
else {
    // If Arduino can't connect to the server 
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

  if (distance >= 0 && distance <= 6.5){
    //bin full
    //Send bin state to the server
    bin_state = "Full";

    //****THIS WILL BE REPLACED BY FOLLOW THE LINE CODE OR ARDUINO CODE****
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
  else {
    bin_state = "Not full";
  }
  delay(10000);
}  
