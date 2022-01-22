using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SpawnEnemy : MonoBehaviour
{
    //private const float spawnRate = 2.0f;
    private float spawnRealTime = 0;
    public GameObject enemy;
    List<EnemyStatus> enemyDataList = new List<EnemyStatus>();

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
        //var enemyData = new List<EnemyStatus>();
        bool skilpflag = false;

        foreach (string line in lines)
        {
            if (!skilpflag)
            {
                skilpflag = true;
                continue;
            }
            if (line.Equals(""))
            {
                continue;
            }
            var ENEMY = new EnemyStatus
            {
                isSpawned = false,
                EnemyType = line.Split(',')[0],
                Duration = float.Parse(line.Split(',')[1]),
                Position = new Vector3(float.Parse(line.Split(',')[2]), float.Parse(line.Split(',')[3]), float.Parse(line.Split(',')[4]))  
            };
            enemyDataList.Add(ENEMY);
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;
        for(int i = 0; i < enemyDataList.Count; i++)
        {
            if (spawnRealTime >= enemyDataList[i].Duration)
            {
                if (enemyDataList[i].isSpawned == false)
                {
                    spawnNewEnemy(enemyDataList[i].Position, enemyDataList[i].EnemyType);
                    enemyDataList[i].isSpawned = true;
                }
            }
        }
        
    }

    void spawnNewEnemy(Vector3 position,string Type)
    {
        GameObject newenemy = Instantiate(enemy, position, Quaternion.identity);
        Enemy newEnemyComponent = newenemy.GetComponent<Enemy>();
        if (newEnemyComponent != null)
        {
            if (Type.Equals("UP"))
            {
                newenemy.GetComponent<Enemy>().setType(Enemy.TYPE.UP);
            }
            else if (Type.Equals("DOWN"))
            {
                newenemy.GetComponent<Enemy>().setType(Enemy.TYPE.DOWN);
            }
        }
    }
}

