# HomeAutomationCore
Home Automation Core or H.A.C. is a home automation web server/client application. For Home Automation using Dot.net Core

The main consideration of this server is that it will be modular to allow complete customization of client user interface. It should also have a wide range of modules on the back end for interaction. This would include interacting with web services. Examples of these would be IFTTT, Push Bullet, SMS services, Phillips HUE, etc. 
The Idea is to make this modular enough for some what "fast" configuration, with miminamal coding required to set up a system. Or at least make mangement as low-techniqual skill as possible.

##Technology
C# dot net core web api this will access a database (which TBD). The client will be a c# MVC front end. This can be accessed by any internet enabled device.

##Idea of Feature set
 * GUI completely customizable. This should allow for customization of ones home. This would go from Building, Floors, Rooms, Areas, Sub-areas, or any other considerations. 
 * Have a wifi packet sniffer which would allow for adding of new WiFi enabled devices on the network.
    - User would enter IP address of device, and call it's web service. The sniffer would take those packets and create a module for the server to use for that device. 
