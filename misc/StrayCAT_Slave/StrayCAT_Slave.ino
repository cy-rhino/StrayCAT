/*
 *  StrayCAT Slave with an Arduino
 *
 *  signal voltage : 3.3V
 *  user interface : 2 Trimpots, 4 LEDs, 4 Switches
 */

#define CUSTOM                // custom mode

#include "StrayCAT_Custom.h"  // created by StrayCAT ESI Tool
#include "EasyCAT.h"          // AB&T EasyCAT Library V2.0 is required
#include <SPI.h>

EasyCAT EASYCAT;              // EasyCAT instantiation

const int Ana0 = A0;          // analog input 0
const int Ana1 = A1;          // analog input 1

const int BitOut0 = A2;       // digital output bit 0
const int BitOut1 = A3;       // digital output bit 1
const int BitOut2 = A4;       // digital output bit 2
const int BitOut3 = A5;       // digital output bit 3

const int BitIn0 = 3;         // digital input  bit 0
const int BitIn1 = 5;         // digital input  bit 1
const int BitIn2 = 6;         // digital input  bit 2
const int BitIn3 = 7;         // digital input  bit 3

uint16_t CountUp;             // rising ramp
uint8_t  CountDown;           // falling ramp

unsigned long Millis = 0;
unsigned long PreviousMillis = 0;
unsigned long PreviousRamp = 0;
unsigned long PreviousCycle = 0;

void setup()
{
  pinMode(BitOut0, OUTPUT);
  pinMode(BitOut1, OUTPUT);
  pinMode(BitOut2, OUTPUT);
  pinMode(BitOut3, OUTPUT);
  pinMode(BitIn0, INPUT_PULLUP);
  pinMode(BitIn1, INPUT_PULLUP);
  pinMode(BitIn2, INPUT_PULLUP);
  pinMode(BitIn3, INPUT_PULLUP);

  CountUp = 0x0000;
  CountDown = 0x00;

  if (EASYCAT.Init() == true)
  {
    Serial.print("initialized");
  } else {
    Serial.print("initialization failed");
    pinMode(13, OUTPUT);
    while(1)
    {
      digitalWrite(13, LOW);
      delay(500);
      digitalWrite(13, HIGH);
      delay(500);
    }
  }
  PreviousMillis = millis();
}

void loop()
{
  EASYCAT.MainTask();   // the task cycle and the Master cycle are asynchronous
  Application();        // user applications
}

void Application()
{
  uint16_t Analog0;
  uint16_t Analog1;

  Millis = millis();
  if (Millis - PreviousMillis >= 10)                    // cycle time : 10mSec
  {
    PreviousMillis = Millis;

    Analog0 = analogRead(Ana0);                         // read 10 bit analog input 0
    Analog0 = Analog0 << 6;                             // normalize it on 16 bits
    EASYCAT.BufferIn.Cust.Analog_0 = Analog0;           // and put the result into input Byte 0

    Analog1 = analogRead(Ana1);                         // read 10 bit analog input 1
    Analog1 = Analog1 << 6;                             // normalize it on 16 bits
    EASYCAT.BufferIn.Cust.Analog_1 = Analog1;           // and put the result into input Byte 2

    if (EASYCAT.BufferOut.Cust.Leds & (1<<0)) {         // the 4 output bits are mapped to the
      digitalWrite(BitOut0, HIGH);                      // lower nibble of output Byte 0
    } else {
      digitalWrite(BitOut0, LOW);
    }
    if (EASYCAT.BufferOut.Cust.Leds & (1<<1)) {
      digitalWrite(BitOut1, HIGH);
    } else {
      digitalWrite(BitOut1, LOW);
    }
    if (EASYCAT.BufferOut.Cust.Leds & (1<<2)) {
      digitalWrite(BitOut2, HIGH);
    } else {
      digitalWrite(BitOut2, LOW);
    }
    if (EASYCAT.BufferOut.Cust.Leds & (1<<3)) {
      digitalWrite(BitOut3, HIGH);
    } else {
      digitalWrite(BitOut3, LOW);
    }

    if (digitalRead(BitIn0)) {                          // the 4 input pins are mapped to the
      EASYCAT.BufferIn.Cust.DipSwitches |=  (1<<0);     // lower nibble of input Byte 6
    } else {                                            // we read each pin and write it
      EASYCAT.BufferIn.Cust.DipSwitches &= ~(1<<0);     // to the corresponding bit
    }
    if (digitalRead(BitIn1)) {
      EASYCAT.BufferIn.Cust.DipSwitches |=  (1<<1);
    } else {
      EASYCAT.BufferIn.Cust.DipSwitches &= ~(1<<1);
    }
    if (digitalRead(BitIn2)) {
      EASYCAT.BufferIn.Cust.DipSwitches |=  (1<<2);
    } else {
      EASYCAT.BufferIn.Cust.DipSwitches &= ~(1<<2);
    }
    if (digitalRead(BitIn3)) {
      EASYCAT.BufferIn.Cust.DipSwitches |=  (1<<3);
    } else {
      EASYCAT.BufferIn.Cust.DipSwitches &= ~(1<<3);
    }

    Millis = millis();                                  // each 100mSec
    if (Millis - PreviousRamp >= 100)
    {
      PreviousRamp = Millis;
      CountUp += 256;                                   // we increment the variable CountUp
      CountDown--;                                      // and decrement CountDown
    }

    EASYCAT.BufferIn.Cust.Bit16_RisingRamp = CountUp;   // medium speed rising ramp
    EASYCAT.BufferIn.Cust.Bit8_FallingRamp = CountDown; // medium speed falling ramp
  }
}
