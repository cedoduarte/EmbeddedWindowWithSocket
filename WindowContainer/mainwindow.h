#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include "mytcpserver.h"
#include "myembeddedwidget.h"

namespace Ui
{
class MainWindow;
}

/** main window */
class MainWindow : public QMainWindow
{
    Q_OBJECT
public:
    /** constructor */
    explicit MainWindow(QWidget *parent = nullptr);

    /** destructor */
    virtual ~MainWindow();
private slots:
    /** data received from embedded window */
    void onDataReceived(const QString &data);

    /** sends data to embedded window */
    void on_sendToCSharp_pushButton_clicked();
private:
    /** makes listener */
    MyTcpServer *makeServer();

    /** makes embedded widget */
    MyEmbeddedWidget *makeEmbeddedWidget();

    Ui::MainWindow *ui; //!< gui
    MyTcpServer *m_server; //!< server to listen to embedded window
    MyEmbeddedWidget *m_embeddedWidget; //!< embedded widget
};

#endif // MAINWINDOW_H
