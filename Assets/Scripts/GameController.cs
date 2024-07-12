using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    bool isEndGame;

    public GameObject obstacle;

    //Tạo obstacle
    float m_swapTime;

    public float swapTime;

    //Tạo txt tính điểm cho nó
    int txtDiem = 0;
    public Text txtPoint;

    UIManager m_ui;
    // Start is called before the first frame update
    void Start()
    {
        m_swapTime = 0;
        m_ui=FindAnyObjectByType<UIManager>();
        isEndGame = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        m_swapTime -= Time.deltaTime;

        if (m_swapTime <= 0)
        {
            SwapObstacle();
            m_swapTime = swapTime;
        }
    }
    public void SwapObstacle()
    {
        Vector2 swapObst = new Vector2(0, Random.Range(-1.08f, 0.12f));

        if(obstacle)
        {
            Instantiate(obstacle, swapObst, Quaternion.identity);
        }    
    }   
    public void countPoint()
    {
        txtDiem++;
        txtPoint.text = "POINT: " + txtDiem.ToString();
    }    
    public void EndGame()
    {
        isEndGame = true;
        Time.timeScale = 0;
        m_ui.showGameOverPanel();
    }    
}
