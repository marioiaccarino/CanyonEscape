using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;

    public int zPos = 38;

    public bool creatingSection = false;

    public int sectionNumber;
   
    void FixedUpdate()
    {
      if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }  
    }

    IEnumerator GenerateSection()
    {
        sectionNumber = Random.Range(0, 3);
        Instantiate(section[sectionNumber], new Vector3(0,0,zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
