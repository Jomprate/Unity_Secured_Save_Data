using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]

public class SaveDataObject
{
    public UserData UserData;
    //public List<PasswordData> PasswordDataL;
    public List<UserDataObject> userDataObjectL;
    public TravelsExecuted TravelsExe;
}




[Serializable]
public class TravelsExecuted
{
    public int TravelsQ;
}

[Serializable]
public class UserData
{
    public int userId;
    public string userName;
    public string userPassword;
}
