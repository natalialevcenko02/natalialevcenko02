using DG.Tweening;
using TMPro;
using UnityEngine;

/// <summary>
/// Drives the puzzle: builds the screen into the template's panel body, routes taps to
/// the grid, spends moves, and raises the three result cards by their SETTINGS index.
///
/// Nothing here can end a run on its own: there is no timer and no decreasing bar, and
/// moves are only spent by a deliberate swap. An untouched board therefore stays on
/// screen for as long as the capture window needs (rule C.5).
/// </summary>
public sealed class _0x49e8dfcc : MonoBehaviour
{
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _pipSprite;
    private void _0x6e27f639()
    {
        if (_0x6da5105f.Instance == null)
            return;
        if (_0xad9ed8e9.Instance != null)
            _0xad9ed8e9.Instance._0xad2ed0f3();
        _0x6da5105f.Instance._0xa5e6ed15();
    }

    private void _0xd560b23d(Vector3 _0x10d34a42)
    {
        if (this._0x93c13982 != _0xe25101ef.Idling || this._board == null)
            return;
        int _0xf71ae838;
        int _0x7399aaec;
        if (!this._board._0xb1541bc0(_0x10d34a42, out _0xf71ae838, out _0x7399aaec))
        {
            this._0xc73133e0();
            return;
        }

        if (!_0xdfdf0b34.IsMovable(this._0x4a02acb8._0x1b82a742(_0xf71ae838, _0x7399aaec)))
        {
            this._0xc73133e0();
            return;
        }

        if (!this._0x3ff24740)
        {
            this._0xec885c1d(_0xf71ae838, _0x7399aaec);
            return;
        }

        if (_0xf71ae838 == this._0xf95d84be && _0x7399aaec == this._0x29c7b670)
        {
            this._0xc73133e0();
            return;
        }

        if (this._0x4a02acb8._0x4bb02775(this._0xf95d84be, this._0x29c7b670, _0xf71ae838, _0x7399aaec))
        {
            this._0xecf2c56e(this._0xf95d84be, this._0x29c7b670, _0xf71ae838, _0x7399aaec);
            return;
        }

        // A tap on a stone that is not next to the picked one just moves the pick;
        // it is not a move and costs nothing.
        this._0xec885c1d(_0xf71ae838, _0x7399aaec);
    }

    [SerializeField]
    private _0x895cc5a3 _hud;
    [SerializeField]
    private Sprite _backIcon;
    private readonly _0xdfdf0b34 _0x4a02acb8 = new _0xdfdf0b34();
    private void Start()
    {
        if (_0xb01be533.Instance == null || this._hud == null || this._board == null)
            return;
        _0x9db1d5cc _0xa80f6a51 = _0xb01be533.Instance.Panels[_0x68897f3a._0x215fc08c.DEFAULT];
        if (_0xa80f6a51 == null || _0xa80f6a51.Content == null)
            return;
        // Rule H, option 2: the template's own top bar and score chrome live in this
        // body. Switching every child off leaves ONE consistent control set on screen
        // instead of template buttons sitting next to generated ones.
        Transform _0xc8d339bd = _0xa80f6a51.Content.transform;
        _0x0816affa.ClearChildren(_0xc8d339bd);
        this._hud._0x16475912(_0xc8d339bd, this._0xaddd5be0, this._font, this._plateSprite, this._backIcon, this._pauseIcon, this._pipSprite, () => this._0x91f51415(), () => this._0x0a5d2f1e(), () => this._0x3df27dce(), (Vector3 _0xc76c4233) => this._0xd560b23d(_0xc76c4233));
        if (this._pops != null)
            this._pops._0x50179c29(this._font, this._plateSprite, this._closeIcon, this._starFull, this._starEmpty, this._gemMark, () => this._0x454266c1(), () => this._0x6e27f639(), () => this._0x91f51415(), () => this._0xd595c462(), () => this._0x6e27f639());
        this._0x76678eb4();
    }

    [SerializeField]
    private Sprite _gemMark;
    private int _0x21c3f5be;
    private readonly _0x0f439b88 _0x9c667f19 = new _0x0f439b88();
    private _0xe25101ef _0x93c13982 = _0xe25101ef.Building;
    [SerializeField]
    private _0x733b3602 _beams;
    private void _0x2574984f()
    {
        if (this == null || this._0x93c13982 != _0xe25101ef.Sliding)
            return;
        if (this._beams != null)
            this._beams._0x220de5e1(this._0x4a02acb8, this._0xea771973, true);
        this._0x93c13982 = _0xe25101ef.Idling;
    }

