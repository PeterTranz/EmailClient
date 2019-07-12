using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour
{
    /*
    Login into your email account 
    */

    public string UserEmail;
    public string UserPassword;

    public InputField User;
    public InputField Pass;

    public GameObject MainPanel;
    public GameObject UserLogin;

    // Start is called before the first frame update
    void Awake() {
        MainPanel.SetActive(false);
    }

    // Update is called once per frame
    void GUI() {
        if (User) {
            TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
            UserEmail = User.text;
        }

        if (Pass) {
            TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
            UserPassword = Pass.text;
        }
    }

    public void Submit() {
        if (UserEmail == null && UserPassword == null) {
            return;
        }
        UserLogin.SetActive(false);
        MainPanel.SetActive(true);
    }
}
