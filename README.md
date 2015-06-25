## USB Ejected Check
USB Ejected Check is a simple application for checking whether a USB Device has been ejected from the computer before shutting down. That's all there is to it at the moment. If it is still in the computer, a message and sound will be played. 

### Features
USB Ejected Check is able to:
- Check whether an USB device is still present at shutdown.
- Play a sound when that is the case.
- Show a message.
- Run silently on boot, monitoring new USB devices and adding them to the watch list.

### How does it work? (The technical side)
It works in the following manner: The main form is constantly running in the background. When the computer shuts down, the form (and the whole application) will be closed. When that form closes, it checks for the close reason. If that is equal to Windows shutdown, it will invoke checking the USB drive. If it is still there, it will cancel the shutdown and display the message. 

### Licence
USB Ejected Check is available under the [MPL2.0](https://www.mozilla.org/MPL/2.0/) licence.

### Thanks to
Thanks to the following people for providing material:

* Eject icon - Fatcow Web Hosting:
http://www.iconarchive.com/show/farm-fresh-icons-by-fatcow/control-eject-blue-icon.html

* USB icon - Esxxi.me:
http://www.iconarchive.com/show/hdrv-icons-by-esxxi.me/USB-icon.html

* Notification sound - Or!ngz:
http://oringz.com/ringtone/lace/

* Text to speech - Acapela:
http://www.acapela-group.com/
