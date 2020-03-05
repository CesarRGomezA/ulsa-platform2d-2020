using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.MemorySystem;
//using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
   public static Gamemanager instance;
   [SerializeField]

   Score score;

    [SerializeField]

    GameObject menu;

    public Score Score {get => score; }
   
    public GameData gameData {get; set;}

    public GameObject Menu {get => menu;}

   void Awake() 
   {

       if (instance)
       {
           Destroy(gameObject);
       }
       else
       {
           instance = this;
           gameData = new GameData();
       }
       DontDestroyOnLoad(gameObject);
   }

    public void Save()
    {
        MemorySystem.SaveData(gameData);
    }

     public void Load()
    {
        gameData = MemorySystem.LoadData();
    }
    

    public void Delete()
    {
        MemorySystem.DeleteData();
    }

   void Start()
   {

   }
   
}
