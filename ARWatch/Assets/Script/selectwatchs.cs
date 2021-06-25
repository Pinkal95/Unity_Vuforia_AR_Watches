using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class selectwatchs : MonoBehaviour
{
   public GameObject w1, w2, w3;
   public GameObject a1, a2, a3;
   Animation b1, b2, b3;
   
    void Start()
    {
        b1 = a1.GetComponent<Animation>();
        b2 = a2.GetComponent<Animation>();
        b3 = a3.GetComponent<Animation>();
    }

    public void but1()
    {
        w1.SetActive(true);
        w2.SetActive(false);
        w3.SetActive(false);

        b1["w1anim"].speed = 1;
        b1.Play();
    }
    public void but2()
    {
        w2.SetActive(true);
        w1.SetActive(false);
        w3.SetActive(false);

        b2["w2anim"].speed = 1;
        b2.Play();
    }

    public void but3()
    {
        w1.SetActive(false);
        w2.SetActive(false);
        w3.SetActive(true);

        b3["w3anim"].speed = 1;
        b3.Play();
    }
    public void Close()
    {
        string c = EventSystem.current.currentSelectedGameObject.name;
        if (c == "close1")
        {
            b1["w1anim"].speed = -1;
            b1["w1anim"].time = b1["w1anim"].length;
            b1.Play();
        }
        else if (c == "close2")
        {
            b2["w2anim"].speed = -1;
            b2["w2anim"].time = b2["w2anim"].length;
            b2.Play();
        }
        else if (c == "close3")
        {

            b3["w3anim"].speed = -1;
            b3["w3anim"].time = b3["w3anim"].length;
            b3.Play();
        }

    }
}
