When deploying this program onto a new system ensure:
  1. System has thorlabs kinesis installed
  2. System has Zaber Launcher installed
  3. System has NI 488.2 driver installed
  4. Check REFRENCES.md for all required .dll
  5. GitNu package Zaber is installed
  6. All references are present
  7. All COM ports match their respective components (Only Zaber requires COM port def.)

**Code Outline**
 - Power reading (Form1.cs)
    - Program connects to ANDO frame via NI 488.2 GPIB
    - When laser is active, powermeter readout in dBm is shown on main screen
      
 - GUI Interactions (Form1.cs)
    - Definition of button/textfield interactions and calls to functions

 - Logging power values (Powerlogger.cs)
    - Powerlogger takes power output and adds timestamps and logs them to a .txt file Accessible by the view log button
  
 - Thorlabs Motion Functions (KCubeController.cs)
    - Contains all of the logic within the Thorlabs Motion System

 - Zaber Motion Functions (ZaberController.cs)
    - Contains all of the logic within the Zaber Motion System
