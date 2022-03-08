using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoManager : MonoBehaviour
{
    [SerializeField] private GameObject thisLevel;
    [SerializeField] private GameObject otherLevel;
    [SerializeField] private GameObject otherLevel1;
    [SerializeField] private GameObject otherLevel2;
    [SerializeField] private GameObject otherLevel3;
        
    
    public void ChangeLevel()
    {
        
        thisLevel.SetActive(true);
        otherLevel.SetActive(false);
        otherLevel1.SetActive(false);
        otherLevel2.SetActive(false);
        otherLevel3.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
