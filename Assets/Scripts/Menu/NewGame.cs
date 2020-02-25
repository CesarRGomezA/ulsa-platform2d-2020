using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platform2DUtils.MemorySystem;

public class NewGame : MonoBehaviour
{
    [SerializeField]
    InputField fileName;

    [SerializeField]
    Button btnNewGame;

    void Save()
    {
        MemorySystem.SaveData(GameManager.instance.gameData, );
    }

}
