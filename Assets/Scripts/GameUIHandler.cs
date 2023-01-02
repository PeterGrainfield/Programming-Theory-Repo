using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUIHandler : MonoBehaviour
{
    public TextMeshProUGUI infoText;
    // Start is called before the first frame update
    void Start()
    {
        infoText.text = "Welcome, " + GameManager.Instance.GetUserName() + "!\n";
        infoText.text += "Click on the object to make it move. Multiple clicks will change its state.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScene()
    {
        GameManager.Instance.ResetScene();
    }

    public void Exit()
    {
        GameManager.Instance.Exit();
    }


}
