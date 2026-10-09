using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The scheme gallery: twelve cards, each showing its number, the stars it earned and
/// a difficulty word, or a padlock when it is still shut.
///
/// Rule C.25 is the whole layout: the three stars live in a 42 px gutter centred on
/// x=62 and the text column starts at x=129, so the two never share an x band. The
/// shade behind the sheet is itself a close control, so a tap that misses the corner
/// glyph still dismisses the overlay instead of parking the capture on it.
/// </summary>
public sealed class _0xd7745a38 : MonoBehaviour
{
    [SerializeField]
    private Sprite _plateSprite;
    private const float CardGap = 28f;
    /// <summary>A shut card still answers the tap - it says which scheme opens it.</summary>
    private void _0xa5ca5d0c(int _0x64edeb6b)
    {
        if (this._0x277ea933 == null)
            return;
        this._0x277ea933.text = _0x6e76a09d._0x20a60971(new byte[13] { 56, 55, 62, 58, 41, 91, 40, 56, 51, 62, 54, 62, 91 }, 123) + _0x64edeb6b.ToString(_0x6e76a09d._0x20a60971(new byte[2] { 175, 175 }, 159)) + _0x6e76a09d._0x20a60971(new byte[6] { 67, 37, 42, 49, 48, 55 }, 99);
        this._0x277ea933.color = _0x61e0b808.Gold;
        TextMeshProUGUI _0xb3c4a9be = this._0x277ea933;
        DOTween.Kill(_0xb3c4a9be);
        _0xb3c4a9be.alpha = 1f;
        DOTween.To(() => _0xb3c4a9be.alpha, (float _0x90f7f453) => _0xb3c4a9be.alpha = _0x90f7f453, 0.75f, 0.4f).SetDelay(1.6f).SetId(_0xb3c4a9be);
    }

    public void _0x85107fa3(_0x7ae38e03 _0x2c6cc3c7)
    {
        if (this._0xf5649b25 == null)
            return;
        if (this._0x277ea933 != null)
        {
            bool _0xa1aaf937 = _0x2c6cc3c7._0xbdc1a512 <= 1;
            this._0x277ea933.text = _0xa1aaf937 ? _0x6e76a09d._0x20a60971(new byte[48] { 88, 89, 66, 94, 95, 88, 81, 54, 67, 88, 90, 89, 85, 93, 83, 82, 54, 79, 83, 66, 28, 85, 90, 83, 87, 68, 54, 87, 54, 69, 85, 94, 83, 91, 83, 54, 66, 89, 54, 89, 70, 83, 88, 54, 91, 89, 68, 83 }, 22) : _0x6e76a09d._0x20a60971(new byte[22] { 163, 186, 176, 184, 211, 178, 211, 160, 176, 187, 182, 190, 182, 211, 167, 188, 211, 191, 186, 180, 187, 167 }, 243);
            this._0x277ea933.color = _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.75f);
        }

