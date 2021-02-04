#include "myembeddedwindowprocess.h"
#include "myembeddedwindow.h"

MyEmbeddedWindowProcess::MyEmbeddedWindowProcess(QObject *parent)
    : QObject(parent)
{
    m_process = new QProcess(this);
    m_window = new MyEmbeddedWindow(this);
    connect(m_process, &QProcess::started, this, &MyEmbeddedWindowProcess::onStarted);
}

MyEmbeddedWindowProcess::~MyEmbeddedWindowProcess()
{
    // nothing to do here
}

void MyEmbeddedWindowProcess::setWindowName(LPCWSTR windowName)
{
    m_window->setName(windowName);
}

void MyEmbeddedWindowProcess::setProgramFilePath(const QString &filepath)
{
    m_process->setProgram(filepath);
}

void MyEmbeddedWindowProcess::startProgram()
{
    m_process->start();
}

void MyEmbeddedWindowProcess::setWidgetParent(QWidget *parent)
{
    m_window->setWidgetParent(parent);
}

QWidget *MyEmbeddedWindowProcess::embeddedWidget() const
{
    return m_window->widget();
}

MyEmbeddedWindow *MyEmbeddedWindowProcess::programWindow() const
{
    return m_window;
}

void MyEmbeddedWindowProcess::onStarted()
{
    while (!m_window->grab())
    {
        // waiting for true
    }
    emit embedded();
}
