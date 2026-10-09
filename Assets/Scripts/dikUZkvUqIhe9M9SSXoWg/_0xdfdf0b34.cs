/// <summary>
/// The puzzle state: a 6x6 grid of stones plus the emitters and facets that ring it.
/// Pure data and pure rules - no Unity types, so the whole model can be reasoned
/// about (and replayed) without a scene.
///
/// Directions are indexed 0=Right 1=Up 2=Left 3=Down, which makes the two mirrors
/// one arithmetic step each:
///   '/'  (slash)     right-up, up-right, left-down, down-left   =  d ^ 1
///   '\'  (backslash) right-down, down-right, left-up, up-left   =  3 - d
/// </summary>
public sealed class _0xdfdf0b34
{
    public void _0x87e02085(int _0x3ae98c1d, int _0xca5efd94, int _0x607bda24, int _0x3496b585)
    {
        int _0x4afeffb0 = this._0x1b82a742(_0x3ae98c1d, _0xca5efd94);
        int _0xe19d5dd3 = this._0x1b82a742(_0x607bda24, _0x3496b585);
        this._0xac68cb14(_0x3ae98c1d, _0xca5efd94, _0xe19d5dd3);
        this._0xac68cb14(_0x607bda24, _0x3496b585, _0x4afeffb0);
    }

    public const int CellBack = 2;
    public const int DirRight = 0;
    public static int DeltaY(int _0x9dc91e08)
    {
        return _0x1936a89b[_0x9dc91e08 & 3];
    }

    /// <summary>Entry cell and inward direction of each beam, by beam index.</summary>
    private readonly int[] _0x5a4fc395 = new int[3];
    public int _0x6c353e1c(int _0xfc9f2af7)
    {
        return this._0xb5ed835e[_0xfc9f2af7];
    }

    public int _0x7bd5aef9(int _0x15cafdbb)
    {
        return this._0x5a4fc395[_0x15cafdbb];
    }

    public const int Rows = 6;
    public void _0xac68cb14(int _0x6a0229ab, int _0x4ea22490, int _0xf6e7b529)
    {
        if (Inside(_0x6a0229ab, _0x4ea22490))
            this._0xe6f2e5dd[_0x4ea22490 * Cols + _0x6a0229ab] = _0xf6e7b529;
    }

    public const int Cols = 6;
    public static bool IsMovable(int _0x6f731a60)
    {
        return _0x6f731a60 != CellOnyx;
    }

    public static bool IsMirror(int _0x9f6f7e8a)
    {
        return _0x9f6f7e8a == CellSlash || _0x9f6f7e8a == CellBack;
    }

    public int _0xd9d14a80(int _0xb37ff5dd)
    {
        return this._0x1d913d2b[_0xb37ff5dd] - DeltaY(this._0x236efb27[_0xb37ff5dd]);
    }

    public const int CellSlash = 1;
    private readonly int[] _0x8b6922d7 = new int[3];
    private static readonly int[] _0x1936a89b =
    {
        0,
        1,
        0,
        -1
    };
    public static bool Inside(int _0x2ad060e4, int _0x2858037b)
    {
        return _0x2ad060e4 >= 0 && _0x2ad060e4 < Cols && _0x2858037b >= 0 && _0x2858037b < Rows;
    }

    public const int CellOnyx = 3;
    private readonly int[] _0xe6f2e5dd = new int[Cols * Rows];
    private readonly int[] _0x1d913d2b = new int[3];
    public void _0x76eb1f72(int _0x825d1e47, int _0x02b9199b, int _0x75f4e8b9, int _0xb1806d4b, int _0x193d0595, int _0x88d14b57)
    {
        this._0x5a4fc395[_0x825d1e47] = _0x02b9199b;
        this._0x1d913d2b[_0x825d1e47] = _0x75f4e8b9;
        this._0x236efb27[_0x825d1e47] = _0xb1806d4b;
        this._0xb5ed835e[_0x825d1e47] = _0x193d0595;
        this._0x8b6922d7[_0x825d1e47] = _0x88d14b57;
    }

