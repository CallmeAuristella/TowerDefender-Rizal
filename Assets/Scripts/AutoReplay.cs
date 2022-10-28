using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class AutoReplay : MonoBehaviour
{
    float timer = 0;
    public TMP_Text info;


    void Start()
    {
        if (Data.isComplate)
        {
            info.text = "Congratulations \n You Win!";
        }
    else
    {
        info.text = "Game Over \n You Lose!";
    }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            Data.isGameOver = false;
            Data.isComplate = false;
            Data.coin = 0;
            SceneManager.LoadScene("Gameplay");
        }
    }
}
