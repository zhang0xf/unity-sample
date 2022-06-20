using UnityEngine;
using UnityEngine.UI;

// ��¼״̬
public enum LoginState : int
{
    NULL,
    LOGO,           // Logo;
    START,          // ��ʼ;
    UPDATERES,      // �ȸ���;
    ANNOUNCEMENT,   // ����;
    LOGIN,          // ��¼;
    REGISTER,       // ����ע��;
    CHOOSESERVER,   // ��Ϸѡ��;
    CHECKDBACC,     // ��֤�����ʺ�;
    CHOOSEROLE,     // ѡ���ɫ;
    LOADMODULES,    // ����ģ������;
    CUTANIMATION,   // ��������;
    NOVICELEVEL,    // ���ֹؿ�;
    GOINGAME,       // ������Ϸ;
}

public class Login : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Text text;

    // Start is called before the first frame update
    void Start()
    {
        // ��¼��ť
        button.onClick.AddListener(delegate { LoginButtonOnClick(); });
        // ע��������Ϣ�ص�
        NetManager.Instance.AddCallBack(MessageName.LOGIN, RecvLogin);
    }

    private void LoginButtonOnClick()
    {
        // ��¼���̿�ʼ
        Debug.Log("��¼���̿�ʼ");

        

    }

    public void ChangeLoginState(LoginState state)
    {
        if (state == LoginState.NULL) { return; }

        switch (state)
        {
            case LoginState.START:
                {
                    Debug.Log("LoginState : START");
                    text.text = "������������ñ�...";
                }
                break;
            case LoginState.UPDATERES:
                {
                    text.text = "���汾��...";
                }
                break;
            case LoginState.ANNOUNCEMENT:
                {
                    text.text = "���󹫸�...";
                }
                break;
            case LoginState.CHECKDBACC:
                {
                    text.text = "��֤�����ʺ�...";
                }
                break;
            case LoginState.CHOOSESERVER:
                {
                    text.text = "��Ϸѡ��...";
                }
                break;
            case LoginState.CHOOSEROLE:
                {
                    text.text = "ѡ���ɫ...";
                }
                break;
            case LoginState.GOINGAME:
                {
                    text.text = "������Ϸ����...";
                }
                break;
        }
    }

    private void RecvLogin(Message message)
    {
        
    }
}
