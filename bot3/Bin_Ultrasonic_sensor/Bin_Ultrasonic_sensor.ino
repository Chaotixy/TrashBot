
const int trigPin = 10;
const int echoPin = 11;
long duration;
int distanceCm;
void setup() {

pinMode(trigPin, OUTPUT);
pinMode(echoPin, INPUT);
Serial.begin(9600);
}

void loop() {
digitalWrite(trigPin, LOW);
delayMicroseconds(2);
digitalWrite(trigPin, HIGH);
delayMicroseconds(10);
digitalWrite(trigPin, LOW);
duration = pulseIn(echoPin, HIGH);
distanceCm= duration*0.034/2;

if (distanceCm >= 0 && distanceCm <= 6.5){
    //bin full
     Serial.println( "Bin_State: Full");

   } else {
      Serial.print("Distance: "); // Prints string "Distance" on the LCD
      Serial.println(distanceCm); // Prints the distance value from the sensor
   }
//Serial.print("Distance: "); // Prints string "Distance" on the LCD
//Serial.println(distanceCm); // Prints the distance value from the sensor
//Serial.print(" cm");
delay(1000);

}
