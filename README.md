# triangulation
https://github.com/dmilner321/triangulation

This is the interesting little project calculating the details of a triangle given a picture map and a grid location of the triangle.

Technologies used:

- .NET Core 2.0 - WebAPI
- .NET Standard
-  Angular
-  Ionic

Solutions:

Triangle1API.sln - contains 3 projects

- Models - interface and class for Triangle
- Triangle1API - Azure function exposing the TriangleAPI - Azure functions 1.0.9
- Triangle1Client - Angular client app and .NET Core WebAPI back end

Also, related in a seperate repository - 
https://github.com/dmilner321/triangulate-ion
- triangulate-ion - Ionic mobile app that connects to the Azure function
