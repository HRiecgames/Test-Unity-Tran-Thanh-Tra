using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMoves : LevelCondition
{
    private int m_moves;

    private BoardController m_board;

    private int initMoves;

    public override void Setup(float value, Text txt, BoardController board)
    {
        base.Setup(value, txt);

        m_moves = (int)value;
        initMoves = m_moves;

        m_board = board;

        m_board.OnMoveEvent += OnMove;

        UpdateText();
    }

    private void OnMove()
    {
        if (m_conditionCompleted) return;

        m_moves--;

        UpdateText();

        if(m_moves <= 0)
        {
            OnConditionComplete();
        }
    }

    protected override void UpdateText()
    {
        m_txt.text = string.Format("MOVES:\n{0}", m_moves);
    }

    public override void Restart()
    {
        m_moves = initMoves;
        UpdateText();
    }

    protected override void OnDestroy()
    {
        if (m_board != null) m_board.OnMoveEvent -= OnMove;

        base.OnDestroy();
    }
}
