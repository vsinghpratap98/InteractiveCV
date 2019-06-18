using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public GameObject achievements;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void FBbtn()
    {
                Application.OpenURL("https://www.facebook.com/virendra.p.rathore");

    }
    public void Instabtn()
    {
        Application.OpenURL("https://www.instagram.com/vsinghpratap98/");

    }
    public void inbtn()
    {
        Application.OpenURL("https://www.linkedin.com/in/virendra-pratap-singh-rathore-77a838152/");
    }
    public void twibtn()
    {
        Application.OpenURL("https://twitter.com/vsinghpratap98");
    }
    public void achievement(){
        achievements.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