        this._0xf5649b25.gameObject.SetActive(true);
        this._0xf5649b25.localScale = Vector3.one * 0.94f;
        this._0xf5649b25.DOScale(1f, 0.22f).SetEase(Ease.OutCubic);
    }

    private const float GutterCentre = 62f;
    public void _0x653db0fa()
    {
        if (this._0xf5649b25 != null)
            this._0xf5649b25.gameObject.SetActive(false);
    }

    private static string TierFor(int _0x48c96af1)
    {
        if (_0x48c96af1 <= 3)
            return _0x6e76a09d._0x20a60971(new byte[4] { 20, 16, 2, 8 }, 81);
        return _0x48c96af1 <= 7 ? _0x6e76a09d._0x20a60971(new byte[6] { 200, 216, 195, 205, 194, 222 }, 138) : _0x6e76a09d._0x20a60971(new byte[8] { 103, 105, 108, 107, 97, 108, 107, 98 }, 37);
    }

    private const float CardSize = 320f;
    [SerializeField]
    private TMP_FontAsset _font;
    private static Color TierColour(int _0x346ad492)
    {
        if (_0x346ad492 <= 3)
            return _0x61e0b808.Teal;
        return _0x346ad492 <= 7 ? _0x61e0b808.Gold : _0x61e0b808.RoseLight;
    }

    [SerializeField]
    private Sprite _gemMark;
    [SerializeField]
    private Sprite _lockIcon;
    public void _0xac97f3f4(Transform _0xbe43d130, _0x7ae38e03 _0x3c3b86dc, Action<int> _0x829d131c)
    {
        this._0xf5649b25 = _0x0816affa.Sheet(_0xbe43d130, _0x6e76a09d._0x20a60971(new byte[13] { 102, 86, 93, 80, 88, 80, 114, 84, 89, 89, 80, 71, 76 }, 53));
        _0x0816affa.Shade(this._0xf5649b25, _0x6e76a09d._0x20a60971(new byte[12] { 98, 68, 73, 73, 64, 87, 92, 118, 77, 68, 65, 64 }, 37), _0x61e0b808.WithAlpha(_0x61e0b808.InkDeep, 0.92f), () => this._0x653db0fa());
        RectTransform _0xe1e831da = _0x0816affa.Node(this._0xf5649b25, _0x6e76a09d._0x20a60971(new byte[12] { 140, 170, 167, 167, 174, 185, 178, 155, 170, 165, 174, 167 }, 203), new Vector2(0.5f, 0.52f), new Vector2(1120f, 1900f));
        _0x0816affa.Picture(_0xe1e831da, _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.95f), this._plateSprite, this._plateSprite != null, 1.3f);
        RectTransform _0xb7074bd6 = _0x0816affa.Sheet(_0xe1e831da, _0x6e76a09d._0x20a60971(new byte[10] { 243, 213, 216, 216, 209, 198, 205, 230, 221, 217 }, 180));
        _0x0816affa.Picture(_0xb7074bd6, _0x61e0b808.WithAlpha(_0x61e0b808.Gold, 0.9f), this._plateSprite, this._plateSprite != null, 2.6f);
        Image _0xe0a2119d = _0xe1e831da.gameObject.GetComponent<Image>();
        if (_0xe0a2119d != null)
            _0xe0a2119d.raycastTarget = true; // taps inside the sheet must not close it
        _0x0816affa.Caption(_0xe1e831da, _0x6e76a09d._0x20a60971(new byte[12] { 27, 61, 48, 48, 57, 46, 37, 8, 53, 40, 48, 57 }, 92), new Vector2(0.5f, 0.93f), new Vector2(760f, 100f), _0x6e76a09d._0x20a60971(new byte[7] { 75, 91, 80, 93, 85, 93, 75 }, 24), 52f, _0x61e0b808.Cream, this._font);
        _0x0816affa.IconButton(_0xe1e831da, _0x6e76a09d._0x20a60971(new byte[12] { 107, 77, 64, 64, 73, 94, 85, 111, 64, 67, 95, 73 }, 44), new Vector2(0.885f, 0.935f), new Vector2(104f, 104f), this._closeIcon, _0x61e0b808.Cream, () => this._0x653db0fa());
        for (int _0x76864ac1 = 0; _0x76864ac1 < _0x0f439b88._0x65132f1c; _0x76864ac1++)
            this._0x5206d57c(_0xe1e831da, _0x3c3b86dc, _0x76864ac1, _0x829d131c);
        this._0x277ea933 = _0x0816affa.Caption(_0xe1e831da, _0x6e76a09d._0x20a60971(new byte[13] { 153, 191, 178, 178, 187, 172, 167, 144, 177, 170, 183, 189, 187 }, 222), new Vector2(0.5f, 0.1f), new Vector2(980f, 150f), _0x6e76a09d._0x20a60971(new byte[48] { 209, 208, 203, 215, 214, 209, 216, 191, 202, 209, 211, 208, 220, 212, 218, 219, 191, 198, 218, 203, 149, 220, 211, 218, 222, 205, 191, 222, 191, 204, 220, 215, 218, 210, 218, 191, 203, 208, 191, 208, 207, 218, 209, 191, 210, 208, 205, 218 }, 159), 30f, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.75f), this._font);
        this._0xf5649b25.gameObject.SetActive(false);
    }

    [SerializeField]
    private Sprite _closeIcon;
    private const float TextCentre = 209f;
    private void _0x5206d57c(RectTransform _0x82aa0027, _0x7ae38e03 _0xdcba3845, int _0x19a6210a, Action<int> _0x48cb4121)
    {
        int _0x37491981 = _0x19a6210a % 3;
        int _0xeb219c86 = _0x19a6210a / 3;
        float _0x75dd5a40 = 0.5f + (_0x37491981 - 1) * (CardSize + CardGap) / 1120f;
        float _0xc9f1d0c6 = 0.46f + (1.5f - _0xeb219c86) * (CardSize + CardGap) / 1900f;
        bool _0x4315d5e2 = _0xdcba3845._0x2c68ff00(_0x19a6210a);
        int _0xb23098a2 = _0xdcba3845._0xcc02d959(_0x19a6210a);
        RectTransform _0x9fd9ce62 = _0x0816affa.Node(_0x82aa0027, _0x6e76a09d._0x20a60971(new byte[10] { 202, 250, 241, 252, 244, 252, 218, 248, 235, 253 }, 153) + _0x19a6210a.ToString(), new Vector2(_0x75dd5a40, _0xc9f1d0c6), new Vector2(CardSize, CardSize));
        Image _0xcd7140e7 = _0x0816affa.Picture(_0x9fd9ce62, _0x4315d5e2 ? _0x61e0b808.WithAlpha(_0x61e0b808.VioletDeep, 0.9f) : _0x61e0b808.WithAlpha(_0x61e0b808.VioletDeep, 0.5f), this._plateSprite, this._plateSprite != null, 2.6f);
        _0xcd7140e7.raycastTarget = true;
        if (_0x4315d5e2)
        {
            for (int _0x95705e2c = 0; _0x95705e2c < 3; _0x95705e2c++)
            {
                RectTransform _0x16ec1d1e = _0x0816affa.Node(_0x9fd9ce62, _0x6e76a09d._0x20a60971(new byte[8] { 240, 210, 193, 215, 224, 199, 210, 193 }, 179) + _0x95705e2c.ToString(), new Vector2(GutterCentre / CardSize, 0.5f + (1 - _0x95705e2c) * 56f / CardSize), new Vector2(42f, 42f));
                bool _0x9728cc40 = _0x95705e2c < _0xb23098a2;
                _0x0816affa.Picture(_0x16ec1d1e, _0x9728cc40 ? _0x61e0b808.Gold : _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.3f), _0x9728cc40 ? this._starFull : this._starEmpty, false, 1f);
            }

            _0x0816affa.Caption(_0x9fd9ce62, _0x6e76a09d._0x20a60971(new byte[10] { 38, 4, 23, 1, 43, 16, 8, 7, 0, 23 }, 101) + _0x19a6210a.ToString(), new Vector2(TextCentre / CardSize, 0.68f), new Vector2(160f, 86f), (_0x19a6210a + 1).ToString(_0x6e76a09d._0x20a60971(new byte[2] { 160, 160 }, 144)), 56f, _0x61e0b808.Gold, this._font);
            _0x0816affa.Caption(_0x9fd9ce62, _0x6e76a09d._0x20a60971(new byte[8] { 23, 53, 38, 48, 0, 61, 49, 38 }, 84) + _0x19a6210a.ToString(), new Vector2(TextCentre / CardSize, 0.3f), new Vector2(160f, 52f), TierFor(_0x19a6210a), 26f, TierColour(_0x19a6210a), this._font);
        }
        else
        {
            RectTransform _0x682a8584 = _0x0816affa.Node(_0x9fd9ce62, _0x6e76a09d._0x20a60971(new byte[9] { 186, 152, 139, 157, 190, 145, 150, 138, 141 }, 249) + _0x19a6210a.ToString(), new Vector2(0.5f, 0.56f), new Vector2(150f, 150f));
            _0x0816affa.Picture(_0x682a8584, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.25f), this._gemMark, false, 1f);
            RectTransform _0xf60eb366 = _0x0816affa.Node(_0x9fd9ce62, _0x6e76a09d._0x20a60971(new byte[8] { 184, 154, 137, 159, 183, 148, 152, 144 }, 251) + _0x19a6210a.ToString(), new Vector2(0.5f, 0.26f), new Vector2(64f, 64f));
            _0x0816affa.Picture(_0xf60eb366, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.6f), this._lockIcon, false, 1f);
        }

        Button _0x6b1f94b8 = _0x9fd9ce62.gameObject.AddComponent<Button>();
        _0x6b1f94b8.targetGraphic = _0xcd7140e7;
        _0x6b1f94b8.transition = Selectable.Transition.None;
        int _0x63278d47 = _0x19a6210a;
        int _0xb13742e6 = _0xdcba3845._0xbdc1a512;
        Transform _0x83658ebf = _0x9fd9ce62;
        _0x6b1f94b8.onClick.AddListener(() => _0x0816affa.Punch(_0x83658ebf));
        if (_0x4315d5e2)
            _0x6b1f94b8.onClick.AddListener(() => _0x48cb4121(_0x63278d47));
        else
            _0x6b1f94b8.onClick.AddListener(() => this._0xa5ca5d0c(_0xb13742e6));
    }

    [SerializeField]
    private Sprite _starFull;
    private TextMeshProUGUI _0x277ea933;
    private RectTransform _0xf5649b25;
    [SerializeField]
    private Sprite _starEmpty;
    public bool _0xe0f2f505
    {
        get
        {
            return this._0xf5649b25 != null && this._0xf5649b25.gameObject.activeSelf;
        }
    }
}

internal static class _0x6e76a09d
{
    internal static string _0x20a60971(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}