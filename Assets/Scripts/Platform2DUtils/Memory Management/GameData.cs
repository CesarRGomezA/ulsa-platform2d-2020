using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]


public class GameData 
{
  [SerializeField]  
  Player player;
  [SerializeField]
  Vector3 playerPos;
  [SerializeField]
  string gameName;

  public GameData(){}

  public GameData(Vector3 playerPos, string gameName)
  {
    this.playerPos = playerPos;
    this.gameName = gameName;
  }

  public Player Player
  {
      get => player;
      set => player = value;
  }
  public Vector3 PlayerPos { get => playerPos; set => playerPos = value; }

  public Vector3 gameName { get => gameName; set => gameName = value; }
}
