using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SpawnEnemy : MonoBehaviour
{
    private const float spawnRate = 2.0f;
    private float spawnRealTime = 0;
    public GameObject enemy;
    public float dx =17;

    public TextAsset csvFile;
    List<string[]> csvDatas = new List<string[]>();

    //static TextAsset csvData;
    //List<string[]> csvDatas = new List<string[]>();//可変長配列。先頭だけ表示され、その次のメモリのみわかる。動的な配列
    //public List<Vector3> spawnPos = new List<Vector3>();

    /*public void CsvRead()
    {
        csvData = Resources.Load("SpawnData/Map_01") as TextAsset;
        StringReader reader = new StringReader(csvData.text);

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            csvDatas.Add(line.Split(','));//要素の追加
        }
        
        foreach(string[] data in csvDatas)
        {

        }
    }*/

    // Start is called before the first frame update
    void Start()
    {
        string[] lines = csvFile.text.Replace("\r\n", "\n").Split("\n"[0]);
        var enemyData = new List<EnemyStatus>();
        foreach (var line in lines)
        {
            var ENEMY = new EnemyStatus
            {
                Enemy = line.Split(',')[0],
                Duration = int.Parse(line.Split(',')[1]),
                PositionX = int.Parse(line.Split(',')[2]),
                PositionY = int.Parse(line.Split(',')[3]),
                PositionZ = int.Parse(line.Split(',')[4])
            };
            enemyData.Add(ENEMY);
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;
        if (spawnRealTime >= spawnRate)
        {
            spawnNewEnemy();
            spawnRealTime = 0;
        }
    }


    void spawnNewEnemy()
    {
        GameObject newenemy = Instantiate(enemy, new Vector3(dx,0,0), Quaternion.identity);
    }
}

