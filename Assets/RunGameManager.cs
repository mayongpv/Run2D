using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RunGameManager : MonoBehaviour
{
    TextMeshProUGUI timeText;
    public int waitForSecond = 3;
    IEnumerator Start()
    {
        //캐릭터랑 카메라랑 멈춰야 한다.

        gameStateType = GameStateType.Ready;
        //3, 2, 1, Start 표시
        transform.Find("TimeText").GetComponent<TextMeshProUGUI>();
        for (int i = waitForSecond; i < 0; i--)
        {
            timeText.text = i.ToString();
            yield return new WaitForSeconds(1);
        }
        timeText.text = "Start!";
        gameStateType = GameStateType.Playing;
        //캐릭터랑 카메라랑 움직여야 한다.

        yield return new WaitForSeconds(0.5f);
        timeText.text = "";


    }
    public GameStateType gameStateType = GameStateType.NotInit;
    public enum GameStateType
    { 
        NotInit, //아직 초기화되지 않았다는 뜻
    Ready,
    Playing,
    End,

    }
    //게임이 시작전인가?
    //게임중인지?
    //끝났는지?


    void Update()
    {
        
    }
}
