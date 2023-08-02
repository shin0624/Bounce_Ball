using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
    public float step_timer = 0.0f;//����ð� ����
    private PlayerControl player = null;

    void Start()
    {
        this.player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
    }

    void Update()
    {
        this.step_timer += Time.deltaTime;//����ð� ���ذ���

        if (this.player.isPlayEnd())
        {
            Application.LoadLevel("TitleScene");
        }
    }

    public float getPlayTime()//-->��ũ���������� create_floor_block()���� ���
    {
        float time;
        time = this.step_timer;
        return (time);//ȣ���� ���� ����ð��� �˷���
    }
}