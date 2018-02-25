Triangle1API - built with Azure Functions 1.0.9 

Provides an API endpoint in Azure with the desired "Triangulation" functionality.  Can also run locally in the debugger with the 
Azure Functions CLI installed.  

It serves a local API something like:
http://localhost:7071/api/Triangulation1

It is published to Azure at:
https://triangulation.azurewebsites.net/api/Triangulation1?code=kui1FmPO69IMql9IruFCLgxPVhtUw3kp6Bkd06Puphkkn2ixHHnLnw==&gridlocation=F1
NOTE passing a Gridlocation in addition to the Code for use.

To get results back, pass in a query string parameter "gridlocation" and a value between A1 and F12.
Results returned will be a json representation of a triangle including Vertices at (v1x,v1y), (v2x,v2y), and (v3x,v3y)
orientation of up or down and the grid location of the triangle.

NOTE: all of the heavy lifting of the app logic is pushed into the Models project  - so can utilize multiple approaches for
implementation - including a mobile app / Azure Function and an Angular web app with a WebAPI.
