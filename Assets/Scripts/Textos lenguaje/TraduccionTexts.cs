using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TraduccionTexts : MonoBehaviour
{
    public Traduccion traduccion;

    public Text _texto1;
    public Text _texto2;
    public Text _texto3;
    public Text _texto4;
    // Start is called before the first frame update
    void Start()
    {
        _texto1.text = traduccion.texto1;
        _texto2.text = traduccion.texto2;
        _texto3.text = traduccion.texto3;
        _texto4.text = traduccion.texto4;
    }
}
