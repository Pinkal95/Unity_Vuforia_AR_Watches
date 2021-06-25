using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class colorselection : MonoBehaviour
{
    // Start is called before the first frame update
    public Material m1,m2,m3;
    void Start()
    {
        
    }
    public void w1()
    {
        string b = EventSystem.current.currentSelectedGameObject.name;
        if (b == "Blue_Button_w1")
        {
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#2026E7", out mycolor);
            m1.color = mycolor;

        }
        else if (b == "Black_Button_w1")
        {
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out mycolor);
            m1.color = mycolor;
        }


    }
    public void w2()
    {
        string b = EventSystem.current.currentSelectedGameObject.name;
        if (b == "Red_Button_w2")
        {
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#E3281E", out mycolor);
            m2.color = mycolor;

        }
        else if (b == "Black_Button_w2")
        {
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out mycolor);
            m2.color = mycolor;

        }

    }

    public void w3()
    {
        string b = EventSystem.current.currentSelectedGameObject.name;
        if (b == "Blue_Button_w3")
        {
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#2026E7", out mycolor);
            m3.color = mycolor;
        }
        else if (b == "w_Button_w3")
        {
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#FFFFFF", out mycolor);
            m3.color = mycolor;
        }

    }

}
