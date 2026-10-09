using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Settings. There is no sound in this game, so there is no sound row, no volume
/// slider and no speaker glyph (rule C.20) - the three live rows are vibration, a
/// high-contrast mode for the facets, and erasing progress behind a confirmation.
/// </summary>
public sealed class _0xd5f58c65 : MonoBehaviour
{
    private Image _0x3a2f1070;
    public void _0xba5027d4(Transform _0x3b64129a, _0x7ae38e03 _0xddb18f7f, Action _0xd786f757)
    {
        this._0x408cd29c = _0x0816affa.Sheet(_0x3b64129a, _0xb5eede71._0x5d1c675a(new byte[13] { 168, 158, 143, 143, 146, 149, 156, 136, 168, 147, 158, 158, 143 }, 251));
        _0x0816affa.Shade(this._0x408cd29c, _0xb5eede71._0x5d1c675a(new byte[13] { 154, 172, 189, 189, 160, 167, 174, 186, 154, 161, 168, 173, 172 }, 201), _0x61e0b808.WithAlpha(_0x61e0b808.InkDeep, 0.9f), () => this._0xc6ff227a());
        RectTransform _0x20fb53a8 = _0x0816affa.Node(this._0x408cd29c, _0xb5eede71._0x5d1c675a(new byte[13] { 239, 217, 200, 200, 213, 210, 219, 207, 236, 221, 210, 217, 208 }, 188), new Vector2(0.5f, 0.54f), new Vector2(1040f, 1180f));
        Image _0xc62b1266 = _0x0816affa.Picture(_0x20fb53a8, _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.95f), this._plateSprite, this._plateSprite != null, 1.3f);
        _0xc62b1266.raycastTarget = true;
        RectTransform _0x6f04af76 = _0x0816affa.Sheet(_0x20fb53a8, _0xb5eede71._0x5d1c675a(new byte[11] { 112, 70, 87, 87, 74, 77, 68, 80, 113, 74, 78 }, 35));
        _0x0816affa.Picture(_0x6f04af76, _0x61e0b808.WithAlpha(_0x61e0b808.Gold, 0.9f), this._plateSprite, this._plateSprite != null, 2.6f);
        _0x0816affa.Caption(_0x20fb53a8, _0xb5eede71._0x5d1c675a(new byte[13] { 148, 162, 179, 179, 174, 169, 160, 180, 147, 174, 179, 171, 162 }, 199), new Vector2(0.5f, 0.9f), new Vector2(700f, 100f), _0xb5eede71._0x5d1c675a(new byte[8] { 181, 163, 178, 178, 175, 168, 161, 181 }, 230), 50f, _0x61e0b808.Cream, this._font);
        _0x0816affa.IconButton(_0x20fb53a8, _0xb5eede71._0x5d1c675a(new byte[13] { 200, 254, 239, 239, 242, 245, 252, 232, 216, 247, 244, 232, 254 }, 155), new Vector2(0.88f, 0.905f), new Vector2(100f, 100f), this._closeIcon, _0x61e0b808.Cream, () => this._0xc6ff227a());
        this._0x3a2f1070 = _0x0816affa.Plate(_0x20fb53a8, _0xb5eede71._0x5d1c675a(new byte[12] { 90, 101, 110, 126, 109, 120, 101, 99, 98, 94, 99, 123 }, 12), new Vector2(0.5f, 0.71f), new Vector2(900f, 150f), _0x61e0b808.WithAlpha(_0x61e0b808.VioletDeep, 0.8f), _0x61e0b808.WithAlpha(_0x61e0b808.Teal, 0.5f), this._plateSprite, 2.6f);
        _0x0816affa.Caption(this._0x3a2f1070.rectTransform, _0xb5eede71._0x5d1c675a(new byte[14] { 201, 246, 253, 237, 254, 235, 246, 240, 241, 211, 254, 253, 250, 243 }, 159), new Vector2(0.33f, 0.5f), new Vector2(520f, 72f), _0xb5eede71._0x5d1c675a(new byte[9] { 39, 56, 51, 35, 48, 37, 56, 62, 63 }, 113), 38f, _0x61e0b808.Cream, this._font);
        this._0xfc80e6e7 = _0x0816affa.Caption(this._0x3a2f1070.rectTransform, _0xb5eede71._0x5d1c675a(new byte[14] { 182, 137, 130, 146, 129, 148, 137, 143, 142, 179, 148, 129, 148, 133 }, 224), new Vector2(0.84f, 0.5f), new Vector2(180f, 72f), _0xb5eede71._0x5d1c675a(new byte[2] { 233, 232 }, 166), 38f, _0x61e0b808.Teal, this._font);
        this._0xabaa0b6c(this._0x3a2f1070, () => this._0xc92489e8(_0xddb18f7f));
        this._0x278dbe06 = _0x0816affa.Plate(_0x20fb53a8, _0xb5eede71._0x5d1c675a(new byte[11] { 244, 216, 217, 195, 197, 214, 196, 195, 229, 216, 192 }, 183), new Vector2(0.5f, 0.54f), new Vector2(900f, 150f), _0x61e0b808.WithAlpha(_0x61e0b808.VioletDeep, 0.8f), _0x61e0b808.WithAlpha(_0x61e0b808.Teal, 0.5f), this._plateSprite, 2.6f);
        _0x0816affa.Caption(this._0x278dbe06.rectTransform, _0xb5eede71._0x5d1c675a(new byte[13] { 88, 116, 117, 111, 105, 122, 104, 111, 87, 122, 121, 126, 119 }, 27), new Vector2(0.33f, 0.5f), new Vector2(560f, 72f), _0xb5eede71._0x5d1c675a(new byte[20] { 43, 42, 36, 43, 67, 32, 44, 45, 55, 49, 34, 48, 55, 67, 37, 34, 32, 38, 55, 48 }, 99), 32f, _0x61e0b808.Cream, this._font);
        this._0xf0b9db3d = _0x0816affa.Caption(this._0x278dbe06.rectTransform, _0xb5eede71._0x5d1c675a(new byte[13] { 75, 103, 102, 124, 122, 105, 123, 124, 91, 124, 105, 124, 109 }, 8), new Vector2(0.84f, 0.5f), new Vector2(180f, 72f), _0xb5eede71._0x5d1c675a(new byte[3] { 248, 241, 241 }, 183), 38f, _0x61e0b808.Gold, this._font);
        this._0xabaa0b6c(this._0x278dbe06, () => this._0x2ba449c7(_0xddb18f7f));
        _0x0816affa.ActionButton(_0x20fb53a8, _0xb5eede71._0x5d1c675a(new byte[8] { 69, 114, 100, 114, 99, 69, 120, 96 }, 23), new Vector2(0.5f, 0.3f), new Vector2(760f, 140f), _0x61e0b808.WithAlpha(_0x61e0b808.VioletDeep, 0.85f), _0x61e0b808.WithAlpha(_0x61e0b808.Rose, 0.9f), _0x61e0b808.Cream, _0xb5eede71._0x5d1c675a(new byte[14] { 178, 165, 179, 165, 180, 192, 176, 178, 175, 167, 178, 165, 179, 179 }, 224), 36f, this._plateSprite, 1.9f, this._font, () => this._0xf0d0e9aa());
        // confirmation lives in this sheet; the menu scene has no pops wired to show
        this._0x521f6f59 = _0x0816affa.Sheet(this._0x408cd29c, _0xb5eede71._0x5d1c675a(new byte[12] { 237, 218, 201, 219, 205, 235, 199, 198, 206, 193, 218, 197 }, 168));
        _0x0816affa.Shade(this._0x521f6f59, _0xb5eede71._0x5d1c675a(new byte[10] { 171, 156, 143, 157, 139, 189, 134, 143, 138, 139 }, 238), _0x61e0b808.WithAlpha(_0x61e0b808.InkDeep, 0.85f), () => this._0x113f990b());
        RectTransform _0xc0c592f6 = _0x0816affa.Node(this._0x521f6f59, _0xb5eede71._0x5d1c675a(new byte[9] { 14, 57, 42, 56, 46, 8, 42, 57, 47 }, 75), new Vector2(0.5f, 0.52f), new Vector2(920f, 620f));
        Image _0x09cbe7f5 = _0x0816affa.Picture(_0xc0c592f6, _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.96f), this._plateSprite, this._plateSprite != null, 1.3f);
        _0x09cbe7f5.raycastTarget = true;
        RectTransform _0xeedc6575 = _0x0816affa.Sheet(_0xc0c592f6, _0xb5eede71._0x5d1c675a(new byte[8] { 41, 30, 13, 31, 9, 62, 5, 1 }, 108));
        _0x0816affa.Picture(_0xeedc6575, _0x61e0b808.WithAlpha(_0x61e0b808.Rose, 0.9f), this._plateSprite, this._plateSprite != null, 2.6f);
        _0x0816affa.Caption(_0xc0c592f6, _0xb5eede71._0x5d1c675a(new byte[10] { 31, 40, 59, 41, 63, 14, 51, 46, 54, 63 }, 90), new Vector2(0.5f, 0.74f), new Vector2(820f, 110f), _0xb5eede71._0x5d1c675a(new byte[17] { 244, 227, 240, 226, 244, 145, 240, 253, 253, 145, 226, 242, 249, 244, 252, 244, 226 }, 177), 42f, _0x61e0b808.Cream, this._font);
        _0x0816affa.ActionButton(_0xc0c592f6, _0xb5eede71._0x5d1c675a(new byte[8] { 31, 40, 59, 41, 63, 3, 63, 41 }, 90), new Vector2(0.3f, 0.3f), new Vector2(360f, 130f), _0x61e0b808.WithAlpha(_0x61e0b808.Rose, 0.9f), _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.8f), _0x61e0b808.Cream, _0xb5eede71._0x5d1c675a(new byte[5] { 64, 87, 68, 86, 64 }, 5), 40f, this._plateSprite, 1.9f, this._font, () => this._0xadf1f54e(_0xddb18f7f, _0xd786f757));
        _0x0816affa.ActionButton(_0xc0c592f6, _0xb5eede71._0x5d1c675a(new byte[7] { 65, 118, 101, 119, 97, 74, 107 }, 4), new Vector2(0.7f, 0.3f), new Vector2(360f, 130f), _0x61e0b808.WithAlpha(_0x61e0b808.Teal, 0.9f), _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.8f), _0x61e0b808.Cream, _0xb5eede71._0x5d1c675a(new byte[4] { 32, 46, 46, 59 }, 107), 40f, this._plateSprite, 1.9f, this._font, () => this._0x113f990b());
        this._0x521f6f59.gameObject.SetActive(false);
        this._0xb9ecf673(_0xddb18f7f);
        this._0x408cd29c.gameObject.SetActive(false);
    }

    private RectTransform _0x408cd29c;
    private void _0xadf1f54e(_0x7ae38e03 _0x74b0ccdc, Action _0x2444b9c2)
    {
        _0x74b0ccdc._0x6df57c75();
        this._0x113f990b();
        this._0xb9ecf673(_0x74b0ccdc);
        if (_0x2444b9c2 != null)
            _0x2444b9c2();
    }

    [SerializeField]
    private Sprite _plateSprite;
    private void _0xc92489e8(_0x7ae38e03 _0xe45aa0ff)
    {
        _0xe45aa0ff._0x91d3a6e2 = !_0xe45aa0ff._0x91d3a6e2;
        if (_0xe45aa0ff._0x91d3a6e2)
        {
            try
            {
                Handheld.Vibrate();
            }
            catch (System.Exception)
            {
            // a device without a vibrator is not a failure
            }
        }

        this._0xb9ecf673(_0xe45aa0ff);
    }

    private void _0xabaa0b6c(Image _0x229f1f94, Action onTap)
    {
        if (_0x229f1f94 == null)
            return;
        _0x229f1f94.raycastTarget = true;
        Button _0xa507a590 = _0x229f1f94.gameObject.AddComponent<Button>();
        _0xa507a590.targetGraphic = _0x229f1f94;
        _0xa507a590.transition = Selectable.Transition.None;
        Transform _0x20472f0f = _0x229f1f94.transform;
        _0xa507a590.onClick.AddListener(() => _0x0816affa.Punch(_0x20472f0f));
        _0xa507a590.onClick.AddListener(() => onTap());
    }

    /// <summary>Every toggle changes a colour as well as a word, so the answer is visible.</summary>
    private void _0xb9ecf673(_0x7ae38e03 _0xc5af5454)
    {
        if (this._0xfc80e6e7 != null)
        {
            this._0xfc80e6e7.text = _0xc5af5454._0x91d3a6e2 ? _0xb5eede71._0x5d1c675a(new byte[2] { 153, 152 }, 214) : _0xb5eede71._0x5d1c675a(new byte[3] { 203, 194, 194 }, 132);
            this._0xfc80e6e7.color = _0xc5af5454._0x91d3a6e2 ? _0x61e0b808.Teal : _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.55f);
        }

        if (this._0x3a2f1070 != null)
            this._0x3a2f1070.color = _0xc5af5454._0x91d3a6e2 ? _0x61e0b808.WithAlpha(_0x61e0b808.TealDeep, 0.85f) : _0x61e0b808.WithAlpha(_0x61e0b808.VioletDeep, 0.8f);
        if (this._0xf0b9db3d != null)
        {
            this._0xf0b9db3d.text = _0xc5af5454._0x56b4eea9 ? _0xb5eede71._0x5d1c675a(new byte[2] { 191, 190 }, 240) : _0xb5eede71._0x5d1c675a(new byte[3] { 121, 112, 112 }, 54);
            this._0xf0b9db3d.color = _0xc5af5454._0x56b4eea9 ? _0x61e0b808.Teal : _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.55f);
        }

        if (this._0x278dbe06 != null)
            this._0x278dbe06.color = _0xc5af5454._0x56b4eea9 ? _0x61e0b808.WithAlpha(_0x61e0b808.TealDeep, 0.85f) : _0x61e0b808.WithAlpha(_0x61e0b808.VioletDeep, 0.8f);
    }

    private void _0xf0d0e9aa()
    {
        if (this._0x521f6f59 == null)
            return;
        this._0x521f6f59.gameObject.SetActive(true);
        this._0x521f6f59.localScale = Vector3.one * 0.94f;
        this._0x521f6f59.DOScale(1f, 0.2f).SetEase(Ease.OutCubic);
    }

    private Image _0x278dbe06;
    private RectTransform _0x521f6f59;
    private TextMeshProUGUI _0xfc80e6e7;
    public void _0xc6ff227a()
    {
        this._0x113f990b();
        if (this._0x408cd29c != null)
            this._0x408cd29c.gameObject.SetActive(false);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    public void _0x5b32838f(_0x7ae38e03 _0xe17fd5ab)
    {
        if (this._0x408cd29c == null)
            return;
        this._0xb9ecf673(_0xe17fd5ab);
        this._0x113f990b();
        this._0x408cd29c.gameObject.SetActive(true);
        this._0x408cd29c.localScale = Vector3.one * 0.94f;
        this._0x408cd29c.DOScale(1f, 0.22f).SetEase(Ease.OutCubic);
    }

    private void _0x113f990b()
    {
        if (this._0x521f6f59 != null)
            this._0x521f6f59.gameObject.SetActive(false);
    }

    private void _0x2ba449c7(_0x7ae38e03 _0x327b4bbb)
    {
        _0x327b4bbb._0x56b4eea9 = !_0x327b4bbb._0x56b4eea9;
        this._0xb9ecf673(_0x327b4bbb);
    }

    [SerializeField]
    private Sprite _closeIcon;
    private TextMeshProUGUI _0xf0b9db3d;
}

internal static class _0xb5eede71
{
    internal static string _0x5d1c675a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}