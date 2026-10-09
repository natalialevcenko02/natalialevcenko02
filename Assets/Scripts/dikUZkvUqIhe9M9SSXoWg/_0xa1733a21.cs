using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Owns the three result cards. Each pop is addressed by its SETTINGS index - never by
/// name - and is dressed ENTIRELY by this class: the template body is cleared and a
/// themed card is built in its place, so none of the template's own stand-in wording
/// can reach a screen (rule C.15).
///
/// A pop whose Content ships inactive is woken BEFORE anything is built into it: a
/// TMP label added to a dead hierarchy never runs Awake, and reading its material then
/// throws and unwinds the caller before the pop is ever raised.
/// </summary>
public sealed class _0xa1733a21 : MonoBehaviour
{
    /// <summary>
    /// The pause card releases itself after a few seconds. A capture run whose RESUME
    /// tap misses the button would otherwise park the whole session on this card.
    /// </summary>
    public void _0xc22d87d0(int _0x40935be9, int _0x08f06d8d)
    {
        if (_0xad9ed8e9.Instance == null)
            return;
        if (this._0xd4705950 != null)
            this._0xd4705950.text = _0x72f5a2b2._0x73cae641(new byte[7] { 61, 45, 38, 43, 35, 43, 78 }, 110) + (_0x40935be9 + 1).ToString(_0x72f5a2b2._0x73cae641(new byte[2] { 25, 25 }, 41));
        if (this._0x2b2db75e != null)
            this._0x2b2db75e.text = _0x72f5a2b2._0x73cae641(new byte[11] { 87, 85, 76, 95, 73, 58, 86, 95, 92, 78, 58 }, 26) + Mathf.Max(0, _0x08f06d8d).ToString();
        _0xad9ed8e9.Instance._0x8f7cb98f(_0x68897f3a._0x890b9fee.PAUSE);
        DOVirtual.DelayedCall(AutoReleaseSeconds, () => this._0xab25b413()).SetId(this);
    }

