#ifndef MYEMBEDDEDWIDGET_H
#define MYEMBEDDEDWIDGET_H

#include <QWidget>
#include <QVBoxLayout>
#include "myembeddedwindowprocess.h"

/** embedded widget for external programs */
class MyEmbeddedWidget : public QWidget
{
    Q_OBJECT
public:
    /**
     * @brief MyEmbeddedWidget
     * @param programFilePath executable file path
     * @param windowName window title of the program
     * @param autoRun runs the program automatically
     * @param parent widget's parent
     */
    explicit MyEmbeddedWidget(const QString &programFilePath,
                              LPCWSTR windowName,
                              bool autoRun = true,
                              QWidget *parent = nullptr);

    /** destructor */
    virtual ~MyEmbeddedWidget();

    /** runs the program */
    void run();
private slots:
    /** on embedded window */
    void onEmbedded();
private:
    QVBoxLayout *m_vbox; //!< layout
    MyEmbeddedWindowProcess *m_process; //!< process
};

#endif // MYEMBEDDEDWIDGET_H