    /// <summary>Optional haptic acknowledgement; never allowed to break the run.</summary>
    private void _0xf421053f()
    {
        if (!this._0xf17f796b._0x91d3a6e2)
            return;
        try
        {
            Handheld.Vibrate();
        }
        catch (System.Exception)
        {
        // some devices refuse the vibrator; a missing buzz is not a failure
        }
    }

    [SerializeField]
    private Sprite _closeIcon;
    private void _0xbfbee531(bool _0xf661d6d7, int _0xf8bbd8f4)
    {
        this._0x93c13982 = _0xe25101ef.Settled;
        this._hud._0x986e10df(false);
        if (this._beams != null)
            this._beams._0x6d92b7cd(0.4f);
        this._board._0xe2290f15(0.4f);
        int _0x22dcb41b = this._0x4a02acb8._0xf9ecab52;
        DOVirtual.DelayedCall(LoseHold, () => this._0x8603d91a(_0xf661d6d7, _0xf8bbd8f4, _0x22dcb41b)).SetId(this);
    }

    [SerializeField]
    private _0x9390206a _board;
    private int _0x8f7ecaff;
    private void _0xec885c1d(int _0xc2018293, int _0x805d2300)
    {
        this._0x3ff24740 = true;
        this._0xf95d84be = _0xc2018293;
        this._0x29c7b670 = _0x805d2300;
        this._board._0xcab2706b(_0xc2018293, _0x805d2300);
    }

    private readonly _0x7ae38e03 _0xf17f796b = new _0x7ae38e03();
    // ── navigation ──────────────────────────────────────────────────────────
    private void _0x0a5d2f1e()
    {
        if (this._0x93c13982 == _0xe25101ef.Settled || this._pops == null)
            return;
        this._0x93c13982 = _0xe25101ef.Held;
        this._pops._0xc22d87d0(this._0xaff9138f, this._0x21c3f5be);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
    }

    private void _0x454266c1()
    {
        int _0x7c0e4644 = this._0xaff9138f + 1;
        if (_0x7c0e4644 >= _0x0f439b88._0x65132f1c)
            _0x7c0e4644 = 0;
        this._0xf17f796b._0x36c52805 = _0x7c0e4644;
        this._0x6e27f639();
    }

    private const float SwapSeconds = 0.22f;
    private const float LoseHold = 0.6f;
    private int _0xf95d84be;
    private readonly _0xfa8fa6c6 _0xea771973 = new _0xfa8fa6c6();
    private void _0xc73133e0()
    {
        this._0x3ff24740 = false;
        this._board._0x2362a394();
    }

    private void _0x59255961(int _0xd1d7601f)
    {
        this._0x8f7ecaff++;
        this._hud._0xa7fe694c(this._0x8f7ecaff);
        this._board._0xd375a74d();
        this._hud._0x31742195(_0x0149bb5f._0x01083468(new byte[7] { 161, 160, 187, 207, 182, 170, 187 }, 239), _0x61e0b808.RoseLight);
        this._0xf421053f();
        if (this._0x8f7ecaff >= StrikeLimit)
        {
            this._0xbfbee531(false, _0xd1d7601f);
            return;
        }

        if (this._0x21c3f5be <= 0)
        {
            this._0xbfbee531(true, _0xd1d7601f);
            return;
        }

        this._0x93c13982 = _0xe25101ef.Idling;
    }

    [SerializeField]
    private _0xa1733a21 _pops;
    private void Awake()
    {
        this._0xaddd5be0 = Camera.main;
        if (this._board != null)
            this._board._0xaf3358eb(this._0xaddd5be0);
    }

    private bool _0x3ff24740;
    // ── the check ───────────────────────────────────────────────────────────
    private void _0x3df27dce()
    {
        if (this._0x93c13982 != _0xe25101ef.Idling)
            return;
        this._0x93c13982 = _0xe25101ef.Verifying;
        this._0xc73133e0();
        this._board._0xa972463f(this._0x4a02acb8);
        int _0x77a7af79 = _0xfa8fa6c6.LitCount(this._0x4a02acb8, this._0xea771973);
        if (_0x77a7af79 >= this._0x4a02acb8._0xf9ecab52)
            this._0x35adcfa6();
        else
            this._0x59255961(_0x77a7af79);
    }

    private int _0x29c7b670;
    private enum _0xe25101ef
    {
        Building,
        Idling,
        Sliding,
        Verifying,
        Held,
        Settled,
    }

