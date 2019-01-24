float var1 = 19.5;    // caliberation factor

int var2 = A0;  // FlexiForce sensor is connected analog pin A0 of arduino 

int var3 = 0;
float weight;
void setup()
{
  Serial.begin(9600);
  pinMode(var2, INPUT);
  
}

void loop()
{
var3 = analogRead(var2);
weight = (var3 * 5.0) / 1023.0;
weight = weight * var1;
Serial.print("Flexi Force sensor: ");
Serial.print(weight,3);
Serial.println("");
delay(100);

}
