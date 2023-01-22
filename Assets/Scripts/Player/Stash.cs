using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stash : MonoBehaviour
{

    public Transform stashParent;
    public List<Stashable> CollectecPrefabs = new List<Stashable>();
    public int CollectedCount => CollectecPrefabs.Count;
    public float collectionHeight = 1;
    public int maxCollectableCount = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddStash(Collectable collectedObject)
    {
        if (CollectedCount >= maxCollectableCount)
            return;

        var yLocalPosition = CollectedCount * collectionHeight;

        var stashable = collectedObject.Collect();
        stashable.CollectStashable(stashParent, yLocalPosition, CompleteCollection);
        CollectecPrefabs.Add(stashable);

    }

    private void CompleteCollection()
    {


    }

    public Stashable RemoveStash()
    {
        if (CollectedCount <= 0)
            return null;

        var stashable = CollectecPrefabs[CollectedCount - 1];

        CollectecPrefabs.Remove(stashable);
        stashable.transform.parent = null;

        return stashable;

    }
}
