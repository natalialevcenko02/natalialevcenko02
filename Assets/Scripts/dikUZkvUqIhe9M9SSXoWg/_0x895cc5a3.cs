using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The in-game HUD, built from scratch into the template's DefaultPanel body. The
/// template's own top bar is switched off before this runs, so the panel carries one
/// consistent set of controls rather than template chrome plus generated chrome.
///
/// Rule C.25: the MOVES readout and the strike pips never share an x band. MOVES is
/// centred on x=330 (box 440 wide, so it ends at 550) and the pip gutter starts at
/// 870 - a 320 px gap.
/// </summary>
public sealed class _0x895cc5a3 : MonoBehaviour
{
    private TextMeshProUGUI _0x29bc6234;
    public void _0x31742195(string _0x917180eb, Color _0xca0731eb)
    {
        if (this._0x29bc6234 == null)
            return;
        this._0x29bc6234.text = _0x917180eb;
        this._0x29bc6234.color = _0xca0731eb;
        this._0x29bc6234.alpha = 1f;
        TextMeshProUGUI _0xdd111070 = this._0x29bc6234;
        DOTween.Kill(_0xdd111070);
        DOTween.To(() => _0xdd111070.alpha, (float _0x90f7f453) => _0xdd111070.alpha = _0x90f7f453, 0f, 0.5f).SetDelay(1.2f).SetId(_0xdd111070);
    }

    private Button _0x6dcb5b89;
    /// <summary>
    /// Builds the HUD. The tap catcher is created FIRST so every control added after it
    /// is a later sibling and therefore wins the raycast over the board.
    /// </summary>
    public _0xacb7db07 _0x16475912(Transform _0x318ae389, Camera _0x38870829, TMP_FontAsset _0xe946a9fb, Sprite _0xb668c68a, Sprite _0x97b9611d, Sprite _0xa53d6ce2, Sprite _0xe436d414, Action _0xc6806a76, Action _0x988372c5, Action _0x1f5f0ad9, Action<Vector3> _0x3e41cb5d)
    {
        RectTransform _0xf1792b1a = _0x0816affa.Sheet(_0x318ae389, _0x36b0a443._0x552a130b(new byte[12] { 67, 110, 96, 115, 101, 85, 96, 113, 64, 115, 100, 96 }, 1));
        Image _0x86f7d355 = _0xf1792b1a.gameObject.AddComponent<Image>();
        _0x86f7d355.color = new Color(1f, 1f, 1f, 0.004f);
        _0x86f7d355.raycastTarget = true;
        _0xacb7db07 _0x28f99cdc = _0xf1792b1a.gameObject.AddComponent<_0xacb7db07>();
        _0x28f99cdc._0xb8308d2c(_0x38870829, _0x3e41cb5d);
        // ── top bar ────────────────────────────────────────────────────────
        _0x0816affa.Plate(_0x318ae389, _0x36b0a443._0x552a130b(new byte[6] { 49, 10, 21, 39, 4, 23 }, 101), new Vector2(0.5f, 0.952f), new Vector2(1160f, 152f), _0x61e0b808.WithAlpha(_0x61e0b808.InkDeep, 0.72f), _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.55f), _0xb668c68a, 1.6f);
        _0x0816affa.IconButton(_0x318ae389, _0x36b0a443._0x552a130b(new byte[10] { 148, 183, 181, 189, 148, 163, 162, 162, 185, 184 }, 214), new Vector2(0.108f, 0.952f), new Vector2(124f, 124f), _0x97b9611d, _0x61e0b808.Cream, () => _0xc6806a76());
        this._0xb699f231 = _0x0816affa.Caption(_0x318ae389, _0x36b0a443._0x552a130b(new byte[11] { 169, 153, 146, 159, 151, 159, 182, 155, 152, 159, 150 }, 250), new Vector2(0.5f, 0.952f), new Vector2(520f, 76f), _0x36b0a443._0x552a130b(new byte[9] { 115, 99, 104, 101, 109, 101, 0, 16, 17 }, 32), 40f, _0x61e0b808.Cream, _0xe946a9fb);
        _0x0816affa.IconButton(_0x318ae389, _0x36b0a443._0x552a130b(new byte[11] { 88, 105, 125, 123, 109, 74, 125, 124, 124, 103, 102 }, 8), new Vector2(0.892f, 0.952f), new Vector2(124f, 124f), _0xa53d6ce2, _0x61e0b808.Cream, () => _0x988372c5());
        // ── status row: text column on the left, pip gutter on the right ───
        this._0xb165749e = _0x0816affa.Caption(_0x318ae389, _0x36b0a443._0x552a130b(new byte[10] { 239, 205, 212, 199, 209, 238, 195, 192, 199, 206 }, 162), new Vector2(0.2657f, 0.879f), new Vector2(440f, 76f), _0x36b0a443._0x552a130b(new byte[7] { 170, 168, 177, 162, 180, 199, 212 }, 231), 46f, _0x61e0b808.Gold, _0xe946a9fb);
        this._0xb165749e.alignment = TextAlignmentOptions.Left;
        for (int _0x19630f37 = 0; _0x19630f37 < 3; _0x19630f37++)
        {
            float _0xe3d04ccf = (894f + _0x19630f37 * 56f) / _0x61e0b808.RefWidth;
            RectTransform _0x7503504a = _0x0816affa.Node(_0x318ae389, _0x36b0a443._0x552a130b(new byte[9] { 19, 52, 50, 41, 43, 37, 16, 41, 48 }, 64) + _0x19630f37.ToString(), new Vector2(_0xe3d04ccf, 0.879f), new Vector2(48f, 48f));
            Image _0x189d65fc = _0x0816affa.Picture(_0x7503504a, _0x61e0b808.Teal, _0xe436d414, false, 1f);
            this._0x01ab65c1.Add(_0x189d65fc);
        }