    private int _0xaff9138f;
    // ── a run ───────────────────────────────────────────────────────────────
    private void _0x76678eb4()
    {
        this._0xaff9138f = this._0xf17f796b._0x36c52805;
        int _0x438aba34 = this._0xf17f796b._0x6906afa7(this._0xaff9138f);
        this._0xf17f796b._0xb7bd9fb0(this._0xaff9138f);
        this._0x9c667f19._0xd41f4e53(this._0x4a02acb8, this._0xaff9138f, _0x438aba34);
        this._0x21c3f5be = this._0x9c667f19._0xf3c2d0ba;
        this._0xd57c5387 = 0;
        this._0x8f7ecaff = 0;
        this._0x3ff24740 = false;
        this._board._0x2656d0a0(this._0x4a02acb8);
        if (this._beams != null)
            this._beams._0x220de5e1(this._0x4a02acb8, this._0xea771973, false);
        this._hud._0xc513d843(this._0xaff9138f);
        this._hud._0x59bd640a(this._0x21c3f5be);
        this._hud._0xa7fe694c(0);
        this._hud._0x986e10df(true);
        this._0x93c13982 = _0xe25101ef.Idling;
    }

    private void _0x8603d91a(bool _0x0af9ede2, int _0xe027dfac, int _0xa0441004)
    {
        if (this == null || this._pops == null)
            return;
        this._pops._0x5754b976(_0x0af9ede2, _0xe027dfac, _0xa0441004);
    }

    private Camera _0xaddd5be0;
    [SerializeField]
    private Sprite _plateSprite;
    private void _0x88ad80ee(int _0xe337b63b, int _0x4f92402e, int _0x10c18fe5)
    {
        if (this == null || this._pops == null)
            return;
        this._pops._0xccf001f0(_0xe337b63b, _0x4f92402e, _0x10c18fe5);
    }

    private void _0x91f51415()
    {
        if (_0x6da5105f.Instance == null)
            return;
        if (_0xad9ed8e9.Instance != null)
            _0xad9ed8e9.Instance._0xad2ed0f3();
        _0x6da5105f.Instance.LoadSceneByIndex(_0x68897f3a._0x35276d64.SCENE_0);
    }

    private int _0xd57c5387;
    private void _0xecf2c56e(int _0xfe741bad, int _0x3fa4f933, int _0x52672943, int _0xf9d5c01e)
    {
        if (this._0x21c3f5be <= 0)
        {
            this._hud._0x31742195(_0x0149bb5f._0x01083468(new byte[13] { 63, 62, 81, 60, 62, 39, 52, 34, 81, 61, 52, 55, 37 }, 113), _0x61e0b808.RoseLight);
            this._0xc73133e0();
            return;
        }

        _0x38484061 _0x318d558a = this._board._0xe3b95147(_0xfe741bad, _0x3fa4f933);
        _0x38484061 _0x7d7d23bd = this._board._0xe3b95147(_0x52672943, _0xf9d5c01e);
        this._0x4a02acb8._0x87e02085(_0xfe741bad, _0x3fa4f933, _0x52672943, _0xf9d5c01e);
        this._board._0x16b501ef(_0x318d558a, _0x7d7d23bd, SwapSeconds);
        this._0xc73133e0();
        this._0x21c3f5be--;
        this._0xd57c5387++;
        this._hud._0x59bd640a(this._0x21c3f5be);
        this._0x93c13982 = _0xe25101ef.Sliding;
        DOVirtual.DelayedCall(SwapSeconds + 0.02f, () => this._0x2574984f()).SetId(this);
    }

    [SerializeField]
    private Sprite _starFull;
    [SerializeField]
    private Sprite _starEmpty;
    private void _0x35adcfa6()
    {
        this._0x93c13982 = _0xe25101ef.Settled;
        this._hud._0x986e10df(false);
        this._board._0x673e80ce(this._0x4a02acb8, this._0xea771973);
        int _0x89c036e5 = _0x7ae38e03.StarsEarned(this._0xd57c5387, this._0x9c667f19._0x99d70463);
        int _0x72510fe3 = _0x7ae38e03.LumensFor(_0x89c036e5, this._0xaff9138f);
        this._0xf17f796b._0x034e4d81(this._0xaff9138f, _0x89c036e5, _0x72510fe3);
        int _0xb4052eee = this._0xaff9138f;
        DOVirtual.DelayedCall(WinHold, () => this._0x88ad80ee(_0xb4052eee, _0x89c036e5, _0x72510fe3)).SetId(this);
    }

    private void _0xd595c462()
    {
        if (this._pops != null)
            this._pops._0x60ddb1ab();
        if (this._0x93c13982 == _0xe25101ef.Held)
            this._0x93c13982 = _0xe25101ef.Idling;
    }

    private const int StrikeLimit = 3;
    [SerializeField]
    private Sprite _pauseIcon;
    private const float WinHold = 0.95f;
}

internal static class _0x0149bb5f
{
    internal static string _0x01083468(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}