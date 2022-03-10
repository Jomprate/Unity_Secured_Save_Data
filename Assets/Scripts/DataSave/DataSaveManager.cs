using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.Build.Reporting;
using UnityEngine;


public class DataSaveManager : MonoBehaviour
{
    public static DataSaveManager instance;

    private string directoryName = "SecuredData";
    private string saveFileName = "save";
    private string enSaveFileName = "enSave";
    private string _basePath;
    public string normalSavePath;
    public string encryptedSavePath;
    
    public SaveDataObject saveDataObject;
    
    public string json;
    public string encryptedJson;

    

    public bool Encrypt = false;

    private void Awake()
    {
        instance = this;
    }
    
    public void Start()
    {
        CreateDirectory();
        SetNeededPaths();
        //Save(saveDataObject);
        saveDataObject = new SaveDataObject
        {
            userDataObjectL = new List<UserDataObject>()
           // PasswordDataL = new List<PasswordData>(),
        };
        json = JsonUtility.ToJson(saveDataObject);
        
        encryptedJson = AESHandler.instance.AESEncryption(json);;

       
        Load();
    }
    
    /// <summary>
    /// This void lets create a directory in the base of the UserProfile using the directoryName you selected.
    /// in windows is commonly in C:\Users\'playerUser'
    /// </summary>
    private void CreateDirectory() {
        Directory.CreateDirectory(Environment.ExpandEnvironmentVariables("%USERPROFILE%\\" + directoryName));
    }
    
    /// <summary>
    /// This void set the paths needed to save the files.
    /// </summary>
    private void SetNeededPaths() {
        _basePath = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\" + directoryName);
        normalSavePath = _basePath + "/" + saveFileName + ".ssd";
        encryptedSavePath = _basePath + "/" + enSaveFileName + ".ssd";
    }
    
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Save();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            DeleteSave();
        }
    }

    public void Save()
    {
        
        saveDataObject = new SaveDataObject
        {
            UserData = saveDataObject.UserData,
            userDataObjectL = saveDataObject.userDataObjectL,
        }; 
        json = JsonUtility.ToJson(saveDataObject);
        encryptedJson = AESHandler.instance.AESEncryption(json);
        // if (Encrypt)
        // {
        //     json = AESHandler.instance.AESEncryption(json);
        //     File.WriteAllText(EncryptedPath,json);
        // }
        // else
        // {
        //     File.WriteAllText(normalSavePath,json);
        // }
        File.WriteAllText(normalSavePath,json);
        File.WriteAllText(encryptedSavePath,encryptedJson);
        
    }

    public void Load()
    {
        if (File.Exists(normalSavePath) && File.Exists(encryptedSavePath))
        {
            SaveDataObject loadedDataObject;
            string saveString = File.ReadAllText(normalSavePath);
            string saveEnString = File.ReadAllText(encryptedSavePath);
            if (Encrypt)
            {
                saveEnString = AESHandler.instance.AESDecryption(saveEnString);
                loadedDataObject = JsonUtility.FromJson<SaveDataObject>(saveEnString);
            }
            else
            {
                loadedDataObject = JsonUtility.FromJson<SaveDataObject>(saveString);
            }

            //saveDataObject.PasswordDataL = loadedDataObject.PasswordDataL;
            saveDataObject.userDataObjectL = loadedDataObject.userDataObjectL;

            //Load();
        }
        else
        {
            Save();
            Load();
        }
        
    }

    public void DeleteSave()
    {
        saveDataObject.userDataObjectL.Clear();
        
        File.Delete(normalSavePath);
        File.Delete(encryptedSavePath);
        
        //Load();
        Save();
        
    }

    public void CreateNewUser()
    {
        //saveDataObject.UserData.userName = UserInfo.UserName;
        //saveDataObject.UserData.userPassword = UserInfo.UserPassword;
    }

    public void CreateNewPasswordData()
    {
        // var createNewPassword = CreateNewPassword.instance;
        // PasswordData data = new PasswordData(
        //     createNewPassword.passwordId,
        //     createNewPassword.email,
        //     createNewPassword.userName,
        //     createNewPassword.userEmail,
        //     createNewPassword.description
        // );
        //
        // saveDataObject.PasswordDataL.Add(data);
        // Save();
        //PasswordContController.instance.AddNewPassword(data.passwordId);

    }
    
    

    
    
    
    
}


