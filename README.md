# Autonomy-Sensors-Suite

Project for modeling & simulation sensors utilized in the realization of fully autonomous vehicles.<br/>
Built in Unity Engine 2019.4.1f1

Some of the most common sensors which could be simulated are:<br/>
-2D LIDAR<br/>
-3D LIDAR<br/>
-RADAR<br/>
-Depth Camera<br/>
-Semantic Segmentation<br/>
<br/>

### 2D Lidar (non-rotating):

This implements a static 2D Lidar which can be used for Range Detection.<br/>
Parameters:<br/>
-Range (in m) <br/>
-Frequency (in ms) <br/>
-Field of View (radial resolution)<br/>

20 Hz, 9 FOV             |  20 Hz, 3 FOV (with RGB Camera) |  Configuration
:-------------------------:|:-------------------------:|:-------------------------:
![](https://github.com/10dimensions/autonomy-sensors-modeling/blob/main/Results/output_1.gif)  |  ![](https://github.com/10dimensions/autonomy-sensors-modeling/blob/main/Results/output_1.PNG) | ![](https://github.com/10dimensions/autonomy-sensors-modeling/blob/main/Results/sensor_1.PNG)

Known Bugs:<br/>
Depth Camera Stream


### 3D Lidar (rotating):
-Under Construction-

### RADAR:
-Under Construction-