        // ── control hint: mandatory, and it never disappears (rule C.6) ────
        this._0xd34e81d7 = _0x0816affa.Caption(_0x318ae389, _0x36b0a443._0x552a130b(new byte[11] { 126, 82, 83, 73, 79, 82, 81, 117, 84, 83, 73 }, 61), new Vector2(0.5f, 0.176f), new Vector2(1020f, 118f), _0x36b0a443._0x552a130b(new byte[40] { 173, 184, 169, 217, 173, 174, 182, 217, 170, 173, 182, 183, 188, 170, 217, 170, 176, 189, 188, 217, 187, 160, 217, 170, 176, 189, 188, 243, 173, 182, 217, 170, 174, 184, 169, 217, 173, 177, 188, 180 }, 249), 32f, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.9f), _0xe946a9fb);
        // ── verdict floater, used by a failed check ────────────────────────
        this._0x29bc6234 = _0x0816affa.Caption(_0x318ae389, _0x36b0a443._0x552a130b(new byte[12] { 7, 52, 35, 53, 56, 50, 37, 29, 48, 51, 52, 61 }, 81), new Vector2(0.5f, 0.243f), new Vector2(520f, 72f), string.Empty, 40f, _0x61e0b808.RoseLight, _0xe946a9fb);
        // ── primary action ─────────────────────────────────────────────────
        this._0x6dcb5b89 = _0x0816affa.ActionButton(_0x318ae389, _0x36b0a443._0x552a130b(new byte[12] { 48, 19, 31, 23, 53, 18, 62, 9, 8, 8, 19, 18 }, 124), new Vector2(0.5f, 0.082f), new Vector2(640f, 160f), _0x61e0b808.Teal, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.85f), _0x61e0b808.Cream, _0x36b0a443._0x552a130b(new byte[7] { 221, 222, 210, 218, 177, 216, 223 }, 145), 54f, _0xb668c68a, 1.9f, _0xe946a9fb, () => _0x1f5f0ad9());
        this._0xe6fda2d3();
        return _0x28f99cdc;
    }

    public Button _0x43cb1d28
    {
        get
        {
            return this._0x6dcb5b89;
        }
    }

    public void _0x986e10df(bool _0x23bdbfdc)
    {
        if (this._0x6dcb5b89 != null)
            this._0x6dcb5b89.interactable = _0x23bdbfdc;
    }

    private TextMeshProUGUI _0xb699f231;
    private const float HintHoldSeconds = 12f;
    private TextMeshProUGUI _0xd34e81d7;
    public void _0xc513d843(int _0xe144ffbf)
    {
        if (this._0xb699f231 != null)
            this._0xb699f231.text = _0x36b0a443._0x552a130b(new byte[7] { 130, 146, 153, 148, 156, 148, 241 }, 209) + (_0xe144ffbf + 1).ToString(_0x36b0a443._0x552a130b(new byte[2] { 223, 223 }, 239));
    }

    /// <summary>
    /// The hint dims after a while but never leaves: review reads this build from
    /// screenshots, and a control explanation that has faded out is not an explanation.
    /// </summary>
    private void _0xe6fda2d3()
    {
        if (this._0xd34e81d7 == null)
            return;
        TextMeshProUGUI _0x4021af52 = this._0xd34e81d7;
        DOTween.To(() => _0x4021af52.alpha, (float _0x90f7f453) => _0x4021af52.alpha = _0x90f7f453, 0.35f, 0.8f).SetDelay(HintHoldSeconds);
    }

    /// <summary>A burned pip flips from teal to rose and punches, so a failed check reads at a glance.</summary>
    public void _0xa7fe694c(int _0x74363b02)
    {
        for (int _0xd1d26ee8 = 0; _0xd1d26ee8 < this._0x01ab65c1.Count; _0xd1d26ee8++)
        {
            Image _0x0c1ecb4b = this._0x01ab65c1[_0xd1d26ee8];
            if (_0x0c1ecb4b == null)
                continue;
            bool _0x9ce9dedd = _0xd1d26ee8 < _0x74363b02;
            Color _0xb9454f8c = _0x9ce9dedd ? _0x61e0b808.Rose : _0x61e0b808.Teal;
            if (_0x0c1ecb4b.color != _0xb9454f8c)
            {
                Transform _0x554ed2c7 = _0x0c1ecb4b.transform;
                DOTween.Kill(_0x554ed2c7);
                _0x554ed2c7.localScale = Vector3.one;
                _0x554ed2c7.DOPunchScale(Vector3.one * 0.3f, 0.26f, 1, 0.5f);
            }

            _0x0c1ecb4b.color = _0xb9454f8c;
        }
    }

    private TextMeshProUGUI _0xb165749e;
    private readonly List<Image> _0x01ab65c1 = new List<Image>(3);
    public void _0x59bd640a(int _0xd6b10db1)
    {
        if (this._0xb165749e == null)
            return;
        this._0xb165749e.text = _0x36b0a443._0x552a130b(new byte[6] { 37, 39, 62, 45, 59, 72 }, 104) + Mathf.Max(0, _0xd6b10db1).ToString();
        Transform _0xebe943a9 = this._0xb165749e.transform;
        DOTween.Kill(_0xebe943a9);
        _0xebe943a9.localScale = Vector3.one;
        _0xebe943a9.DOPunchScale(Vector3.one * 0.12f, 0.24f, 1, 0.5f);
    }
}

internal static class _0x36b0a443
{
    internal static string _0x552a130b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}