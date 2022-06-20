// Server信息
public class ServerInfo
{
    public const string ServerHost = "192.168.0.107";
    public const string ServerPort = "9703";
}

public class MessageName
{
    public const string LOGIN = "LOGIN";    // 登录
}

// 回调
public delegate void MessageHandler(Message msg);
