using System;
using Unity.VisualScripting;
using UnityEngine;

public enum PlayerState
{
    Idle = 0,
    Walking = 1,
    Running = 2,
    Die,
}

public class Player : MonoBehaviour
{
    public PlayerData data;

    private void Start()
    {
        Initialize();
    }

    /// <summary>
    /// 플레이어가 현재 위치한 곳을 저장한다.
    /// </summary>
    private void Initialize()
    {
        data.currentPosition = this.transform.position;
    }
}

[System.Serializable]
public class PlayerAnimation
{
    public PlayerState state = PlayerState.Idle;
}

[System.Serializable]
public class PlayerData
{
    public string id = "Player";    // value(값) : "Player"
    public string name = "JuHwan";
    public Vector3 currentPosition;
    public string currentLocation;
    public PlayerAnimation PlayerAnimation;
}