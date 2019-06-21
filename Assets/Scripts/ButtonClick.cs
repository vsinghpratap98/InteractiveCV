using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public GameObject ProfPanel;
    public GameObject ExtraPanel;

    public GameObject AcadePanel;

    public GameObject Proachievements;
    public GameObject Xtraachievements;
    public GameObject Academicachievements;
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
    public void achievement()
    {
        Proachievements.SetActive(true);
        Xtraachievements.SetActive(true);
        Academicachievements.SetActive(true);
        ExtraPanel.SetActive(false);        
        ProfPanel.SetActive(false);
        AcadePanel.SetActive(false);

    }
    public void OnClickPro()
    {
        ProfPanel.SetActive(true);
                ExtraPanel.SetActive(false); 
                        AcadePanel.SetActive(false);
       

    }
    public void OnClickX()
    {
        ExtraPanel.SetActive(true);        
        ProfPanel.SetActive(false);
        AcadePanel.SetActive(false);

    }
    public void OnClickAcade()
    {   ExtraPanel.SetActive(false);        
        ProfPanel.SetActive(false);
        AcadePanel.SetActive(true);
    }
    public void whtsappbtn()
    {
        Application.OpenURL("https://wa.me/<918076318675>");
    }


    // Update is called once per frame
    void Update()
    {

    }
}
