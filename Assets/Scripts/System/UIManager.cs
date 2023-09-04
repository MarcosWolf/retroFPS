using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    // Shotgun capsule
    public GameObject fallingObjectPrefab;
    public Transform capsuleSpawnPoint;

    // Blood hud when take damage
    public GameObject bloodHudPrefab;
    public Transform bloodSpawnPoint1;
    public Transform bloodSpawnPoint2;
    private float bloodAnimationRandom;

    void Awake()
    {
        instance = this;
    }

    public void SpawnFallingObject()
    {
        GameObject newObject = Instantiate(fallingObjectPrefab, capsuleSpawnPoint.position, Quaternion.identity);
        newObject.transform.SetParent(transform);
    }

    public void SpawnBloodHud()
    {
        bloodAnimationRandom = Random.value;

        if (bloodAnimationRandom <= 0.5f)
        {
            GameObject newObject = Instantiate(bloodHudPrefab, bloodSpawnPoint1.position, Quaternion.identity);
            newObject.transform.SetParent(transform);
        } else {
            GameObject newObject = Instantiate(bloodHudPrefab, bloodSpawnPoint2.position, Quaternion.identity);
            newObject.transform.SetParent(transform);
        }
    }
    
}
