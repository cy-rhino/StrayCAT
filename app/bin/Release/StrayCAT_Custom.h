/*
 *  Header file for EasyCAT library
 *
 *  This file has been created by the StrayCAT ESI Tool.
 */

#ifndef CUSTOM_PDO_NAME_H
#define CUSTOM_PDO_NAME_H

#define CUST_BYTE_NUM_OUT 1
#define CUST_BYTE_NUM_IN  1
#define TOT_BYTE_NUM_ROUND_OUT 4
#define TOT_BYTE_NUM_ROUND_IN  4

// output buffer
typedef union
{
  uint8_t Byte [TOT_BYTE_NUM_ROUND_OUT];
  struct
  {
    uint8_t outputVal1;
  } Cust;
} PROCBUFFER_OUT;

// input buffer
typedef union
{
  uint8_t Byte [TOT_BYTE_NUM_ROUND_IN];
  struct
  {
    uint8_t inputVal1;
  } Cust;
} PROCBUFFER_IN;

#endif
