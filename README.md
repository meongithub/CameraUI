## Remote Camera Controller UI

The application is to connect, preview and control remote cameras.

## Support
Suppot SUNAPI2.4.1 provided by SUMSUNG

## External Extension needed for Visual Studio 2015
The setup project in the solution uses Microsoft Visual Studio 2015 Installer Projects, which can be found here (https://visualstudiogallery.msdn.microsoft.com/f1cc3f3e-c300-40a7-8797-c509fb8933b9)

## Dependency
1. Prism
2. Extended.Wpf.Toolkit.2.8
3. MJPEG-Decoder.1.2
4. The CameraUI uses functionalities from LCM API. Therefore you need to add lcm.dll under directiry packages/LCM. You can update LCM API by simply replacing lcm.dll in packages/LCM. Follow the instructions in CameraRT to get lcm.dll file.
5. Note that 1,2 and 3 can be restored in Visual Studio 2015

## Other files required for running from Visual Studio:
In order to run the application from Visual Studio without installation, you need to create a folder named RemoteCameraControllerData in Documents folder, and copy all files and folders in [CameraUI Project]/Data to this new folder.
