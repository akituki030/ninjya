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
        gm = GameObject.Find("GameObject");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
            this.GetComponent<AudioSource>().clip = Cute_Walk;
            this.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
            this.GetComponent<AudioSource>().clip = Cute_Walk;
            this.GetComponent<AudioSource>().Play();
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.GetComponent<AudioSource>().clip = Hurt;
        this.GetComponent<AudioSource>().Play();
        
        if (collision.tag == "arrow")
        {
            gm.GetComponent<gm>().DecreaseHp();
        }
        else if (collision.tag == "catfood")
        {
            gm.GetComponent<gm>().uphp();
        }

    }
   
}
