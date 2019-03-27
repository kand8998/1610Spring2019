using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collection : ScriptableObject
{

    public List<FloatData> CollectionList;
        
    public void Collect(FloatData obj)
    {
        CollectionList.Add(obj);
    }

    public void CollectionInfo()
    {
        foreach (var obj in CollectionList)
        {
            Debug.Log(obj);
        }
    }

    public void AmmoInfo()
    {
        foreach (var obj in CollectionList)
        {
            if (obj.name == "Ammo")
            {
                Debug.Log("We have" + obj.Value + "Ammo");
            }
        }
    }

    public void PlayerScoreInfo()
    {
        foreach (var obj in CollectionList)
        {
            if (obj.name == "PlayerScore")
            {
                Debug.Log("We have" + obj.Value + "Points!");
            }
        }
    }

    public void HealthInfo()
    {
        for (int i = 0; i < CollectionList.Count; i++)
        {

            if (CollectionList[i].name == "Health")
            {
                Debug.Log(CollectionList[i]);
            }
        }
    }

    public void GameTimeInfo()
    {
        for (int i = 0; i < CollectionList.Count; i++)
        {
            if (CollectionList[i].name == "GameTime")
            {
                Debug.Log(CollectionList[i]);
            }
        }
    }
}
