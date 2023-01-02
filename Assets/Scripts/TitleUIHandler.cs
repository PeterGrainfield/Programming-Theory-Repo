using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TitleUIHandler : MonoBehaviour
{
    public TextMeshProUGUI userNameText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetNameAndGo()
    {
        GameManager.Instance.SetUserName(userNameText.text);
        GameManager.Instance.StartGame();
    }
}
