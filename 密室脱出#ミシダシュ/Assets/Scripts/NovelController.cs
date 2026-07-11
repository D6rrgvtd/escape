using System.Collections;
using UnityEngine;
using TMPro; // 文字表示用のシステム

public class NovelController : MonoBehaviour
{
    public TextMeshProUGUI novelText; 
    public GameObject novelPanel;     
    public GameObject NetPanel;  

    private string introduction = "……う、頭が痛い……。\nここは……どこだ？";

    void Start()
    {
        
        novelPanel.SetActive(true);
        NetPanel.SetActive(false);

      
        StartCoroutine(TypeText(introduction));
    }

    IEnumerator TypeText(string textToType)
    {
        novelText.text = "";
        foreach (char letter in textToType.ToCharArray())
        {
            novelText.text += letter; 
            yield return new WaitForSeconds(0.05f); 
        }

       
        yield return new WaitForSeconds(3.0f);
        ToTwitterScreen();
    }

    void ToTwitterScreen()
    {
        novelPanel.SetActive(false);   
        NetPanel.SetActive(true);  
    }
}
