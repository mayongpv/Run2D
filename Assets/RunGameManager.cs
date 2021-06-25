using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class RunGameManager : MonoBehaviour
{
    public static RunGameManager instance;

    private void Awake()
    {
        instance = this;
    }

    internal void EndStage()
    {
        gameStateType = GameStateType.End;
        Player.instance.OnEndStage();
        timeText.text = "Clear";

    }

    TextMeshProUGUI timeText;
    TextMeshProUGUI pointText;
    public int waitForSecond = 3;


    [SerializeField] int point; //int 는 프라이빗이지만, 시리얼라이즈필드를 하면 인스펙터창에서 볼 수 있다.
    internal void AddCoin(int addPoint)
    {
        point += addPoint;
        pointText.text = point.ToString();
    }

    IEnumerator Start()
    {
        //캐릭터랑 카메라랑 멈춰야 한다.

        gameStateType = GameStateType.Ready;
        //3, 2, 1, Start 표시
        pointText = transform.Find("PointText").GetComponent<TextMeshProUGUI>();
        
        timeText = transform.Find("TimeText").GetComponent<TextMeshProUGUI>();
        for (int i = waitForSecond; i > 0; i--)
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

    internal static bool IsPlaying()
    {
        return instance.gameStateType == GameStateType.Playing;
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
