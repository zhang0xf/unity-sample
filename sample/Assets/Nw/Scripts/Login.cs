using UnityEngine;
using UnityEngine.UI;

// 登录状态
public enum LoginState : int
{
    NULL,
    LOGO,           // Logo;
    START,          // 开始;
    UPDATERES,      // 热更新;
    ANNOUNCEMENT,   // 公告;
    LOGIN,          // 登录;
    REGISTER,       // 快速注册;
    CHOOSESERVER,   // 游戏选服;
    CHECKDBACC,     // 验证本地帐号;
    CHOOSEROLE,     // 选择角色;
    LOADMODULES,    // 请求模块数据;
    CUTANIMATION,   // 过场动画;
    NOVICELEVEL,    // 新手关卡;
    GOINGAME,       // 进入游戏;
}

public class Login : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Text text;

    // Start is called before the first frame update
    void Start()
    {
        // 登录按钮
        button.onClick.AddListener(delegate { LoginButtonOnClick(); });
        // 注册网络消息回调
        NetManager.Instance.AddCallBack(MessageName.LOGIN, RecvLogin);
    }

    private void LoginButtonOnClick()
    {
        // 登录流程开始
        Debug.Log("登录流程开始");

        

    }

    public void ChangeLoginState(LoginState state)
    {
        if (state == LoginState.NULL) { return; }

        switch (state)
        {
            case LoginState.START:
                {
                    Debug.Log("LoginState : START");
                    text.text = "请求服务器配置表...";
                }
                break;
            case LoginState.UPDATERES:
                {
                    text.text = "检查版本号...";
                }
                break;
            case LoginState.ANNOUNCEMENT:
                {
                    text.text = "请求公告...";
                }
                break;
            case LoginState.CHECKDBACC:
                {
                    text.text = "验证本地帐号...";
                }
                break;
            case LoginState.CHOOSESERVER:
                {
                    text.text = "游戏选服...";
                }
                break;
            case LoginState.CHOOSEROLE:
                {
                    text.text = "选择角色...";
                }
                break;
            case LoginState.GOINGAME:
                {
                    text.text = "加载游戏场景...";
                }
                break;
        }
    }

    private void RecvLogin(Message message)
    {
        
    }
}
