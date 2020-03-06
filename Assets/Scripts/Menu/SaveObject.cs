using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platform2DUtils.MemorySystem;
using UnityEngine.SceneManagement;

public class SaveObject : MonoBehaviour
{

    [SerializeField]
    Button btnSave;

    [SerializeField]
    Text txtName;
 

    void Awake() 
    {
        btnSave = GetComponent<Button>(); 
        btnSave.onClick.AddListener(LoadSave);
    }

    public string fileName
    {
        get => txtName.text;
        set => txtName.text = value;
    }

    void LoadSave()
    {
        Gamemanager.instance.gameData = MemorySystem.LoadData($"{MemorySystem.SavePath}/{fileName}");
        LoadScene();
    }

    void LoadScene()
    {
        SceneManager.LoadScene(1);
        Gamemanager.instance.Score.gameObject.SetActive(true);
        Gamemanager.instance.Menu.SetActive(false);
    }

}
