using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{

    /*
    Manages betweens the different tabs of UI
    */

    public GameObject InboxPanel;
    public GameObject ArchivePanel;
    public GameObject SentPanel;
    public GameObject ComposePanel;

    bool A = false;
    bool B = false;
    bool S = false;

    // Start is called before the first frame update
    void Start()
    {
        InboxPanel.SetActive(true);
        ArchivePanel.SetActive(false);
        SentPanel.SetActive(false);
        ComposePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckInbox() {
        //UI for emails
        InboxPanel.SetActive(true);
        ArchivePanel.SetActive(false);
        SentPanel.SetActive(false);
        ComposePanel.SetActive(false);

        //Reset values
        A = false;
        B = false;
        S = false;
    }

    public void CheckArchive() {
        //UI for archived emails
        A = !A;
        InboxPanel.SetActive(!A);
        ArchivePanel.SetActive(A);
        ComposePanel.SetActive(false);

    }

    public void CheckSent() {
        //UI for sent emails
        B = !B;
        InboxPanel.SetActive(!B);
        SentPanel.SetActive(B);
        ComposePanel.SetActive(false);

    }

    public void SendMail() {
        //UI for sending email
        S = !S;
        InboxPanel.SetActive(!S);
        ComposePanel.SetActive(S);

        //Reset all fields to empty
        ComposeEmail.instance.RecieverEmail = null;
        ComposeEmail.instance.SenderEmail = null;
        ComposeEmail.instance.Subject = null;
        ComposeEmail.instance.Message = null;
    }
}
