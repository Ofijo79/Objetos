using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Text itemType;
    public Lenguaje[] botonesPorIdioma;
    private int idiomaActual = 0;

    void Start()
    {
        ActualizarTextoBoton();
    }

    public void CambiarIdioma(int idioma)
    {
        idiomaActual = idioma;
        ActualizarTextoBoton();
    }

    void ActualizarTextoBoton()
    {
        if (idiomaActual >= 0 && idiomaActual < botonesPorIdioma.Length)
        {
            itemType.text = botonesPorIdioma[idiomaActual].textoBoton;
        }
    }
}
