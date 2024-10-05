using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Type {Brutality, Rapidity, Toxicity, Neutral}
public abstract class Item : ScriptableObject
{
    public Sprite ItemDisplay;

    public abstract void UseItem();

    public void DestroyItem()
    {

    }

}
