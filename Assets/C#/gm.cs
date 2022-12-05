using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gm : MonoBehaviour
{
    public GameObject arrow;
    //float span = 1.0f;
    //float delta = 0;
    public GameObject hpGauge;
    public GameObject catfood;
    public Text scort;
    int socc;

    // Start is called before the first frame update
    void Start()
    {
        scort.text = $"分數：{socc}";
        InvokeRepeating("rog", 0, 1.0f);
        InvokeRepeating("cat", 3, 1.75f);
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
    void rog()
    {
        int px = Random.Range(-6, 7);
        Instantiate(arrow, new Vector3(px, 7, 0), Quaternion.identity);
    }


    void cat()
    {
        int px = Random.Range(-6, 7);
        Instantiate(catfood, new Vector3(px, 7, 0), Quaternion.identity);
    }
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        socc -= 100;
        scort.text = $"分數：{socc}";
    }
    public void scorttext() 
    {
       
        socc += 100;
        scort.text = $"分數：{socc}";
    }
    public void uphp() 
    {
     hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }
}
