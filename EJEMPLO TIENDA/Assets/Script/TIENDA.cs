using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TIENDA : MonoBehaviour
{
    [SerializeField]
    float saldo;

    [SerializeField]
    TextMeshProUGUI labelsaldo;

    private void Start()
    {
        saldo = Random.Range(450f, 950f);
        labelsaldo.text = saldo.ToString("000.00");
    }
    public void Comprar()
    {
        
    }

    public void RestarSaldo(float precio)
    {
        if (saldo > precio)
        {
            saldo = precio;
            labelsaldo.text = saldo.ToString("00.00") + "$";
        }
        else
        {
            saldo.SetActive(false);

        }
    }
}
