using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vehicle : MonoBehaviour
{
    protected private float speed = 0.1f;
    private GameObject target;
    private TextMeshProUGUI infoText;
    // Move State
    // 0 : Stop
    // 1 : Forward
    // 2 : Backward
    // 3 : Action
    [SerializeField]
    private int moveState = 0;
    public int MoveState { get => moveState; set => moveState = value; }
    protected string[] moveStateName = {"Stop","Move Forward","Move Backward","Action"};



    // Start is called before the first frame update
    void Start()
    {
        SetComponent();
    }

    // Update is called once per frame
    void Update()
    {
        moveVehicle();
    }

    protected void moveVehicle()
    {
        switch (moveState)
        {
            case 0:
                break;
            case 1:
                MoveForward();
                break;
            case 2:
                MoveBackward();
                break;
            default:
                break;
        }
    }


    void OnMouseDown()
    {
        moveState = (moveState+1)%4;
        DisplayInfo(GetType().Name, MoveState);
        if (moveState == 3)
        {
            Action();
        }
    }

    void MoveForward()
    {
        transform.Translate(getDirectionToTarget() * speed * Time.deltaTime);
    }

    void MoveBackward()
    {
        transform.Translate(getDirectionToTarget() * -speed * Time.deltaTime);
    }

    protected virtual void Action() { }
  
    protected virtual Vector3 getDirectionToTarget()
    {
        Vector3 direction = target.transform.position - transform.position;
        direction = new Vector3(direction.x, 0, direction.z);
        return direction;
    }

    protected void DisplayInfo(string className, int moveState)
    {
        infoText.text = "";
        infoText.text = "Class:" + className + "\n";
        infoText.text += "State: " + moveState + " : " + moveStateName[moveState];
    }

    protected void SetComponent()
    {
        target = GameObject.Find("Main Camera");
        infoText = GameObject.Find("Info Text").GetComponent<TextMeshProUGUI>();
    }

    public GameObject getTarget()
    {
        return target;
    }
}
