// Server��Ϣ
public class ServerInfo
{
    public const string ServerHost = "192.168.0.107";
    public const string ServerPort = "9703";
}

public class MessageName
{
    public const string LOGIN = "LOGIN";    // ��¼
}

// �ص�
public delegate void MessageHandler(Message msg);
