using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Type {Brutality, Rapidity, Toxicity}
public abstract class Item : ScriptableObject
{
    public Sprite ItemDisplay;
    public string ItemName;
    public Type ItemType;

    // We might need a reference to the player so we know where to instantiate the bullets and angle of which the projectile will be shot
    public abstract void UseItem();

    public void DestroyItem()
    {

    }



}
