# StrayCAT ESI Tool
 ESI .xml file generator

![Image](../img/StrayCAT_ESI_Tool.png)

This tool is developed in VB.NET. It has only one form and the source code is written in a concise manner. The parameters that cannot be set in the form are hard-coded, so they can be easily modified using Visual Studio.

Originally, a function to write out binary file is also needed, but I do not plan to implement it because I do not have the necessary knowledge. A write tool is required to write the ESI to the EEPROM on the StrayCAT board. This tool is included in the archive of the ET9300 EtherCAT SSC Tool provided by Beckhoff.

To simplify checking the operation, a header file is output for use with the EasyCAT library. If this header file does not function properly, check the encoding.

This tool has not yet been fully tested. Users must check the generated xml and correct any problems they find.