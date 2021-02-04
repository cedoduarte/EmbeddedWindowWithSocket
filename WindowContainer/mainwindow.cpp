#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QHostAddress>
#include <QVBoxLayout>
#include <QDebug>

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    m_server = makeServer();
    m_embeddedWidget = makeEmbeddedWidget();
    ui->fromCSharp_lineEdit_2->setEnabled(false);
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_sendToCSharp_pushButton_clicked()
{
    qDebug() << "button clicked";
    ui->sendToCSharp_lineEdit->setFocus(Qt::ActiveWindowFocusReason);
    m_server->sendData(ui->sendToCSharp_lineEdit->text());
}

void MainWindow::onDataReceived(const QString &data)
{
    ui->fromCSharp_lineEdit_2->setText(data);
}

MyTcpServer *MainWindow::makeServer()
{
    MyTcpServer *server = new MyTcpServer(this);
    connect(server, &MyTcpServer::dataReceived, this, &MainWindow::onDataReceived);
    server->listen(QHostAddress::Any, 12345);
    return server;
}

MyEmbeddedWidget *MainWindow::makeEmbeddedWidget()
{
    if (m_server->isListening())
    {
        MyEmbeddedWidget *widget = new MyEmbeddedWidget("EmbeddedWindow.exe", L"EmbeddedWindow", true, this);
        QVBoxLayout *vbox = new QVBoxLayout;
        vbox->addWidget(widget);
        vbox->setContentsMargins(0, 0, 0, 0);
        ui->csharp_groupBox_2->setLayout(vbox);
        return widget;
    }
    return nullptr;
}


