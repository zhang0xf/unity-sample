using Google.Protobuf.Examples.AddressBook;
using UnityEngine;
using UnityEngine.UI;

public class NetTest : MonoBehaviour
{
    [SerializeField] private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(delegate { ButtonOnClick(); });
    }

    private void ButtonOnClick()
    {
        Person person = new Person
        {
            Id = 1,
            Name = "Foo",
            Email = "foo@bar",
            Phones = { new Person.Types.PhoneNumber { Number = "555-1212" } }
        };

        NetManager.Instance.SendMsgToServer("MSG_PERSON", person);
    }
}
