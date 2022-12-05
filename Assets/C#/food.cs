using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameObject");
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
