using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Traducciones", menuName = "Idiomas")]
public class Lenguaje : ScriptableObject
{
    public enum ItemType
    {
        Espanol,
        Ingles,
        Aleman
    }

    public ItemType itemType;
    public string itemDescription;
    public string itemDescription2;
    public string itemDescription3;
    public Sprite itemSprite;
}
