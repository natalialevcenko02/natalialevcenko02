using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x100d4fdc : MonoBehaviour
{
    private void _0xd7efa8c4()
    {
        if (this._0x901cce4a == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xf40b9993 = Screen.safeArea;
        Vector2 _0x5f2fae1c = _0xf40b9993.position;
        Vector2 _0x7790acba = _0xf40b9993.position + _0xf40b9993.size;
        _0x5f2fae1c.x /= screenWidth;
        _0x5f2fae1c.y /= screenHeight;
        _0x7790acba.x /= screenWidth;
        _0x7790acba.y /= screenHeight;
        this._0x901cce4a.anchorMin = _0x5f2fae1c;
        this._0x901cce4a.anchorMax = _0x7790acba;
        this._0x901cce4a.offsetMin = Vector2.zero;
        this._0x901cce4a.offsetMax = Vector2.zero;
        if (this._0xff961874 == null)
            return;
        Vector2 _0x48b2e3c5 = _0x7790acba - _0x5f2fae1c;
        float _0xdc902b4a = 2f - _0x48b2e3c5.x;
        float _0x816d8008 = 2f - _0x48b2e3c5.y;
        this._0xff961874.referenceResolution = this._0xd5a95209 * new Vector2(_0xdc902b4a, _0x816d8008);
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x497c4cae = 0; _0x497c4cae < _0x94e9bf67.Count; _0x497c4cae++)
            _0x94e9bf67[_0x497c4cae]._0xd7efa8c4();
    }

    private static Vector2 _0x79929c49 = Vector2.zero;
    private void Start()
    {
    }

    private CanvasScaler _0xff961874;
    private static bool _0x71e94db9;
    private static UnityEvent _0xd29e374e = new();
    private Vector2 _0xd5a95209;
    private static void SafeAreaChanged()
    {
        _0x55e65c0e = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static void ResolutionChanged()
    {
        _0x79929c49.x = Screen.width;
        _0x79929c49.y = Screen.height;
        _0x55e65c0e = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xd29e374e.Invoke();
    }

    private static void OrientationChanged()
    {
        _0x35276016 = Screen.orientation;
        _0x79929c49.x = Screen.width;
        _0x79929c49.y = Screen.height;
        _0x55e65c0e = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xd29e374e.Invoke();
    }

    private void Awake()
    {
        if (!_0x94e9bf67.Contains(this))
            _0x94e9bf67.Add(this);
        this._0x291b2ab1 = this.GetComponent<Canvas>();
        this._0xff961874 = this.GetComponent<CanvasScaler>();
        if (this._0xff961874 != null)
            this._0xd5a95209 = this._0xff961874.referenceResolution;
        this._0x6e9aab8f = this.GetComponent<RectTransform>();
        this._0x901cce4a = this.transform.Find(_0xd74ed963._0x61b31c50(new byte[8] { 80, 98, 101, 102, 66, 113, 102, 98 }, 3)) as RectTransform;
        if (!_0x71e94db9)
        {
            _0x35276016 = Screen.orientation;
            _0x79929c49.x = Screen.width;
            _0x79929c49.y = Screen.height;
            _0x55e65c0e = Screen.safeArea;
            _0x71e94db9 = true;
        }

        this._0xd7efa8c4();
    }

    private void Update()
    {
        if (_0x94e9bf67.Count == 0 || _0x94e9bf67[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x35276016)
            OrientationChanged();
        if (Screen.safeArea != _0x55e65c0e)
            SafeAreaChanged();
        if (Screen.width != _0x79929c49.x || Screen.height != _0x79929c49.y)
            ResolutionChanged();
    }

    private static readonly List<_0x100d4fdc> _0x94e9bf67 = new();
    private Canvas _0x291b2ab1;
    private RectTransform _0x6e9aab8f;
    private RectTransform _0x901cce4a;
    private static ScreenOrientation _0x35276016 = ScreenOrientation.LandscapeLeft;
    private void OnDestroy()
    {
        if (_0x94e9bf67 != null && _0x94e9bf67.Contains(this))
            _0x94e9bf67.Remove(this);
    }

    private static Rect _0x55e65c0e = Rect.zero;
}

internal static class _0xd74ed963
{
    internal static string _0x61b31c50(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}