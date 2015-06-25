# USB Ejected Check

USB Ejected Check is a simple application for checking whether a USB Device has been ejected from the computer before shutting down. That's all there is to it at the moment. If it is still in the computer, a message and sound will be played. 

### How does it work? (The technical side)
It works in the following manner: The main form is constantly running in the background. When the computer shuts down, the form (and the whole application) will be closed. When that form closes, it checks for the close reason. If that is equal to Windows shutdown, it will invoke checking the USB drive. If it is still there, it will cancel the shutdown and display the message. 
