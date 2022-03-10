using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class UserDataObject: IDataObject
{
    
    public string userName;
    public string userEmail;
    public string description;
    
    
    public UserDataObject(string userName,string userEmail, string description)
    {
        
        this.userName = userName;
        this.userEmail = userEmail;
        this.description = description;
    }
    
}
