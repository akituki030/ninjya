using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
     public GameObject gm;
    bool isscorttext = false;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameObject");
        Destroy(gameObject,3);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6.5&&isscorttext==false) 
        {

            gm.GetComponent<gm>().scorttext();
            isscorttext = true;
        }
        
    }
    /*public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        if (collision.tag == "arrow")
        {
            gm.GetComponent<gm>().DecreaseHp();
        }
        else if (collision.tag == "catfood")
        { 
        gm.GetComponent<gm>().uphp();
        }

    }*/
}
