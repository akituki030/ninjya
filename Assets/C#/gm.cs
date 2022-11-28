using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gm : MonoBehaviour
{
    public GameObject arrow;
    float span = 1.0f;
    float delta = 0;
    public GameObject hpGauge;
    public Text scort;
    int socc;
    int debuff;

    // Start is called before the first frame update
    void Start()
    {
        scort.text = $"分數：{socc}";
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span) 
        {
            delta = 0;
            int px = Random.Range(-6, 7);

            Instantiate(arrow, new Vector3(px, 7, 0), Quaternion.identity);
        }
    }
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        
        
    }
    public void scorttext() 
    {
        
        socc += 100;
        scort.text = $"分數：{socc}";
        
        

    }
}