    public static int DeltaX(int _0x099f2c9e)
    {
        return _0x9c029e71[_0x099f2c9e & 3];
    }

    /// <summary>The out-of-grid cell each beam has to leave through, by beam index.</summary>
    private readonly int[] _0xb5ed835e = new int[3];
    private static readonly int[] _0x9c029e71 =
    {
        1,
        0,
        -1,
        0
    };
    public int[] _0x7652d916()
    {
        int[] _0xe6eee92b = new int[this._0xe6f2e5dd.Length];
        for (int _0x6e46c90c = 0; _0x6e46c90c < this._0xe6f2e5dd.Length; _0x6e46c90c++)
            _0xe6eee92b[_0x6e46c90c] = this._0xe6f2e5dd[_0x6e46c90c];
        return _0xe6eee92b;
    }

    public const int CellInert = 0;
    public const int DirUp = 1;
    public static int Deflect(int _0xb8e2d959, int _0x5307312b)
    {
        if (_0xb8e2d959 == CellSlash)
            return _0x5307312b ^ 1;
        if (_0xb8e2d959 == CellBack)
            return 3 - _0x5307312b;
        return _0x5307312b;
    }

    public int _0x6a35a8be(int _0x447438f3)
    {
        return this._0x236efb27[_0x447438f3];
    }

    public const int DirLeft = 2;
    /// <summary>True when both cells hold stones the player is allowed to move.</summary>
    public bool _0x4bb02775(int _0x556facac, int _0x3e176aee, int _0xebf07ac6, int _0xbbe74db0)
    {
        if (!Inside(_0x556facac, _0x3e176aee) || !Inside(_0xebf07ac6, _0xbbe74db0))
            return false;
        int _0xc258e3f9 = _0x556facac - _0xebf07ac6;
        int _0x356bd013 = _0x3e176aee - _0xbbe74db0;
        if (_0xc258e3f9 * _0xc258e3f9 + _0x356bd013 * _0x356bd013 != 1)
            return false;
        return IsMovable(this._0x1b82a742(_0x556facac, _0x3e176aee)) && IsMovable(this._0x1b82a742(_0xebf07ac6, _0xbbe74db0));
    }

    public void _0x1f217b91(int _0x8364a6be)
    {
        this._0xa7d59229 = _0x8364a6be < 0 ? 0 : (_0x8364a6be > 3 ? 3 : _0x8364a6be);
    }

    public void _0x7b27b60d()
    {
        for (int _0x7a098220 = 0; _0x7a098220 < this._0xe6f2e5dd.Length; _0x7a098220++)
            this._0xe6f2e5dd[_0x7a098220] = CellInert;
    }

    /// <summary>The emitter lantern sits one cell outside the grid, behind the entry.</summary>
    public int _0xdb21a402(int _0x20f89553)
    {
        return this._0x5a4fc395[_0x20f89553] - DeltaX(this._0x236efb27[_0x20f89553]);
    }

    public int _0xf9ecab52
    {
        get
        {
            return this._0xa7d59229;
        }
    }

    private readonly int[] _0x236efb27 = new int[3];
    public int _0x8911045b(int _0x645d43fa)
    {
        return this._0x1d913d2b[_0x645d43fa];
    }

    public int _0x0cdf50a9(int _0x7d767b27)
    {
        return this._0x8b6922d7[_0x7d767b27];
    }

    public const int DirDown = 3;
    private int _0xa7d59229;
    public void _0x371305df(int[] _0xef30742b)
    {
        for (int _0x10411c97 = 0; _0x10411c97 < this._0xe6f2e5dd.Length && _0x10411c97 < _0xef30742b.Length; _0x10411c97++)
            this._0xe6f2e5dd[_0x10411c97] = _0xef30742b[_0x10411c97];
    }

    public int _0x1b82a742(int _0xff4eafab, int _0x049b71e7)
    {
        return Inside(_0xff4eafab, _0x049b71e7) ? this._0xe6f2e5dd[_0x049b71e7 * Cols + _0xff4eafab] : CellOnyx;
    }
}