### PCB Layout

![Image](../img/StrayCAT_PCB.png)

### PCB Order Information

| Item              | Value       |
|:------------------|:------------|
| Size              | 85mm * 56mm |
| Layers            | 4Layers     |
| Thickness         | 1.6mm       |
| Min Track/Spacing | 5/5mil      |
| Min Hole Size     | 0.3mm       |
| Finished Copper   | 1oz. Cu     |

The order of the layers are as follows.

| Layer | Filename     | Usage  |
|:------|:-------------|:-------|
| L1    | StrayCAT.GTL | Top    |
| L2    | StrayCAT.G1  | GND    |
| L3    | StrayCAT.G2  | 3.3V   |
| L4    | StrayCAT.GBL | Bottom |

- GTP layer allows simultaneous production of paste mask.
- GKO layer assigns the board outline.
- TXT file assigns the NC drill data.

### Layer Stack-up 

This Gerber data is impedance-matched based on the assumption that the order will be placed with a factory that manufactures the following board specifications.

| Item                | Value              |
|:--------------------|:-------------------|
|Trace Thickness      | 0.035mm(1.378mil)  |
|Dielectric Thickness | 0.175mm(6.89mil)   |
|Dielectric Constant  | 4.29               |

The trace width of the MDI transmission line is 6.929mil and the trace spacing is adjusted to 5.41mil so that the differential impedance is 100 ohms.
