QT += core
QT += gui
QT += widgets
QT += network

CONFIG += c++11

# You can make your code fail to compile if it uses deprecated APIs.
# In order to do so, uncomment the following line.
#DEFINES += QT_DISABLE_DEPRECATED_BEFORE=0x060000    # disables all the APIs deprecated before Qt 6.0.0

SOURCES += \
    main.cpp \
    mainwindow.cpp \
    myembeddedwidget.cpp \
    myembeddedwindow.cpp \
    myembeddedwindowprocess.cpp \
    mytcpserver.cpp

HEADERS += \
    mainwindow.h \
    myembeddedwidget.h \
    myembeddedwindow.h \
    myembeddedwindowprocess.h \
    mytcpserver.h

FORMS += \
    mainwindow.ui

# Default rules for deployment.
qnx: target.path = /tmp/$${TARGET}/bin
else: unix:!android: target.path = /opt/$${TARGET}/bin
!isEmpty(target.path): INSTALLS += target
