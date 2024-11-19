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
    public static GameObject Player;
    public GameState state;

    public static GameManager Instance{ get; private set; }

    
    private void Awake()
    {
        Instance = this;
    }


}
