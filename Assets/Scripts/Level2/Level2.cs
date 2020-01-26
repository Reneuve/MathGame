using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Level2 : MonoBehaviour
{
    public List<Sprite> Sprites = new List<Sprite>();
    public GameObject ImgPanel;
    private int RandomNumber;
    public GameObject WinLoseText;
    public GameObject WinLosePanel;
    public GameObject NextButton;

    // Start is called before the first frame update
    void Start()
    {
        RandomNumber = Random.Range(0, 10);
        Debug.Log("Random" + RandomNumber);
        int spriteIndex = Random.Range(0, 2);
        Sprite sprite = Sprites[spriteIndex];
        for (int i = 0; i < RandomNumber; i++)
        {
            GameObject newObject = new GameObject();
            Image image = newObject.AddComponent<Image>();
            image.sprite = sprite;
            newObject.transform.SetParent(ImgPanel.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick(int number)
    {
        Debug.Log(number);
        if (number == RandomNumber)
        {
            WinLoseText.GetComponent<TextMeshProUGUI>().text = "You Win";
            NextButton.SetActive(true);
        }
        else
        {
            WinLoseText.GetComponent<TextMeshProUGUI>().text = "You Lose";
            NextButton.SetActive(false);
        }
        WinLoseText.SetActive(true);
        WinLosePanel.SetActive(true);
    }

    public void again()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Next()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Back()
    {
        SceneManager.LoadScene("Home");
    }
    
}
