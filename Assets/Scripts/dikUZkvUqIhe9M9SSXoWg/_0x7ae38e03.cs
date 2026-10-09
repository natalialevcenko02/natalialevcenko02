using UnityEngine;

/// <summary>
/// Progress: which schemes are open, the stars each one earned, and the two
/// accessibility switches. Lumens are kept in the template's own purse
/// (SETTINGS.PlayerSYSTEM.Coins) so a single number drives every readout.
///
/// Keys are literal strings on purpose: a persisted identifier must not move when
/// the obfuscator renames a field, so nothing here is derived from a C# name.
/// </summary>
public sealed class _0x7ae38e03
{
    public void _0x034e4d81(int _0xa1ee7a96, int _0x14431970, int _0x89164f7d)
    {
        int _0x394ce257 = Mathf.Max(this._0xcc02d959(_0xa1ee7a96), Mathf.Clamp(_0x14431970, 1, 3));
        PlayerPrefs.SetInt(StarsKey + _0xa1ee7a96.ToString(), _0x394ce257);
        if (_0xa1ee7a96 + 1 >= this._0xbdc1a512)
            this._0xbdc1a512 = _0xa1ee7a96 + 2;
        this._0x83e2c73d(_0x89164f7d);
        PlayerPrefs.Save();
    }

    public int _0x1401eba9()
    {
        int _0x7bfbf5b5 = 0;
        for (int _0x4eb602e7 = 0; _0x4eb602e7 < _0x0f439b88._0x65132f1c; _0x4eb602e7++)
            if (this._0xcc02d959(_0x4eb602e7) > 0)
                _0x7bfbf5b5++;
        return _0x7bfbf5b5;
    }

    public void _0x6df57c75()
    {
        for (int _0x39470738 = 0; _0x39470738 < _0x0f439b88._0x65132f1c; _0x39470738++)
        {
            PlayerPrefs.DeleteKey(StarsKey + _0x39470738.ToString());
            PlayerPrefs.DeleteKey(StarsKey + _0x45383d80._0xecc6d18c(new byte[1] { 196 }, 165) + _0x39470738.ToString());
        }

        PlayerPrefs.SetInt(UnlockedKey, 1);
        PlayerPrefs.SetInt(CurrentKey, 0);
        if (_0x6da5105f.Instance != null)
            _0x68897f3a._0xe9080e3c._0x12295ddc = 0;
        PlayerPrefs.Save();
    }

    private static readonly string VibrationKey = _0x45383d80._0xecc6d18c(new byte[13] { 12, 12, 1, 72, 16, 15, 4, 20, 7, 18, 15, 9, 8 }, 102);
    private static readonly string ContrastKey = _0x45383d80._0xecc6d18c(new byte[12] { 87, 87, 90, 19, 94, 82, 83, 73, 79, 92, 78, 73 }, 61);
    private static readonly string CurrentKey = _0x45383d80._0xecc6d18c(new byte[11] { 40, 40, 37, 108, 33, 55, 48, 48, 39, 44, 54 }, 66);
    public int _0xca0ad396
    {
        get
        {
            return _0x68897f3a._0xe9080e3c._0x12295ddc;
        }
    }

    private static readonly string UnlockedKey = _0x45383d80._0xecc6d18c(new byte[12] { 217, 217, 212, 157, 198, 221, 223, 220, 208, 216, 214, 215 }, 179);
    public bool _0x56b4eea9
    {
        get
        {
            return PlayerPrefs.GetInt(ContrastKey, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(ContrastKey, value ? 1 : 0);
        }
    }

    public int _0xbdc1a512
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(UnlockedKey, 1), 1, _0x0f439b88._0x65132f1c);
        }

        set
        {
            PlayerPrefs.SetInt(UnlockedKey, Mathf.Clamp(value, 1, _0x0f439b88._0x65132f1c));
        }
    }

    public static int LumensFor(int _0x2e09caa6, int _0x618cc681)
    {
        return 60 * _0x2e09caa6 + 20 * _0x618cc681;
    }

    public bool _0x91d3a6e2
    {
        get
        {
            return PlayerPrefs.GetInt(VibrationKey, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(VibrationKey, value ? 1 : 0);
        }
    }

    /// <summary>How many times this scheme has been started - seeds a different board each run.</summary>
    public int _0x6906afa7(int _0x7b8b5860)
    {
        return PlayerPrefs.GetInt(StarsKey + _0x45383d80._0xecc6d18c(new byte[1] { 133 }, 228) + _0x7b8b5860.ToString(), 0);
    }

    public bool _0x2c68ff00(int _0xc1908af9)
    {
        return _0xc1908af9 < this._0xbdc1a512;
    }

    /// <summary>
    /// The purse setter calls back into BasicController to refresh its counters, so it
    /// is only safe once that controller has woken.
    /// </summary>
    public void _0x83e2c73d(int _0xd8ef9810)
    {
        if (_0xd8ef9810 == 0 || _0x6da5105f.Instance == null)
            return;
        _0x68897f3a._0xe9080e3c._0x12295ddc = Mathf.Max(0, _0x68897f3a._0xe9080e3c._0x12295ddc + _0xd8ef9810);
    }

    public static int StarsEarned(int _0x86486dda, int _0xfc15b2d4)
    {
        if (_0x86486dda <= _0xfc15b2d4)
            return 3;
        return _0x86486dda <= _0xfc15b2d4 + 1 ? 2 : 1;
    }

    private static readonly string StarsKey = _0x45383d80._0xecc6d18c(new byte[10] { 232, 232, 229, 172, 241, 246, 227, 240, 241, 172 }, 130);
    public int _0x36c52805
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(CurrentKey, 0), 0, _0x0f439b88._0x65132f1c - 1);
        }

        set
        {
            PlayerPrefs.SetInt(CurrentKey, Mathf.Clamp(value, 0, _0x0f439b88._0x65132f1c - 1));
        }
    }

    public int _0xcc02d959(int _0x8eaf5cfa)
    {
        return Mathf.Clamp(PlayerPrefs.GetInt(StarsKey + _0x8eaf5cfa.ToString(), 0), 0, 3);
    }

    public void _0xb7bd9fb0(int _0xfd559328)
    {
        PlayerPrefs.SetInt(StarsKey + _0x45383d80._0xecc6d18c(new byte[1] { 123 }, 26) + _0xfd559328.ToString(), this._0x6906afa7(_0xfd559328) + 1);
        PlayerPrefs.Save();
    }
}

internal static class _0x45383d80
{
    internal static string _0xecc6d18c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}