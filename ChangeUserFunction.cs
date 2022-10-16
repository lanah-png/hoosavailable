using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeUserFunction : MonoBehaviour
{
    public TextAsset check;

    public void Start() {
        ChangeUser toChange = JsonUtility.FromJson<ChangeUser>(check.text);
        toChange.setMyValue(0);
        FileHandler.RegularSaveToJSON<ChangeUser>(toChange, check);
    }

    public void IncreaseValue()
    {
        ChangeUser toChange = JsonUtility.FromJson<ChangeUser>(check.text);
        toChange.setMyValue(1);
        FileHandler.RegularSaveToJSON<ChangeUser>(toChange, check);
    }
}
