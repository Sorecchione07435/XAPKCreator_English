# XAPK Creator

XAPK Creator is a small free and open source written in Visual Basic tool for creating installable XAPK files on Android.

This software can be useful for many reasons:

### Advantages:

- Useful if you can't manually install APK and OBB on your phone because you can't access "Android/obb" folder Android 11+ problem
- You can keep APK and OBB in one file (APK + OBB = XAPK)
- You can create XAPKs without coding
- The tool also allows you to decompile AndroidManifest.xml files without downloading any other programs

And to create your own XAPK you will need the easily obtainable files

### To create your XAPK you will need:

- The APK file of your application or game
- OBB resources downloaded separately
- The application icon (in PNG format) (Obtainable from the APK) (Carefully examine the "res" folder inside the APK)
- The decompiled AndroidManifest.xml file (Obtainable from the APK) (To get the information of the application/game)

All created XAPKs will be stored in the "XAPKs" folder

The good thing about this tool is that you can create an XAPK from any APK and OBB downloaded from the internet

## APK Problem

![a2](https://user-images.githubusercontent.com/111366201/235430063-c2f8e434-a65c-493d-9500-e28351f26c91.png)

While selecting the APK file you might get an error like "The APK name must match the application package name for its APK to be recognized", to fix it just simply rename the APK file with the application package name

- Example "Free Fire 198.apk" renamed to "com.dts.freefireth.apk"
- The application's OBB resources will also be checked, to ensure that no other applications resources or APKs are added that have nothing to do with it

This is because the tool tries to understand if the selected APK is that of the application, AND not of other applications


### Platforms
- Microsoft Windows

## Screenshot
![a1](https://user-images.githubusercontent.com/111366201/235347607-eab010f8-f8b4-4d11-92c8-6658522d1cbb.png)

![a3](https://user-images.githubusercontent.com/111366201/235431273-bd141ea1-95b0-400a-9edb-ebf9e719e27a.png)


### How to install created XAPK on Android

Unfortunately, it has been discovered that installing XAPK files created with this program does not install correctly!, manual installation is recommended

### Download it

Unfortunately the XAPK Creator project has been discontinued

This implies that it will no longer be available for download until a stable version is developed

However, if you want to download it out of necessity, here is a fairly functional version: [Download XAPK Viewer OLD](http://sorecchione07.altervista.org/Downloads-URLS/XAPK%20Creator/old/XAPK_Creator.exe)
Also download the AndroidManifest.xml decompiler: [Download](http://sorecchione07.altervista.org/Downloads-URLS/XAPK%20Creator/old/axmldec.exe)
