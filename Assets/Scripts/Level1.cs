using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    private int RandomNumber;
    public List<Sprite> Sprites = new List<Sprite>();
    public GameObject ImgPanel;
    public GameObject WinLosePanel;
    public GameObject WinLoseText;
    public GameObject NextButton;
    public GameObject RestartButton;
    public GameObject LoseButton;

    // Start is called before the first frame update
    void Start()
    {
        //insert image to GridLayout
        float constraintCount = ImgPanel.GetComponent<GridLayoutGroup>().constraintCount;
        float width = Screen.width / constraintCount;
        float height = Screen.height / constraintCount;
        RandomNumber = Random.Range(0, 10);
        int spriteIndex = Random.Range(0, 2);
        Debug.Log("Number:" + RandomNumber);
        Sprite sprite = Sprites[spriteIndex];
        // ImgPanel.GetComponent<GridLayoutGroup>().cellSize = new Vector2(height, height);
        for (int i = 0; i < RandomNumber; i++)
        {
            GameObject newObject = new GameObject();
            Image img = newObject.AddComponent<Image>();
            img.sprite = sprite;
            newObject.transform.SetParent(ImgPanel.transform);
        }
        /////////////////////////////////////////////
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClick(int answer)
    {
        TextMeshProUGUI textMest = WinLoseText.GetComponent<TextMeshProUGUI>();
        if (answer == RandomNumber)
        {
            textMest.text = "You Win";
            NextButton.SetActive(true);
            RestartButton.SetActive(true);
        }
        else
        {
            NextButton.SetActive(false);
            LoseButton.SetActive(true);
            textMest.text = "You Lose";
        }
        WinLoseText.SetActive(true);
        WinLosePanel.SetActive(true);
    }

    public void Restart(string level)
    {
        SceneManager.LoadScene("Level1");
    }

    public void Back()
    {
        SceneManager.LoadScene("Home");
    }

    public void Next(string level)
    {
        SceneManager.LoadScene("Level2");
    }
}
