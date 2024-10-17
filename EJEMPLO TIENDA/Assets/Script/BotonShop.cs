using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonShop : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    string nameItem = "Objeto";

    [SerializeField]
    TextMeshProUGUI textButton;

    [SerializeField]
    float priceItem;
    void Start()
    {
        textButton = transform.GetComponent
        priceItem = Random.Range(15f, 10f);
        textButtom
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
