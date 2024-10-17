using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ejemploBucle : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] arrayNumeros;
    [SerializeField]
    TextMeshProUGUI NotaMasAlta;

    [SerializeField]
    TextMeshProUGUI NotaMasBaja;

    [SerializeField]
    TextMeshProUGUI Media;

    void Start()
    {
        int sumaDeNotas = 0;
        int notaBaja = arrayNumeros[0];
        int notaAlta = arrayNumeros[0];

        for (int i = 0; i < arrayNumeros.Length; i++)
        {

            sumaDeNotas += arrayNumeros[i];
            if (arrayNumeros[i] > notaAlta)
            {
                notaAlta = arrayNumeros[i];

            }

            if (arrayNumeros[i] < notaBaja)
            {
                notaBaja = arrayNumeros[i];
            }

            //Debug.Log("Nota en el ejercicio " + arrayNumeros[i]);
        }
        int Alta = notaAlta;
        int Baja = notaBaja;
        int notaMedia = sumaDeNotas / arrayNumeros.Length;

        Debug.Log("La media de las notas es " + notaMedia);
        Debug.Log("La nota mas alta es " + Alta);
        Debug.Log("La nota mas baja es " + Baja);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void calcular()
    {
        int sumaDeNotas = 0;
        int notaBaja = arrayNumeros[0];
        int notaAlta = arrayNumeros[0];

        for (int i = 0; i < arrayNumeros.Length; i++)
        {

            sumaDeNotas += arrayNumeros[i];
            if (arrayNumeros[i] > notaAlta)
            {
                notaAlta = arrayNumeros[i];

            }

            if (arrayNumeros[i] < notaBaja)
            {
                notaBaja = arrayNumeros[i];
            }

            //Debug.Log("Nota en el ejercicio " + arrayNumeros[i]);
        }
        int Alta = notaAlta;
        int Baja = notaBaja;
        int notaMedia = sumaDeNotas / arrayNumeros.Length;

        NotaMasAlta.text = Alta.ToString();
        NotaMasBaja.text = Baja.ToString();
        Media.text = notaMedia.ToString();
    }
}
