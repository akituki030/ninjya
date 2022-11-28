using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
    
{
    public AudioClip Cute_Walk;
    public AudioClip Hurt;
    public GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            transform.Translate(-1, 0, 0);
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
            GetComponent<AudioSource>().Play();
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.GetComponent<gm>().DecreaseHp();
    }
}
