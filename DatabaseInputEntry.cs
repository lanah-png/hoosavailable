using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class DatabaseInputEntry
{
    public string myID;
    public string myName;
    public string myPhone;
    public string myStatus;
    public string myLocation;
    public string myPicture;

    public DatabaseInputEntry (string ID, string name, string phone, string status, string location, string picture) {
        myID = ID;
        myName = name;
        myPhone = phone;
        myStatus = status;
        myLocation = location;
        myPicture = picture;
    }

    public string getMyID () {
        return myID;
    }
    
    public string getMyName () {
        return myName;
    }
    
    public string getMyPhone () {
        return myPhone;
    }

    public string getMyStatus () {
        return myStatus;
    }
    
    public string getMyLocation () {
        return myLocation;
    }
    
    public string getMyPicture () {
        return myPicture;
    }
}
