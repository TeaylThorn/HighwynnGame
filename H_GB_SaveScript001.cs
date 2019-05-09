using System;
using UnityEngine;

[Serializable]

public class CharacterData
{
    public string characterName;
    public float power;
    public int bullets;
}

public class PlayerPrefsCharacterSaver : using UnityEngine;

public class H_GB_SaveScript001 : MonoBehaviour    
{
    public CharacterData characterData;


    void Update()
    {
        if(Input.GetKeyDown (KeyCode.S))
        SaveCharacter (characterData, 0);

        if (Input.GeyKeyDown (Keycode.L))
        characterData = LoadCharacter (0);
    }

    static void SaveCharacter (CharacterData data, int characterSlot)
    {
        PlayerPrefs.SetString ("characterName_CharcterSlot" + characterSlot, data.characterName);
        PlayerPrefs.SetFloat ("power_CharacterSlot" + characterSlot, data.power);
        PlayerPrefs.SetInt ("bullets_CharacterSlot" + characterSlot, data.bullets);
        PlayerPrefs.Save ();
    }

    static CharacterData LoadCharacter (int characterSlot)
    {
        CharacterData loadedCharacter = new CharacterData ();
        loadedCharacter.characterName = PlayerPrefs.GetString ("characterName_CharacterSlot" + characterSlot)
        loadedCharacter.power = PlayerPrefs.GetFloat ("power_CharacterSlot" + characterSlot);

        return loadedCharacter
    }
}
