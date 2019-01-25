int IN4 = 3;
int IN3 = 2;
int IN2 = 5;
int IN1 = 4;

void setup() {
  // pin definitions:
  
  pinMode(IN4, OUTPUT);
  pinMode(IN3, OUTPUT);
  pinMode(IN2, OUTPUT);
  pinMode(IN1, OUTPUT);
}

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

  analogWrite(IN4, 10);
  analogWrite(IN2, 10);
  analogWrite(IN3, 10);
  analogWrite(IN1, 10);
}
// Make the wheels move right
void right() {
  digitalWrite(IN4, HIGH);
  digitalWrite(IN3, LOW);
  digitalWrite(IN2, LOW);
  digitalWrite(IN1, HIGH);

  analogWrite(IN4, 10);
  analogWrite(IN2, 10);
  analogWrite(IN3, 10);
  analogWrite(IN1, 10);;
}

void backwards() {
  digitalWrite(IN4, LOW);
  digitalWrite(IN3, HIGH);
  digitalWrite(IN2, LOW);
  digitalWrite(IN1, HIGH);

  analogWrite(IN4, 10);
  analogWrite(IN2, 10);
  analogWrite(IN3, 10);
  analogWrite(IN1, 10);
}

void breaks() {
  digitalWrite(IN4, LOW);
  digitalWrite(IN3, LOW);
  digitalWrite(IN2, LOW);
  digitalWrite(IN1, LOW);
}

void loop(){
  forward();
}
