using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerName : MonoBehaviour
{
    public InputField Playernamefield;
    public Text PlayerNameText;

    public InputField inputField;

    public void SetName()
    {
        PlayerPrefs.SetString("Name", Playernamefield.textComponent.text);
    }

    //esto lo añadi
    public void GetPlayerName()
    {
        string name = PlayerPrefs.GetString("Name");
        PlayerNameText.text = name;
    }

    private void Start()
    {
        GetPlayerName();
    }
}