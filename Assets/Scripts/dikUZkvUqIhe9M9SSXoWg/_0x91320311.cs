using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Builds the whole menu into the template's DefaultPanel body.
///
/// The template's Play button is a prefab instance that already carries the scene
/// loader, so it is the ONE child the sweep keeps: this class draws its gold face
/// inside it (raycast off, so taps fall through to the template's own hit area) and
/// adds a press punch. Nothing here loads the scene itself - that would double-load.
/// </summary>
public sealed class _0x91320311 : MonoBehaviour
{
    private readonly _0x7ae38e03 _0x093edd7d = new _0x7ae38e03();
    [SerializeField]
    private TMP_FontAsset _font;
    private void _0x19e6a192(Transform _0x7e15fd26)
    {
        this._0xbfa6492d = _0x0816affa.Sheet(_0x7e15fd26, _0xe8a55f3a._0x07342653(new byte[10] { 96, 71, 95, 124, 71, 123, 64, 77, 77, 92 }, 40));
        _0x0816affa.Shade(this._0xbfa6492d, _0xe8a55f3a._0x07342653(new byte[10] { 145, 182, 174, 141, 182, 138, 177, 184, 189, 188 }, 217), _0x61e0b808.WithAlpha(_0x61e0b808.InkDeep, 0.92f), () => this._0x71d116ad());
        RectTransform _0x6b1f77c2 = _0x0816affa.Node(this._0xbfa6492d, _0xe8a55f3a._0x07342653(new byte[9] { 79, 104, 112, 83, 104, 68, 102, 117, 99 }, 7), new Vector2(0.5f, 0.54f), new Vector2(1020f, 1240f));
        Image _0x5b9fa30a = _0x0816affa.Picture(_0x6b1f77c2, _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.95f), this._plateSprite, this._plateSprite != null, 1.3f);
        _0x5b9fa30a.raycastTarget = true;
        RectTransform _0x077552b7 = _0x0816affa.Sheet(_0x6b1f77c2, _0xe8a55f3a._0x07342653(new byte[8] { 168, 143, 151, 180, 143, 178, 137, 141 }, 224));
        _0x0816affa.Picture(_0x077552b7, _0x61e0b808.WithAlpha(_0x61e0b808.Teal, 0.9f), this._plateSprite, this._plateSprite != null, 2.6f);
        _0x0816affa.Caption(_0x6b1f77c2, _0xe8a55f3a._0x07342653(new byte[10] { 50, 21, 13, 46, 21, 46, 19, 14, 22, 31 }, 122), new Vector2(0.5f, 0.9f), new Vector2(800f, 100f), _0xe8a55f3a._0x07342653(new byte[11] { 32, 39, 63, 72, 60, 39, 72, 56, 36, 41, 49 }, 104), 46f, _0x61e0b808.Cream, this._font);
        _0x0816affa.IconButton(_0x6b1f77c2, _0xe8a55f3a._0x07342653(new byte[10] { 107, 76, 84, 119, 76, 96, 79, 76, 80, 70 }, 35), new Vector2(0.88f, 0.905f), new Vector2(100f, 100f), this._closeIcon, _0x61e0b808.Cream, () => this._0x71d116ad());
        _0x0816affa.Caption(_0x6b1f77c2, _0xe8a55f3a._0x07342653(new byte[10] { 244, 211, 203, 232, 211, 239, 200, 217, 204, 141 }, 188), new Vector2(0.5f, 0.71f), new Vector2(920f, 150f), _0xe8a55f3a._0x07342653(new byte[41] { 131, 150, 135, 247, 152, 153, 146, 247, 132, 131, 152, 153, 146, 221, 131, 159, 146, 153, 247, 131, 150, 135, 247, 150, 247, 132, 131, 152, 153, 146, 247, 153, 146, 143, 131, 247, 131, 152, 247, 158, 131 }, 215), 34f, _0x61e0b808.Cream, this._font);
        _0x0816affa.Caption(_0x6b1f77c2, _0xe8a55f3a._0x07342653(new byte[10] { 250, 221, 197, 230, 221, 225, 198, 215, 194, 128 }, 178), new Vector2(0.5f, 0.53f), new Vector2(920f, 150f), _0xe8a55f3a._0x07342653(new byte[37] { 71, 67, 88, 88, 69, 88, 89, 42, 72, 79, 68, 78, 42, 94, 66, 79, 42, 70, 67, 77, 66, 94, 0, 68, 67, 68, 79, 94, 83, 42, 78, 79, 77, 88, 79, 79, 89 }, 10), 34f, _0x61e0b808.Gold, this._font);
        _0x0816affa.Caption(_0x6b1f77c2, _0xe8a55f3a._0x07342653(new byte[10] { 153, 190, 166, 133, 190, 130, 165, 180, 161, 226 }, 209), new Vector2(0.5f, 0.35f), new Vector2(920f, 150f), _0xe8a55f3a._0x07342653(new byte[49] { 92, 79, 92, 75, 64, 57, 91, 92, 88, 84, 57, 84, 76, 74, 77, 57, 75, 92, 88, 90, 81, 19, 77, 81, 92, 57, 95, 88, 90, 92, 77, 57, 86, 95, 57, 80, 77, 74, 57, 86, 78, 87, 57, 90, 86, 85, 86, 76, 75 }, 25), 34f, _0x61e0b808.Teal, this._font);
        _0x0816affa.ActionButton(_0x6b1f77c2, _0xe8a55f3a._0x07342653(new byte[9] { 116, 83, 75, 104, 83, 120, 83, 82, 89 }, 60), new Vector2(0.5f, 0.14f), new Vector2(600f, 140f), _0x61e0b808.Gold, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.85f), _0x61e0b808.Cream, _0xe8a55f3a._0x07342653(new byte[6] { 199, 207, 212, 160, 201, 212 }, 128), 44f, this._plateSprite, 1.9f, this._font, () => this._0x71d116ad());
        this._0xbfa6492d.gameObject.SetActive(false);
    }

    [SerializeField]
    private RectTransform _playButtonRect;
    private void _0x959bb98a(Transform _0x73158f79)
    {
        this._0x5bd65050();
        RectTransform _0xfc0cc703 = _0x0816affa.ActionButton(_0x73158f79, _0xe8a55f3a._0x07342653(new byte[13] { 215, 231, 236, 225, 233, 225, 247, 198, 241, 240, 240, 235, 234 }, 132), new Vector2(0.5f, 0.206f), new Vector2(560f, 124f), _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.85f), _0x61e0b808.WithAlpha(_0x61e0b808.Teal, 0.9f), _0x61e0b808.Cream, _0xe8a55f3a._0x07342653(new byte[7] { 28, 12, 7, 10, 2, 10, 28 }, 79), 42f, this._plateSprite, 1.9f, this._font, () => this._0x0aab8804()).GetComponent<RectTransform>();
        RectTransform _0x2e43fb4e = _0x0816affa.ActionButton(_0x73158f79, _0xe8a55f3a._0x07342653(new byte[11] { 251, 220, 196, 231, 220, 241, 198, 199, 199, 220, 221 }, 179), new Vector2(0.5f, 0.133f), new Vector2(560f, 104f), _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.25f), _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.4f), _0x61e0b808.Cream, _0xe8a55f3a._0x07342653(new byte[11] { 214, 209, 201, 190, 202, 209, 190, 206, 210, 223, 199 }, 158), 36f, this._plateSprite, 1.9f, this._font, () => this._0x74a9141e()).GetComponent<RectTransform>();
        this._0x81a4723c = _0x0816affa.Caption(_0x73158f79, _0xe8a55f3a._0x07342653(new byte[13] { 244, 214, 203, 195, 214, 193, 215, 215, 232, 197, 198, 193, 200 }, 164), new Vector2(0.5f, 0.072f), new Vector2(900f, 56f), _0xe8a55f3a._0x07342653(new byte[22] { 186, 170, 161, 172, 164, 172, 186, 201, 170, 165, 172, 168, 187, 172, 173, 201, 217, 201, 198, 201, 216, 219 }, 233), 32f, _0x61e0b808.Teal, this._font);
        _0x0816affa.FadeIn(_0xfc0cc703, 0.06f);
        _0x0816affa.FadeIn(_0x2e43fb4e, 0.12f);
        _0x0816affa.FadeIn(this._0x81a4723c.rectTransform, 0.18f);
    }

    private RectTransform _0xbfa6492d;
    private void _0x93977a46(int _0x4d4740f1)
    {
        this._0x093edd7d._0x36c52805 = _0x4d4740f1;
        if (this._gallery != null)
            this._gallery._0x653db0fa();
        if (_0x6da5105f.Instance != null)
            _0x6da5105f.Instance.LoadSceneByIndex(_0x68897f3a._0x35276d64.SCENE_1);
    }

    private TextMeshProUGUI _0xecdc603b;
    /// <summary>
    /// Gives the template's invisible Play target a face. Every graphic added here has
    /// raycastTarget off, so the tap still reaches the template hit area underneath and
    /// its own LoadSceneButton does the loading.
    /// </summary>
    private void _0x5bd65050()
    {
        if (this._playButtonRect == null)
            return;
        RectTransform _0x8f683a01 = _0x0816affa.Sheet(this._playButtonRect, _0xe8a55f3a._0x07342653(new byte[8] { 184, 132, 137, 145, 174, 137, 139, 141 }, 232));
        _0x0816affa.Picture(_0x8f683a01, _0x61e0b808.Gold, this._plateSprite, this._plateSprite != null, 1.9f);
        RectTransform _0xb46f59dc = _0x0816affa.Sheet(_0x8f683a01, _0xe8a55f3a._0x07342653(new byte[7] { 240, 204, 193, 217, 242, 201, 205 }, 160));
        _0x0816affa.Picture(_0xb46f59dc, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.9f), this._plateSprite, this._plateSprite != null, 3.1f);
        _0x0816affa.Caption(_0x8f683a01, _0xe8a55f3a._0x07342653(new byte[9] { 232, 212, 217, 193, 244, 217, 218, 221, 212 }, 184), new Vector2(0.5f, 0.5f), new Vector2(620f, 100f), _0xe8a55f3a._0x07342653(new byte[4] { 248, 228, 233, 241 }, 168), 62f, _0x61e0b808.Cream, this._font);
        Button _0xd037df45 = this._playButtonRect.GetComponentInChildren<Button>(true);
        if (_0xd037df45 != null)
        {
            Transform _0x9e96bbd9 = _0x8f683a01;
            _0xd037df45.onClick.AddListener(() => _0x0816affa.Punch(_0x9e96bbd9));
        }
    }

    [SerializeField]
    private Sprite _closeIcon;
    [SerializeField]
    private _0xff0ce341 _splash;
    [SerializeField]
    private _0xb4490d12 _gemStage;
    private void _0x6e8a1cf5()
    {
        if (this._0xecdc603b != null)
            this._0xecdc603b.text = _0xe8a55f3a._0x07342653(new byte[7] { 215, 206, 214, 222, 213, 200, 187 }, 155) + this._0x093edd7d._0xca0ad396.ToString();
        if (this._0x81a4723c != null)
            this._0x81a4723c.text = _0xe8a55f3a._0x07342653(new byte[16] { 184, 168, 163, 174, 166, 174, 184, 203, 168, 167, 174, 170, 185, 174, 175, 203 }, 235) + this._0x093edd7d._0x1401eba9().ToString() + _0xe8a55f3a._0x07342653(new byte[3] { 74, 69, 74 }, 106) + _0x0f439b88._0x65132f1c.ToString();
    }

    [SerializeField]
    private _0xd7745a38 _gallery;
    private void _0x71d116ad()
    {
        if (this._0xbfa6492d != null)
            this._0xbfa6492d.gameObject.SetActive(false);
    }

    // ── actions ─────────────────────────────────────────────────────────────
    private void _0x0aab8804()
    {
        if (this._gallery != null)
            this._gallery._0x85107fa3(this._0x093edd7d);
    }

    [SerializeField]
    private Sprite _gearIcon;
    private void _0x5e9948b4()
    {
        if (this._settings != null)
            this._settings._0x5b32838f(this._0x093edd7d);
    }

    private void Start()
    {
        if (this._splash != null)
            this._splash._0x9df44b3b();
        if (_0xb01be533.Instance == null)
            return;
        _0x9db1d5cc _0xac58213d = _0xb01be533.Instance.Panels[_0x68897f3a._0x215fc08c.DEFAULT];
        if (_0xac58213d == null || _0xac58213d.Content == null)
            return;
        Transform _0x48979218 = _0xac58213d.Content.transform;
        _0x0816affa.ClearChildrenExcept(_0x48979218, this._playButtonRect);
        this._0x073e1426(_0x48979218);
        this._0x959bb98a(_0x48979218);
        if (this._gallery != null)
            this._gallery._0xac97f3f4(_0x48979218, this._0x093edd7d, (int _0x3d222adc) => this._0x93977a46(_0x3d222adc));
        if (this._settings != null)
            this._settings._0xba5027d4(_0x48979218, this._0x093edd7d, () => this._0x6e8a1cf5());
        this._0x19e6a192(_0x48979218);
        this._0x6e8a1cf5();
        this._0x36d049e9();
    }

    private void _0x073e1426(Transform _0x07f42a5d)
    {
        // decoration first, so every control below is a later sibling and draws on top
        if (this._gemStage != null)
            this._gemStage._0x0bae8c59(_0x07f42a5d, new Vector2(0.5f, 0.645f), 700f);
        Image _0x794c2cb1 = _0x0816affa.Plate(_0x07f42a5d, _0xe8a55f3a._0x07342653(new byte[10] { 34, 7, 0, 1, 23, 34, 30, 19, 6, 23 }, 114), new Vector2(0.26f, 0.935f), new Vector2(420f, 92f), _0x61e0b808.WithAlpha(_0x61e0b808.InkDeep, 0.7f), _0x61e0b808.WithAlpha(_0x61e0b808.Gold, 0.5f), this._plateSprite, 2.6f);
        this._0xecdc603b = _0x0816affa.Caption(_0x794c2cb1.rectTransform, _0xe8a55f3a._0x07342653(new byte[10] { 54, 19, 20, 21, 3, 42, 7, 4, 3, 10 }, 102), new Vector2(0.5f, 0.5f), new Vector2(380f, 70f), _0xe8a55f3a._0x07342653(new byte[8] { 196, 221, 197, 205, 198, 219, 168, 184 }, 136), 40f, _0x61e0b808.Gold, this._font);
        _0x0816affa.IconButton(_0x07f42a5d, _0xe8a55f3a._0x07342653(new byte[14] { 21, 35, 50, 50, 47, 40, 33, 53, 4, 51, 50, 50, 41, 40 }, 70), new Vector2(0.885f, 0.935f), new Vector2(132f, 132f), this._gearIcon, _0x61e0b808.Cream, () => this._0x5e9948b4());
        _0x0816affa.Caption(_0x07f42a5d, _0xe8a55f3a._0x07342653(new byte[9] { 180, 153, 145, 158, 152, 143, 146, 141, 158 }, 251), new Vector2(0.5f, 0.455f), new Vector2(900f, 72f), _0xe8a55f3a._0x07342653(new byte[17] { 21, 16, 30, 17, 13, 121, 28, 15, 28, 11, 0, 121, 31, 24, 26, 28, 13 }, 89), 38f, _0x61e0b808.Cream, this._font);
    }

    [SerializeField]
    private _0xd5f58c65 _settings;
    /// <summary>
    /// The template ships five tutorial panels carrying placeholder prose. Nothing in
    /// this game raises them - the brief's three lessons live in the HOW TO PLAY sheet
    /// above - so every label in all seven declared tutorial slots is blanked, and the
    /// template's filler can never reach a screen (rule C.15).
    /// </summary>
    private void _0x36d049e9()
    {
        this._0xc4aa9d67(_0x68897f3a._0x215fc08c.TUTORIAL0);
        this._0xc4aa9d67(_0x68897f3a._0x215fc08c.TUTORIAL1);
        this._0xc4aa9d67(_0x68897f3a._0x215fc08c.TUTORIAL2);
        this._0xc4aa9d67(_0x68897f3a._0x215fc08c.TUTORIAL3);
        this._0xc4aa9d67(_0x68897f3a._0x215fc08c.TUTORIAL4);
        this._0xc4aa9d67(_0x68897f3a._0x215fc08c.TUTORIAL5);
        this._0xc4aa9d67(_0x68897f3a._0x215fc08c.TUTORIAL6);
    }

    private void _0xc4aa9d67(int _0xaddca330)
    {
        if (_0xb01be533.Instance == null)
            return;
        List<_0x9db1d5cc> _0xb74e7976 = _0xb01be533.Instance.Panels;
        if (_0xb74e7976 == null || _0xaddca330 < 0 || _0xaddca330 >= _0xb74e7976.Count)
            return;
        _0x9db1d5cc _0xdeea6dc5 = _0xb74e7976[_0xaddca330];
        if (_0xdeea6dc5 == null || _0xdeea6dc5.Content == null)
            return;
        _0x0816affa.BlankLabels(_0xdeea6dc5.Content.transform);
    }

    [SerializeField]
    private Sprite _plateSprite;
    private TextMeshProUGUI _0x81a4723c;
    private void _0x74a9141e()
    {
        if (this._0xbfa6492d == null)
            return;
        this._0xbfa6492d.gameObject.SetActive(true);
        this._0xbfa6492d.localScale = Vector3.one * 0.94f;
        this._0xbfa6492d.DOScale(1f, 0.22f).SetEase(Ease.OutCubic);
    }
}

internal static class _0xe8a55f3a
{
    internal static string _0x07342653(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}