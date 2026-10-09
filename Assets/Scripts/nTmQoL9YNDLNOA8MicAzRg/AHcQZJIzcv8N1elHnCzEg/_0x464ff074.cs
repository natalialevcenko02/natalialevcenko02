using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x464ff074 : MonoBehaviour
{
    private static void OrientationChanged()
    {
        _0x5e996cb6 = Screen.orientation;
        _0x37d12a9a.x = Screen.width;
        _0x37d12a9a.y = Screen.height;
        _0x13f3abdf.Invoke();
    }

    private RectTransform _0xd6f7467f;
    private static Vector2 _0x37d12a9a = Vector2.zero;
    private static readonly List<_0x464ff074> _0x3cfaa363 = new();
    private static Rect _0xa4d1b8f2 = Rect.zero;
    private void OnDestroy()
    {
        if (_0x3cfaa363 != null && _0x3cfaa363.Contains(this))
            _0x3cfaa363.Remove(this);
    }

    private void Awake()
    {
        if (!_0x3cfaa363.Contains(this))
            _0x3cfaa363.Add(this);
        this._0x661754c2 = this.GetComponent<Canvas>();
        this._0xd6f7467f = this.GetComponent<RectTransform>();
        this._0x239c7667 = this.transform.Find(_0x19d6f008._0xfc599fd8(new byte[8] { 139, 185, 190, 189, 153, 170, 189, 185 }, 216)) as RectTransform;
        if (!_0x72621a83)
        {
            _0x5e996cb6 = Screen.orientation;
            _0x37d12a9a.x = Screen.width;
            _0x37d12a9a.y = Screen.height;
            _0xa4d1b8f2 = Screen.safeArea;
            _0x72621a83 = true;
        }

        this._0x9e1a2cc8();
    }

    private void _0x9e1a2cc8()
    {
        if (this._0x239c7667 == null)
            return;
        Rect _0x553e5127 = Screen.safeArea;
        Vector2 _0xcaf81fe3 = _0x553e5127.position;
        Vector2 _0x9a26ee31 = _0x553e5127.position + _0x553e5127.size;
        _0xcaf81fe3.x /= this._0x661754c2.pixelRect.width;
        _0xcaf81fe3.y /= this._0x661754c2.pixelRect.height;
        _0x9a26ee31.x /= this._0x661754c2.pixelRect.width;
        _0x9a26ee31.y /= this._0x661754c2.pixelRect.height;
        this._0x239c7667.anchorMin = _0xcaf81fe3;
        this._0x239c7667.anchorMax = _0x9a26ee31;
    }

    private RectTransform _0x239c7667;
    private static bool _0x72621a83;
    private static void SafeAreaChanged()
    {
        _0xa4d1b8f2 = Screen.safeArea;
        for (int _0xba19db45 = 0; _0xba19db45 < _0x3cfaa363.Count; _0xba19db45++)
            _0x3cfaa363[_0xba19db45]._0x9e1a2cc8();
    }

    private static UnityEvent _0x13f3abdf = new();
    private Canvas _0x661754c2;
    private static void ResolutionChanged()
    {
        _0x37d12a9a.x = Screen.width;
        _0x37d12a9a.y = Screen.height;
        _0x13f3abdf.Invoke();
    }

    private void Update()
    {
        if (_0x3cfaa363[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x5e996cb6)
            OrientationChanged();
        if (Screen.safeArea != _0xa4d1b8f2)
            SafeAreaChanged();
        if (Screen.width != _0x37d12a9a.x || Screen.height != _0x37d12a9a.y)
            ResolutionChanged();
    }

    private static ScreenOrientation _0x5e996cb6 = ScreenOrientation.LandscapeLeft;
}

internal static class _0x19d6f008
{
    internal static string _0xfc599fd8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}