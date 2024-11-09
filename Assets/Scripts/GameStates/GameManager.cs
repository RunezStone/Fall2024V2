using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    LoadState,
    PlayState,
    EndState
}
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameState state;

    private void Awake()
    {
        instance = this;  
    }

}
