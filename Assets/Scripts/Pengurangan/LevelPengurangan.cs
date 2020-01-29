using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelPengurangan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void level1()
    {
        SceneManager.LoadScene("Level1_Pengurangan");
    }

    public void level2()
    {
        SceneManager.LoadScene("Level2_Pengurangan");
    }

    public void level3()
    {
        SceneManager.LoadScene("Level3_Pengurangan");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
