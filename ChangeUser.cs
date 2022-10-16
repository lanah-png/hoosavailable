using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ChangeUser
{
    public int myValue;

    public ChangeUser(int value) {
        myValue = value;
    }

    public int getMyValue()
    {
        return myValue;
    }

    public void setMyValue(int value)
    {
        myValue = value;
    }
}
