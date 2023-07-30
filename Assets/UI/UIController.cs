using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour
{
    public GameObject g1info;
    public GameObject g2info;
    public GameObject g3info;

    public Material g1Material;
      public Material g2Material;

        public Material g3Material;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void G1InfoBoxEnable(){
        g1info.SetActive(true);
    }
    
    public void G1InfoBoxDisable(){
  g1info.SetActive(false);
    }

    public void G2InfoBoxEnable(){
  g2info.SetActive(true);
    }
    
    public void G2InfoBoxDisable(){
          g2info.SetActive(false);
    }
    public void G3InfoBoxEnable(){
  g3info.SetActive(true);
    }
    
    public void G3InfoBoxDisable(){
          g3info.SetActive(false);
    }

    public void Glasses1ColorChange(){
      string buttonName = EventSystem.current.currentSelectedGameObject.name;

      if(buttonName == "blackcolorbutton"){
        g1Material.color = new Color(0,0,0);
      }
      else if(buttonName == "bluecolorbutton"){
               g1Material.color = new Color(0.1f,0.3f,0.8f);
      }
    }

    public void Glasses2ColorChange(){
         string buttonName = EventSystem.current.currentSelectedGameObject.name;

      if(buttonName == "blackcolorbutton"){
        g2Material.color = new Color(0,0,0);
      }
      else if(buttonName == "bluecolorbutton"){
               g2Material.color = new Color(0.1f,0.3f,0.8f);
      }
    }

    public void Glasses3ColorChange(){
         string buttonName = EventSystem.current.currentSelectedGameObject.name;

      if(buttonName == "blackcolorbutton"){
        g3Material.color = new Color(0,0,0);
      }
      else if(buttonName == "bluecolorbutton"){
               g3Material.color = new Color(0.1f,0.3f,0.8f);
      }
    }
public void BuyG1(){
Application.OpenURL("https://www.amazon.in/Faddish-Anti-glare-Spectacle-Protection-BUBBLE/dp/B08HSQ1WWK/ref=sr_1_25?crid=1FTF0E4L34QZU&keywords=computer+glasses+in+round+black+frame&qid=1688301926&s=watches&sprefix=computer+glasses+in+round+black+fram%2Cwatches%2C259&sr=1-25");
}
public void BuyG2(){
    Application.OpenURL("https://www.amazon.in/Roshfort-Eyeglasses-Spectacle-Protection-Computer/dp/B09LJ2F4SZ/ref=sr_1_18?crid=1FTF0E4L34QZU&keywords=computer+glasses+in+round+black+frame&qid=1688301926&s=watches&sprefix=computer+glasses+in+round+black+fram%2Cwatches%2C259&sr=1-18");
}
public void BuyG3(){
    Application.OpenURL("https://www.amazon.in/reflextion-PROTECTED-Spectacles-Protection-Eyeglasses/dp/B097NH8K7V/ref=sr_1_3?crid=1FTF0E4L34QZU&keywords=computer+glasses+in+round+black+frame&qid=1688301926&s=watches&sprefix=computer+glasses+in+round+black+fram%2Cwatches%2C259&sr=1-3");
}

}
