using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class DataSavePlayer
{
    
}

[System.Serializable]
public class DataSaveUser
{
    public void NewData()
    {
        
    }


}

public class DataUser : GameData
{


    [SerializeField] private DataSaveUser dataSave;

    public DataSaveUser DataSave { get => dataSave; set => dataSave = value; }

    public override void SaveData()
    {
        DataManager.Instance.SaveData<DataSaveUser>(GetName(), dataSave);
    }

    public override void LoadData()
    {
        dataSave = DataManager.Instance.LoadData<DataSaveUser>(GetName());
    }

    public override void NewData()
    {
        dataSave = new DataSaveUser();
        dataSave.NewData();
    }

}
