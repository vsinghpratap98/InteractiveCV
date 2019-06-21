using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncollisionIEEE : MonoBehaviour
{
    public GameObject image;
    // Start is called before the first frame update
    public void OnMouseDown(){
        image.SetActive(true);
    }
    public void backbutton(){
        image.SetActive(false);
    }
    
}
