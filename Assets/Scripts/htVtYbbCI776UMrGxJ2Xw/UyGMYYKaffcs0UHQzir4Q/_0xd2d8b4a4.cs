using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xd2d8b4a4 : MonoBehaviour
{
    [HideInInspector]
    public bool IsGameEnd;
    public List<Button> HomeButtons = new();
    public void _0x9b4f25fd(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x59806df9();
            this._0xb080bc84();
        }
    }

    [HideInInspector]
    public int TimeLeft;
    private int _0xd65bed12 => this.CustomTimeInitial + _0x6da5105f._0x0a396108._0xdd3ff426 * 10;

    public List<Button> PauseButtons = new();
    private void _0xbcdfe33d()
    {
        this.TimerText.ForEach(_0xd5cfd3aa => _0xd5cfd3aa.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x7c9a7163._0x4f8a2d11(new byte[6] { 77, 77, 124, 26, 83, 83 }, 32)));
    }

    [HideInInspector]
    public int CurrentGameIndex;
    private static _0xd2d8b4a4 _0x32fee721;
    public List<TMP_Text> ScoreText = new();
    private void Awake()
    {
        _0x32fee721 = this.gameObject.GetComponent<_0xd2d8b4a4>();
    }

    public int CustomTimeInitial = 30;
    private void _0x59806df9()
    {
        if (_0x9d9ccbbe.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xd5cfd3aa => _0xd5cfd3aa.text = $"{this.ScoreCurrent}/{this._0x01b61225}");
        else
            this.ScoreText.ForEach(_0xd5cfd3aa => _0xd5cfd3aa.text = $"{this.ScoreCurrent}");
    }

    private void _0x913b4e14()
    {
        if (this.ScoreCurrent >= this._0x01b61225)
            this._0xeac4ba4e();
        else
            this._0x6915c2f7();
    }

    private int _0x01b61225 => this.CustomTargetScore + _0x6da5105f._0x0a396108._0xdd3ff426 * 10;

    [HideInInspector]
    public int ScoreCurrent;
    public List<TMP_Text> SubtitleText = new();
    public int CustomTargetScore = 10;
    public void _0x6915c2f7()
    {
        if (_0x9d9ccbbe.Instance.IsOnlyWinGameEndEnabled)
            this._0xeac4ba4e();
        if (!this.IsGameEnd)
        {
            this._0xeb15cd10();
            _0x6da5105f.IsAfterLevelComplete = false;
            _0x6da5105f.IsAfterLevelFailed = true;
            _0x04fe9665 _0x8adf0986 = _0xad9ed8e9.Instance._0xd483b1a8(_0x68897f3a._0x890b9fee.LOSE).GetComponent<_0x04fe9665>();
            if (_0x9d9ccbbe.Instance.IsCheckScoreEnabled)
                _0x8adf0986.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x01b61225}";
            else
                _0x8adf0986.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x8adf0986.ContentAdditionalText.text = $"{0}";
            _0x68897f3a._0xe9080e3c._0x12295ddc += 0;
            _0xad9ed8e9.Instance._0x8f7cb98f(_0x68897f3a._0x890b9fee.LOSE);
        }
    }

    public void _0xc83f44d8()
    {
        _0x6da5105f.Instance._0x1d3787ef(true);
        _0x6da5105f.Instance.LoadSceneByIndex(_0x68897f3a._0x35276d64.SCENE_0);
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xd65bed12;
        this.CurrentGameIndex = _0x6da5105f.Instance._0x3d1ed677;
        foreach (Button _0x882448f8 in this.HomeButtons)
            _0x882448f8.onClick.AddListener(() =>
            {
                this._0xc83f44d8();
            });
        foreach (Button _0x46092f2c in this.PauseButtons)
            _0x46092f2c.onClick.AddListener(() =>
            {
                _0x6da5105f.Instance._0x1d3787ef(false);
                _0xad9ed8e9.Instance._0x8f7cb98f(_0x68897f3a._0x890b9fee.PAUSE);
            });
        this._0x59806df9();
        this.LevelNumberText.ForEach(_0xd5cfd3aa => _0xd5cfd3aa.text = $"LVL {_0x6da5105f._0x0a396108._0xdd3ff426 + 1}");
        if (_0x9d9ccbbe.Instance.IsTimerEnabled)
        {
            this._0xbcdfe33d();
            this.StartCoroutine(this._0xc3a1764a());
        }
    }

    private void _0xb080bc84()
    {
        if (this.ScoreCurrent > _0x6da5105f._0x0a396108._0xdedacee0)
            _0x6da5105f._0x0a396108._0xdedacee0 = this.ScoreCurrent;
        if (_0x9d9ccbbe.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x01b61225)
                this._0xeac4ba4e();
    }

    public List<TMP_Text> LevelNumberText = new();
    private void _0xeb15cd10()
    {
        this.IsGameEnd = true;
        _0x6da5105f.IsAfterLevelComplete = true;
    }

    private int _0x8f33c89b => this.ScoreCurrent;

    public void _0xeac4ba4e()
    {
        if (!this.IsGameEnd)
        {
            this._0xeb15cd10();
            _0x6da5105f.IsAfterLevelComplete = true;
            _0x6da5105f.IsAfterLevelFailed = false;
            _0x04fe9665 _0xd3670f56 = _0xad9ed8e9.Instance._0xd483b1a8(_0x68897f3a._0x890b9fee.WIN).GetComponent<_0x04fe9665>();
            if (_0x9d9ccbbe.Instance.IsCheckScoreEnabled)
                _0xd3670f56.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x01b61225}";
            else
                _0xd3670f56.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x9d9ccbbe.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x68897f3a._0xe9080e3c._0x12295ddc)
                    _0x68897f3a._0xe9080e3c._0x12295ddc = this.ScoreCurrent;
                _0xd3670f56.ContentAdditionalText.text = $"{_0x68897f3a._0xe9080e3c._0x12295ddc}";
            }
            else
            {
                _0xd3670f56.ContentAdditionalText.text = $"{this._0x8f33c89b}";
                _0x68897f3a._0xe9080e3c._0x12295ddc += this._0x8f33c89b;
            }

            if (_0x9d9ccbbe.Instance.IsLevelIncrementOnWin)
                ++_0x6da5105f._0x0a396108._0xdd3ff426;
            _0xad9ed8e9.Instance._0x8f7cb98f(_0x68897f3a._0x890b9fee.WIN);
        }
    }

    private IEnumerator _0xc3a1764a()
    {
        this._0xbcdfe33d();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x6da5105f.Instance._0x3d1ed677 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x6da5105f.Instance._0x8f648b25)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xbcdfe33d();
            }
        }

        if (!this.IsGameEnd)
            this._0x6915c2f7();
    }

    public List<TMP_Text> TimerText = new();
}

internal static class _0x7c9a7163
{
    internal static string _0x4f8a2d11(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}