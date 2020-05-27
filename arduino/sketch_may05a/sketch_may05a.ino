#include <Servo.h>
Servo servorMotor1;
Servo servorMotor2;
Servo servorMotor3;
Servo servorMotor4;
Servo servorMotor5;

byte MSG_DEVICE_INFO = 0x00;
byte MSG_TRIGGER_1 = 0x01;
byte MSG_TRIGGER_2 = 0x02;
byte MSG_TRIGGER_3 = 0x03;
byte MSG_TRIGGER_4 = 0x04;
byte MSG_TRIGGER_5 = 0x05;
        
const String DEVICE_NAME = "Auto click device v1.00";
int PIN_SERVO_MOTOR_1=3;
int PIN_SERVO_MOTOR_2=5;
int PIN_SERVO_MOTOR_3=6;
int PIN_SERVO_MOTOR_4=9;
int PIN_SERVO_MOTOR_5=10;
int PIN_POWER_SWITCH = 12;

void SetMotorAngle(Servo servorMotor, int angle)
{
  digitalWrite(PIN_POWER_SWITCH, HIGH);
  delay(3);
  for(int i = 0; i <= angle; i+=1){
    servorMotor.write(i); // 使用write，傳入角度，從0度轉到180度
    delay(5);
  }
  for(int i = angle; i >= 0; i-=1){
    servorMotor.write(i);// 使用write，傳入角度，從180度轉到0度
    delay(5);
  }
  digitalWrite(PIN_POWER_SWITCH, LOW);
}

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
 
  //Serial.println("init power switch ...");
  pinMode(PIN_POWER_SWITCH, OUTPUT);
  digitalWrite(PIN_POWER_SWITCH, HIGH);
  
  //Serial.println("init servo motor 1 ...");
  servorMotor1.attach(PIN_SERVO_MOTOR_1);
  servorMotor1.write(0);
  
  //Serial.println("init servo motor 2 ...");
  servorMotor2.attach(PIN_SERVO_MOTOR_2);
  servorMotor2.write(0);
  
  //Serial.println("init servo motor 3 ...");
  servorMotor3.attach(PIN_SERVO_MOTOR_3);
  servorMotor3.write(0);
  
  //Serial.println("init servo motor 4 ...");
  servorMotor4.attach(PIN_SERVO_MOTOR_4);
  servorMotor4.write(0);
  
  //Serial.println("init servo motor 5 ...");
  servorMotor5.attach(PIN_SERVO_MOTOR_5);
  servorMotor5.write(0);
  
  Serial.flush();
}


char temp[100];
int msg = 0;  
void loop() {         
  if (Serial.available()) { 
    msg = Serial.read();
    if(msg == MSG_DEVICE_INFO)
    {
      sprintf(temp, "{ \"msg\" : %i , \"name\" : \"auto click device\", \"version\" : \"v1.00\" }", MSG_DEVICE_INFO);
      Serial.write(temp);
    }
    else if(msg == MSG_TRIGGER_1)
    {
      SetMotorAngle(servorMotor1, 90);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_TRIGGER_1);
      Serial.write(temp);
    }
    else if(msg == MSG_TRIGGER_2)
    {
      SetMotorAngle(servorMotor2, 90);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_TRIGGER_2);
      Serial.write(temp);
    }
    else if(msg == MSG_TRIGGER_3)
    {
      SetMotorAngle(servorMotor3, 90);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_TRIGGER_3);
      Serial.write(temp);
    }
    else if(msg == MSG_TRIGGER_4)
    {
      SetMotorAngle(servorMotor4, 90);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_TRIGGER_4);
      Serial.write(temp);
    }
    else if(msg == MSG_TRIGGER_5)
    {
      SetMotorAngle(servorMotor5, 90);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_TRIGGER_5);
      Serial.write(temp);
    }
  }
  delay(100);
}