    private Sprite _0x81c29a33;
    private readonly List<Image> _0x830960d5 = new List<Image>(3);
    private void _0x212836b4(_0x04fe9665 _0x426d788b, Action _0xc4f3ca8b, Action _0x5e0bd03d)
    {
        RectTransform _0x8dfa7919 = this._0x356e45dd(_0x426d788b, _0x61e0b808.Gold);
        if (_0x8dfa7919 == null)
            return;
        this._0x9c6d8c53 = _0x0816affa.Caption(_0x8dfa7919, _0x72f5a2b2._0x73cae641(new byte[9] { 86, 104, 111, 73, 100, 96, 101, 100, 115 }, 1), new Vector2(0.5f, 0.88f), new Vector2(880f, 110f), _0x72f5a2b2._0x73cae641(new byte[14] { 238, 227, 227, 143, 233, 238, 236, 234, 251, 252, 143, 227, 230, 251 }, 175), 56f, _0x61e0b808.Gold, this._0x8cdb2728);
        for (int _0xee1776bc = 0; _0xee1776bc < 3; _0xee1776bc++)
        {
            RectTransform _0xc131f811 = _0x0816affa.Node(_0x8dfa7919, _0x72f5a2b2._0x73cae641(new byte[7] { 142, 176, 183, 138, 173, 184, 171 }, 217) + _0xee1776bc.ToString(), new Vector2(0.5f + (_0xee1776bc - 1) * 0.108f, 0.73f), new Vector2(92f, 92f));
            Image _0x30effafd = _0x0816affa.Picture(_0xc131f811, _0x61e0b808.Gold, this._0x74db2158, false, 1f);
            this._0x830960d5.Add(_0x30effafd);
        }

        this._0xfbcb4a86 = _0x0816affa.Caption(_0x8dfa7919, _0x72f5a2b2._0x73cae641(new byte[7] { 37, 27, 28, 48, 29, 22, 11 }, 114), new Vector2(0.5f, 0.58f), new Vector2(880f, 84f), _0x72f5a2b2._0x73cae641(new byte[17] { 16, 0, 11, 6, 14, 6, 99, 115, 114, 99, 0, 15, 6, 2, 17, 6, 7 }, 67), 40f, _0x61e0b808.Cream, this._0x8cdb2728);
        this._0x6b4d1245 = _0x0816affa.Caption(_0x8dfa7919, _0x72f5a2b2._0x73cae641(new byte[8] { 253, 195, 196, 239, 210, 222, 216, 203 }, 170), new Vector2(0.5f, 0.48f), new Vector2(880f, 76f), _0x72f5a2b2._0x73cae641(new byte[11] { 9, 16, 8, 0, 11, 22, 101, 110, 116, 125, 117 }, 69), 36f, _0x61e0b808.Teal, this._0x8cdb2728);
        _0x0816affa.ActionButton(_0x8dfa7919, _0x72f5a2b2._0x73cae641(new byte[7] { 216, 230, 225, 193, 234, 247, 251 }, 143), new Vector2(0.5f, 0.28f), new Vector2(720f, 150f), _0x61e0b808.Gold, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.85f), _0x61e0b808.Cream, _0x72f5a2b2._0x73cae641(new byte[11] { 136, 131, 158, 146, 230, 149, 133, 142, 131, 139, 131 }, 198), 48f, this._0x7041854e, 1.9f, this._0x8cdb2728, () => _0xc4f3ca8b());
        _0x0816affa.ActionButton(_0x8dfa7919, _0x72f5a2b2._0x73cae641(new byte[7] { 120, 70, 65, 98, 74, 65, 90 }, 47), new Vector2(0.5f, 0.12f), new Vector2(560f, 124f), _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.85f), _0x61e0b808.WithAlpha(_0x61e0b808.Teal, 0.8f), _0x61e0b808.Cream, _0x72f5a2b2._0x73cae641(new byte[4] { 95, 87, 92, 71 }, 18), 42f, this._0x7041854e, 1.9f, this._0x8cdb2728, () => _0x5e0bd03d());
    }

    private bool _0x09d67e0b;
    private TextMeshProUGUI _0xfbcb4a86;
    private TextMeshProUGUI _0x9c6d8c53;
    private Sprite _0x7041854e;
    private TMP_FontAsset _0x8cdb2728;
    public void _0x60ddb1ab()
    {
        DOTween.Kill(this);
    }

    private void _0xab25b413()
    {
        if (_0xad9ed8e9.Instance != null)
            _0xad9ed8e9.Instance._0xad2ed0f3();
        if (this._0x03751b21 != null)
            this._0x03751b21();
    }

    private TextMeshProUGUI _0x2b2db75e;
    private TextMeshProUGUI _0x63a77c43;
    // ── raising ─────────────────────────────────────────────────────────────
    public void _0xccf001f0(int _0x53117e61, int _0x702037ea, int _0xa6597173)
    {
        if (_0xad9ed8e9.Instance == null)
            return;
        if (this._0x9c6d8c53 != null)
            this._0x9c6d8c53.text = _0x72f5a2b2._0x73cae641(new byte[14] { 101, 104, 104, 4, 98, 101, 103, 97, 112, 119, 4, 104, 109, 112 }, 36);
        if (this._0xfbcb4a86 != null)
            this._0xfbcb4a86.text = _0x72f5a2b2._0x73cae641(new byte[7] { 119, 103, 108, 97, 105, 97, 4 }, 36) + (_0x53117e61 + 1).ToString(_0x72f5a2b2._0x73cae641(new byte[2] { 244, 244 }, 196)) + _0x72f5a2b2._0x73cae641(new byte[8] { 126, 29, 18, 27, 31, 12, 27, 26 }, 94);
        if (this._0x6b4d1245 != null)
            this._0x6b4d1245.text = _0x72f5a2b2._0x73cae641(new byte[8] { 142, 151, 143, 135, 140, 145, 226, 233 }, 194) + _0xa6597173.ToString();
        for (int _0x6ec64b93 = 0; _0x6ec64b93 < this._0x830960d5.Count; _0x6ec64b93++)
        {
            Image _0x466dc410 = this._0x830960d5[_0x6ec64b93];
            if (_0x466dc410 == null)
                continue;
            bool _0x01e0217d = _0x6ec64b93 < _0x702037ea;
            _0x466dc410.sprite = _0x01e0217d ? this._0x81c29a33 : this._0x74db2158;
            _0x466dc410.preserveAspect = true;
            _0x466dc410.color = _0x01e0217d ? _0x61e0b808.Gold : _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.3f);
            Transform _0x8df45f3e = _0x466dc410.transform;
            DOTween.Kill(_0x8df45f3e);
            _0x8df45f3e.localScale = Vector3.zero;
            _0x8df45f3e.DOScale(1f, 0.26f).SetDelay(0.12f * _0x6ec64b93).SetEase(Ease.OutBack);
        }

        _0xad9ed8e9.Instance._0x8f7cb98f(_0x68897f3a._0x890b9fee.WIN);
    }

    private Action _0x03751b21;
    public void _0x50179c29(TMP_FontAsset _0x2a824b61, Sprite _0x99f8d9c2, Sprite _0x54ae75c9, Sprite _0x5b746099, Sprite _0xe325f088, Sprite _0x403343e6, Action _0xe8cdcfc7, Action _0x8873db42, Action _0x9f5401ef, Action _0x6b30b2fb, Action _0x7a18d578)
    {
        if (this._0x09d67e0b || _0xad9ed8e9.Instance == null)
            return;
        this._0x8cdb2728 = _0x2a824b61;
        this._0x7041854e = _0x99f8d9c2;
        this._0xc22cad6c = _0x54ae75c9;
        this._0x81c29a33 = _0x5b746099;
        this._0x74db2158 = _0xe325f088;
        this._0xbc041fee = _0x403343e6;
        this._0x03751b21 = _0x6b30b2fb;
        _0x04fe9665 _0x15613d32 = _0xad9ed8e9.Instance._0xd483b1a8(_0x68897f3a._0x890b9fee.WIN);
        _0x04fe9665 _0x6a3f83f5 = _0xad9ed8e9.Instance._0xd483b1a8(_0x68897f3a._0x890b9fee.LOSE);
        _0x04fe9665 _0x562a6550 = _0xad9ed8e9.Instance._0xd483b1a8(_0x68897f3a._0x890b9fee.PAUSE);
        this._0x212836b4(_0x15613d32, _0xe8cdcfc7, _0x9f5401ef);
        this._0x81f327ec(_0x6a3f83f5, _0x8873db42, _0x9f5401ef);
        this._0xedebb225(_0x562a6550, _0x6b30b2fb, _0x7a18d578, _0x9f5401ef);
        this._0x09d67e0b = true;
    }

    public void _0x5754b976(bool _0x0866b980, int _0xdf2fd1bd, int _0xf78f6f8d)
    {
        if (_0xad9ed8e9.Instance == null)
            return;
        if (this._0x63a77c43 != null)
            this._0x63a77c43.text = _0x72f5a2b2._0x73cae641(new byte[14] { 184, 164, 169, 204, 160, 165, 171, 164, 184, 204, 168, 165, 169, 168 }, 236);
        if (this._0xe927df45 != null)
            this._0xe927df45.text = _0x0866b980 ? _0x72f5a2b2._0x73cae641(new byte[12] { 240, 234, 235, 159, 240, 249, 159, 242, 240, 233, 250, 236 }, 191) : _0x72f5a2b2._0x73cae641(new byte[13] { 82, 72, 73, 61, 82, 91, 61, 94, 85, 88, 94, 86, 78 }, 29);
        if (this._0x9450d4eb != null)
            this._0x9450d4eb.text = _0x72f5a2b2._0x73cae641(new byte[14] { 204, 203, 207, 195, 221, 174, 195, 207, 218, 205, 198, 203, 202, 174 }, 142) + _0xdf2fd1bd.ToString() + _0x72f5a2b2._0x73cae641(new byte[4] { 45, 66, 75, 45 }, 13) + _0xf78f6f8d.ToString();
        _0xad9ed8e9.Instance._0x8f7cb98f(_0x68897f3a._0x890b9fee.LOSE);
    }

    private TextMeshProUGUI _0xe927df45;
    private const float AutoReleaseSeconds = 9f;
    private Sprite _0xc22cad6c;
    private TextMeshProUGUI _0xd4705950;
    private TextMeshProUGUI _0x9450d4eb;
    private void _0x81f327ec(_0x04fe9665 _0xeff93be8, Action _0xcd876c9a, Action _0x78116b4e)
    {
        RectTransform _0x7e80024d = this._0x356e45dd(_0xeff93be8, _0x61e0b808.Rose);
        if (_0x7e80024d == null)
            return;
        this._0x63a77c43 = _0x0816affa.Caption(_0x7e80024d, _0x72f5a2b2._0x73cae641(new byte[10] { 220, 255, 227, 245, 216, 245, 241, 244, 245, 226 }, 144), new Vector2(0.5f, 0.87f), new Vector2(880f, 110f), _0x72f5a2b2._0x73cae641(new byte[14] { 139, 151, 154, 255, 147, 150, 152, 151, 139, 255, 155, 150, 154, 155 }, 223), 56f, _0x61e0b808.RoseLight, this._0x8cdb2728);
        RectTransform _0xe1e92171 = _0x0816affa.Node(_0x7e80024d, _0x72f5a2b2._0x73cae641(new byte[8] { 10, 41, 53, 35, 11, 39, 52, 45 }, 70), new Vector2(0.5f, 0.66f), new Vector2(300f, 300f));
        _0x0816affa.Picture(_0xe1e92171, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.35f), this._0xbc041fee, false, 1f);
        this._0xe927df45 = _0x0816affa.Caption(_0x7e80024d, _0x72f5a2b2._0x73cae641(new byte[8] { 143, 172, 176, 166, 129, 172, 167, 186 }, 195), new Vector2(0.5f, 0.47f), new Vector2(880f, 84f), _0x72f5a2b2._0x73cae641(new byte[12] { 242, 232, 233, 157, 242, 251, 157, 240, 242, 235, 248, 238 }, 189), 40f, _0x61e0b808.Cream, this._0x8cdb2728);
        this._0x9450d4eb = _0x0816affa.Caption(_0x7e80024d, _0x72f5a2b2._0x73cae641(new byte[9] { 144, 179, 175, 185, 153, 164, 168, 174, 189 }, 220), new Vector2(0.5f, 0.385f), new Vector2(880f, 76f), _0x72f5a2b2._0x73cae641(new byte[20] { 198, 193, 197, 201, 215, 164, 201, 197, 208, 199, 204, 193, 192, 164, 180, 164, 203, 194, 164, 183 }, 132), 36f, _0x61e0b808.Gold, this._0x8cdb2728);
        _0x0816affa.ActionButton(_0x7e80024d, _0x72f5a2b2._0x73cae641(new byte[9] { 191, 156, 128, 150, 161, 150, 135, 129, 138 }, 243), new Vector2(0.5f, 0.24f), new Vector2(720f, 150f), _0x61e0b808.Gold, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.85f), _0x61e0b808.Cream, _0x72f5a2b2._0x73cae641(new byte[5] { 204, 219, 202, 204, 199 }, 158), 48f, this._0x7041854e, 1.9f, this._0x8cdb2728, () => _0xcd876c9a());
        _0x0816affa.ActionButton(_0x7e80024d, _0x72f5a2b2._0x73cae641(new byte[8] { 24, 59, 39, 49, 25, 49, 58, 33 }, 84), new Vector2(0.5f, 0.1f), new Vector2(560f, 124f), _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.85f), _0x61e0b808.WithAlpha(_0x61e0b808.Teal, 0.8f), _0x61e0b808.Cream, _0x72f5a2b2._0x73cae641(new byte[4] { 70, 78, 69, 94 }, 11), 42f, this._0x7041854e, 1.9f, this._0x8cdb2728, () => _0x78116b4e());
    }

    private Sprite _0xbc041fee;
    // ── card scaffolding ────────────────────────────────────────────────────
    private RectTransform _0x356e45dd(_0x04fe9665 _0x16e55561, Color _0x1a4b89ed)
    {
        if (_0x16e55561 == null || _0x16e55561.Content == null)
            return null;
        // Wake the body first - everything below is built into it.
        _0x16e55561.Content.SetActive(true);
        _0x0816affa.ClearChildren(_0x16e55561.Content.transform);
        RectTransform _0x55c1c7c5 = _0x0816affa.Node(_0x16e55561.Content.transform, _0x72f5a2b2._0x73cae641(new byte[10] { 16, 39, 49, 55, 46, 54, 1, 35, 48, 38 }, 66), new Vector2(0.5f, 0.5f), new Vector2(1000f, 1180f));
        Image _0x9077208a = _0x0816affa.Picture(_0x55c1c7c5, _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.95f), this._0x7041854e, this._0x7041854e != null, 1.3f);
        _0x9077208a.raycastTarget = true;
        RectTransform _0x6f7cf4a9 = _0x0816affa.Sheet(_0x55c1c7c5, _0x72f5a2b2._0x73cae641(new byte[7] { 235, 201, 218, 204, 250, 193, 197 }, 168));
        _0x0816affa.Picture(_0x6f7cf4a9, _0x61e0b808.WithAlpha(_0x1a4b89ed, 0.9f), this._0x7041854e, this._0x7041854e != null, 2.6f);
        // Own close glyph: the template's close button has no sprite assigned, and an
        // Image with no sprite draws as a plain white square.
        _0x0816affa.IconButton(_0x55c1c7c5, _0x72f5a2b2._0x73cae641(new byte[9] { 31, 61, 46, 56, 31, 48, 51, 47, 57 }, 92), new Vector2(0.88f, 0.93f), new Vector2(104f, 104f), this._0xc22cad6c, _0x61e0b808.Cream, () => this._0xab25b413());
        return _0x55c1c7c5;
    }

    private TextMeshProUGUI _0x6b4d1245;
    private Sprite _0x74db2158;
    private void _0xedebb225(_0x04fe9665 _0x1f5306fb, Action _0x4cb0c623, Action _0x344d891f, Action _0xb9e183bf)
    {
        RectTransform _0x4e9a6a80 = this._0x356e45dd(_0x1f5306fb, _0x61e0b808.Teal);
        if (_0x4e9a6a80 == null)
            return;
        _0x0816affa.Caption(_0x4e9a6a80, _0x72f5a2b2._0x73cae641(new byte[11] { 107, 90, 78, 72, 94, 115, 94, 90, 95, 94, 73 }, 59), new Vector2(0.5f, 0.86f), new Vector2(880f, 110f), _0x72f5a2b2._0x73cae641(new byte[16] { 78, 67, 74, 66, 38, 79, 72, 38, 82, 78, 67, 38, 66, 71, 84, 77 }, 6), 52f, _0x61e0b808.Cream, this._0x8cdb2728);
        this._0xd4705950 = _0x0816affa.Caption(_0x4e9a6a80, _0x72f5a2b2._0x73cae641(new byte[9] { 70, 119, 99, 101, 115, 84, 121, 114, 111 }, 22), new Vector2(0.5f, 0.72f), new Vector2(880f, 84f), _0x72f5a2b2._0x73cae641(new byte[9] { 93, 77, 70, 75, 67, 75, 46, 62, 63 }, 14), 42f, _0x61e0b808.Gold, this._0x8cdb2728);
        this._0x2b2db75e = _0x0816affa.Caption(_0x4e9a6a80, _0x72f5a2b2._0x73cae641(new byte[10] { 68, 117, 97, 103, 113, 81, 108, 96, 102, 117 }, 20), new Vector2(0.5f, 0.63f), new Vector2(880f, 76f), _0x72f5a2b2._0x73cae641(new byte[12] { 246, 244, 237, 254, 232, 155, 247, 254, 253, 239, 155, 136 }, 187), 36f, _0x61e0b808.Teal, this._0x8cdb2728);
        _0x0816affa.ActionButton(_0x4e9a6a80, _0x72f5a2b2._0x73cae641(new byte[11] { 163, 146, 134, 128, 150, 161, 150, 128, 134, 158, 150 }, 243), new Vector2(0.5f, 0.44f), new Vector2(720f, 150f), _0x61e0b808.Teal, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.85f), _0x61e0b808.Cream, _0x72f5a2b2._0x73cae641(new byte[6] { 7, 16, 6, 0, 24, 16 }, 85), 48f, this._0x7041854e, 1.9f, this._0x8cdb2728, () => _0x4cb0c623());
        _0x0816affa.ActionButton(_0x4e9a6a80, _0x72f5a2b2._0x73cae641(new byte[12] { 15, 62, 42, 44, 58, 13, 58, 44, 43, 62, 45, 43 }, 95), new Vector2(0.5f, 0.28f), new Vector2(560f, 124f), _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.85f), _0x61e0b808.WithAlpha(_0x61e0b808.Gold, 0.8f), _0x61e0b808.Cream, _0x72f5a2b2._0x73cae641(new byte[7] { 147, 132, 146, 149, 128, 147, 149 }, 193), 42f, this._0x7041854e, 1.9f, this._0x8cdb2728, () => _0x344d891f());
        _0x0816affa.ActionButton(_0x4e9a6a80, _0x72f5a2b2._0x73cae641(new byte[9] { 36, 21, 1, 7, 17, 57, 17, 26, 1 }, 116), new Vector2(0.5f, 0.13f), new Vector2(560f, 124f), _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.85f), _0x61e0b808.WithAlpha(_0x61e0b808.Teal, 0.8f), _0x61e0b808.Cream, _0x72f5a2b2._0x73cae641(new byte[4] { 70, 78, 69, 94 }, 11), 42f, this._0x7041854e, 1.9f, this._0x8cdb2728, () => _0xb9e183bf());
    }
}

internal static class _0x72f5a2b2
{
    internal static string _0x73cae641(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}