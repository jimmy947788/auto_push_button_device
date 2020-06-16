#include <Servo.h>
Servo servorMotor1;
Servo servorMotor2;
Servo servorMotor3;
Servo servorMotor4;
Servo servorMotor5;

byte MSG_DEVICE_INFO = 0x00;
byte MSG_PUSH_1 = 0x01;
byte MSG_PUSH_2 = 0x02;
byte MSG_PUSH_3 = 0x03;
byte MSG_PUSH_4 = 0x04;
byte MSG_PUSH_5 = 0x05;
byte MSG_OPEN_1 = 0x06;
byte MSG_OPEN_2 = 0x07;
byte MSG_OPEN_3 = 0x08;
byte MSG_OPEN_4 = 0x09;
byte MSG_OPEN_5 = 0x0a;
byte MSG_CLOSE_1 = 0x0b;
byte MSG_CLOSE_2 = 0x0c;
byte MSG_CLOSE_3 = 0x0d;
byte MSG_CLOSE_4 = 0x0e;
byte MSG_CLOSE_5 = 0x0f;

const String DEVICE_NAME = "Auto click device v1.00";
int PIN_SERVO_MOTOR_1=3;
int PIN_SERVO_MOTOR_2=5;
int PIN_SERVO_MOTOR_3=6;
int PIN_SERVO_MOTOR_4=9;
int PIN_SERVO_MOTOR_5=10;
int PIN_POWER_SWITCH = 12;

int PIN_USB_CTL_1 = 2;
int PIN_USB_CTL_2 = 4;
int PIN_USB_CTL_3 = 7;
int PIN_USB_CTL_4 = 8;
int PIN_USB_CTL_5 = 11;

int motor_angle = 90;

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

  pinMode(PIN_USB_CTL_1, OUTPUT);
  pinMode(PIN_USB_CTL_2, OUTPUT);
  pinMode(PIN_USB_CTL_3, OUTPUT);
  pinMode(PIN_USB_CTL_4, OUTPUT);
  pinMode(PIN_USB_CTL_5, OUTPUT);
  
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
    else if(msg == MSG_PUSH_1)
    {
      SetMotorAngle(servorMotor1, motor_angle);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : %i }", MSG_PUSH_1, motor_angle);
      Serial.write(temp);
    }
    else if(msg == MSG_PUSH_2)
    {
      SetMotorAngle(servorMotor2, motor_angle);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_PUSH_2);
      Serial.write(temp);
    }
    else if(msg == MSG_PUSH_3)
    {
      SetMotorAngle(servorMotor3, motor_angle);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_PUSH_3);
      Serial.write(temp);
    }
    else if(msg == MSG_PUSH_4)
    {
      SetMotorAngle(servorMotor4, motor_angle);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_PUSH_4);
      Serial.write(temp);
    }
    else if(msg == MSG_PUSH_5)
    {
      SetMotorAngle(servorMotor5, motor_angle);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_PUSH_5);
      Serial.write(temp);
    }
    else if(msg == MSG_OPEN_1)
    {
      digitalWrite(PIN_USB_CTL_1, HIGH);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_OPEN_1);
      Serial.write(temp);
    }
    else if(msg == MSG_CLOSE_1)
    {
      digitalWrite(PIN_USB_CTL_1, LOW);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_CLOSE_1);
      Serial.write(temp);
    }
    else if(msg == MSG_OPEN_2)
    {
      digitalWrite(PIN_USB_CTL_2, HIGH);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_OPEN_2);
      Serial.write(temp);
    }
    else if(msg == MSG_CLOSE_2)
    {
      digitalWrite(PIN_USB_CTL_2, LOW);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_CLOSE_2);
      Serial.write(temp);
    }
    else if(msg == MSG_OPEN_3)
    {
      digitalWrite(PIN_USB_CTL_3, HIGH);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_OPEN_3);
      Serial.write(temp);
    }
    else if(msg == MSG_CLOSE_3)
    {
      digitalWrite(PIN_USB_CTL_3, LOW);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_CLOSE_3);
      Serial.write(temp);
    }
    else if(msg == MSG_OPEN_4)
    {
      digitalWrite(PIN_USB_CTL_4, HIGH);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_OPEN_4);
      Serial.write(temp);
    }
    else if(msg == MSG_CLOSE_4)
    {
      digitalWrite(PIN_USB_CTL_4, LOW);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_CLOSE_4);
      Serial.write(temp);
    }
    else if(msg == MSG_OPEN_5)
    {
      digitalWrite(PIN_USB_CTL_5, HIGH);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_OPEN_5);
      Serial.write(temp);
    }
    else if(msg == MSG_CLOSE_5)
    {
      digitalWrite(PIN_USB_CTL_5, LOW);
      sprintf(temp, "{ \"msg\" : %i , \"result\" : 1 }", MSG_CLOSE_5);
      Serial.write(temp);
    }
    else
    {
      motor_angle = msg;
    }
  }
  delay(100);
}
