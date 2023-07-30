using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseGlasses : MonoBehaviour
{
    public GameObject glasses1;
     public GameObject glasses2;
      public GameObject glasses3;

      Button glasses1Button;
       Button glasses2Button;
        Button glasses3Button;

    // Start is called before the first frame update
    void Start()
    {
        glasses1Button = GameObject.Find("Canvas/glasses1button").GetComponent<Button>();
        glasses2Button = GameObject.Find("Canvas/glasses2button").GetComponent<Button>();
        glasses3Button = GameObject.Find("Canvas/glasses3button").GetComponent<Button>();

        glasses1Button.onClick.AddListener(Glasses1Selected);
        
        glasses2Button.onClick.AddListener(Glasses2Selected);
        
        glasses3Button.onClick.AddListener(Glasses3Selected);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Glasses1Selected(){
        glasses1.SetActive(true);
          glasses2.SetActive(false);
            glasses3.SetActive(false);

    }
    public void Glasses2Selected(){
        glasses1.SetActive(false);
          glasses2.SetActive(true);
            glasses3.SetActive(false);

    }
    public void Glasses3Selected(){
        glasses1.SetActive(false);
          glasses2.SetActive(false);
            glasses3.SetActive(true);

    }
}
