using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapSelect : MapList
{
    /*public enum MAP
    {
        MAP1,
        MAP2
    }
    public MAP mMap;

    public void OnClick()
    {
        switch (mMap)
        {
            case MAP.MAP1:
                SceneManager.LoadScene("Game");
                break;
            case MAP.MAP2:
                SceneManager.LoadScene("Game");
                break;
            default:
                break;
        }
    }

    public void setMap(MAP map)
    {
        mMap = map;
    }
    public MAP GetMAP()
    {
        return mMap;
    }*/

    //public Button Map1 = GameObject.Find("/Camvas/ButtonMap1").GetComponent<Button>();
    //public Button Map2 = GameObject.Find("/Camvas/ButtonMap2").GetComponent<Button>();

    public static TextAsset csvFile;

    void Start()
    {
        
    }

    protected override void OnClick(string objectName)
    {
        if ("ButtonMap1".Equals(objectName))
        {
            this.Map1Click();
            csvFile = Resources.Load("SpawnData/Map_01") as TextAsset;
            LoadingNewScene();
        }
        else if ("ButtonMap2".Equals(objectName))
        {
            this.Map2Click();
            csvFile = Resources.Load("SpawnData/Map_02") as TextAsset;
            LoadingNewScene();
        }
    }

    public void LoadingNewScene()
    {
        SceneManager.LoadScene("Game");
    }

    private void Map1Click()
    {
        Debug.Log("MAP1");
    }
    private void Map2Click()
    {
        Debug.Log("MAP2");
    }
}
