using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class GameManagerData
{
    private static GameManagerData instance;
    public static GameManagerData Instance
    {
        get
        {
            if (instance != null)
                instance = new GameManagerData();
            return instance;
        }
    }

    private GameManagerData()
    {
    }



    [SerializeField]
    Text player1Text;
    public Text Player1Text
    {
        get { return player1Text; }
        set { player1Text = value; }
    }


    [SerializeField]
    string player1String;
    public string Player1String
    {
        get { return player1String; }
        set { player1String = value; }
    }


    [SerializeField]
    int player1Score;
    public int Player1Score
    {
        get { return player1Score; }
        set { player1Score = value; }
    }





    [SerializeField]
    Text player2Text;
    public Text Player2Text
    {
        get { return player2Text; }
        set { player2Text = value; }
    }


    [SerializeField]
    string player2String;
    public string Player2String
    {
        get { return player2String; }
        set { player2String = value; }
    }


    [SerializeField]
    int player2Score;
    public int Player2Score
    {
        get { return player2Score; }
        set { player2Score = value; }
    }

    [SerializeField]
    bool isPaused = true;

    public bool IsPaused
    {
        get { return isPaused; }
        set { isPaused = value; }
    }

    [SerializeField]
    KeyCode menuKey;
    public KeyCode MenuKey
    {
        get { return menuKey; }
        set { menuKey = value; }
    }

    [SerializeField]
    GameObject menuCanvas;
    public GameObject MenuCanvas
    {
        get { return menuCanvas; }
        set { menuCanvas = value; }
    }
}