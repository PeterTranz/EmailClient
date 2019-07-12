using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class RecieveEmail : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Update inbox once every 2 mins
        InvokeRepeating("LoadEmail", 120.0f, 1.0f);
    }

    void LoadEmail() {
        
    }
}
