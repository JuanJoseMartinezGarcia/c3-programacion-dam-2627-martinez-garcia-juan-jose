 // Used pins
#define SERVO1 3  // Servo motor on pin 3 (orange wire)
#define LEDRED 7  // Red led (brown wire)
#define BTNINC 6  // INCrease BuTtoN on pin 6 (light green wire)
#define SERVO_STEP 4 //2.1

// Include the library for controlling servo motors
#include <Servo.h>

// Create a Servo object to control the servo motor
Servo servoMotor1;

// Variable to store the current servo position
int servo1Position;

void setup() // Runs only once, at startup
{
  // Configure the digital pins:
  pinMode(LEDRED, OUTPUT); 
  pinMode(BTNINC, INPUT_PULLUP); // HIGH = not pressed, LOW = pressed
  pinMode(BTNDEC, INPUT_PULLUP);

  // Attach the servo motor to its pin
  servoMotor1.attach(SERVO1);

  // Set the initial servo position to 0 degrees
  servo1Position = 0;

  // Move the servo to the initial position
  servoMotor1.write(servo1Position);

  // Set the initial status of leds (turned off)
  digitalWrite(LEDRED,LOW);
  digitalWrite(LEDBLUE,LOW);

}

void loop() // Runs continuously after setup()
{
  delay(10); // Prevents the simulator from being overloaded

  if (!digitalRead(BTNINC)) // If BTNINC is pressed
  {
    // Increase the servo position by 2 degrees
    if (servo1Position<180)
    {
      servo1Position += SERVO_STEP;
    }
    else
    {
      digitalWrite(LEDRED,HIGH);
    

    }  
  }
    // Send the new position to the servo motor
    servoMotor1.write(servo1Position);

    // Wait 20 ms to slow down the movement
    delay(10);
  
}

