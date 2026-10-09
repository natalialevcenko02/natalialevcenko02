/// <summary>
/// Builds a scheme CONSTRUCTIVELY: it traces a legal route for every beam first, so
/// the layout it ends up with IS a solution, then shuffles that solution apart by a
/// known number of swaps. There is no generate-and-reject loop, so solvability is a
/// property of the construction rather than something we hope a sampler finds, and
/// the player can always get home in at most `Depth` moves (rule C.11).
///
/// The random source is a seeded xorshift kept inside this class: the same
/// (scheme, attempt) pair yields the same board on every device and in the offline
/// simulation used to aim the review screenshots.
/// </summary>
public sealed class _0x0f439b88
{
    public static int SeedFor(int _0x9e7e0e58, int _0xc4c2b5bd)
    {
        return (_0x9e7e0e58 * 7919) ^ (_0xc4c2b5bd * 104729);
    }

    private bool _0x0f494037;
    private uint _0x4c241025()
    {
        uint _0x6ef60c4d = this._0x7c93272c;
        _0x6ef60c4d ^= _0x6ef60c4d << 13;
        _0x6ef60c4d ^= _0x6ef60c4d >> 17;
        _0x6ef60c4d ^= _0x6ef60c4d << 5;
        this._0x7c93272c = _0x6ef60c4d;
        return _0x6ef60c4d;
    }

    private const int BuildAttempts = 12;
    public void _0xd41f4e53(_0xdfdf0b34 _0xa0f475db, int _0x39ecd738, int _0x8222faba)
    {
        int _0xa31cd576 = _0x39ecd738 < 0 ? 0 : (_0x39ecd738 >= MaxSchemes ? MaxSchemes - 1 : _0x39ecd738);
        this._0x52323128 = DepthFor(_0xa31cd576);
        this._0xae77b8e4 = MovesFor(_0xa31cd576);
        this._0x0f494037 = false;
        this._0x62985078(SeedFor(_0xa31cd576, _0x8222faba));
        int _0x1dca7aa0 = ColoursFor(_0xa31cd576);
        int _0xfb8b2891 = BlockersFor(_0xa31cd576);
        _0xa0f475db._0x1f217b91(_0x1dca7aa0);
        bool _0xb31c4eea = false;
        for (int _0xff4ddc78 = 0; _0xff4ddc78 < BuildAttempts && !_0xb31c4eea; _0xff4ddc78++)
            _0xb31c4eea = this._0xc14a42a7(_0xa0f475db, _0x1dca7aa0, _0xfb8b2891);
        if (!_0xb31c4eea)
        {
            this._0x5a6ee170(_0xa0f475db);
            this._0x0f494037 = true;
        }

        this._0x9723c4b6(_0xa0f475db, 4 + this._0xc8e2344f(3));
        this._0x547e5370 = _0xa0f475db._0x7652d916();
        this._0x6f012ee4(_0xa0f475db, this._0x52323128);
    }

    public int _0xf3c2d0ba
    {
        get
        {
            return this._0xae77b8e4;
        }
    }

    private bool _0xce80aa19(_0xdfdf0b34 _0x91bba551)
    {
        int _0x43e85e60 = this._0xc8e2344f(_0xdfdf0b34.Cols);
        int _0x734d04a5 = this._0xc8e2344f(_0xdfdf0b34.Rows);
        int _0x191f0d7e = this._0xc8e2344f(4);
        int _0xb29f304a = _0x43e85e60 + _0xdfdf0b34.DeltaX(_0x191f0d7e);
        int _0x2e8eebc8 = _0x734d04a5 + _0xdfdf0b34.DeltaY(_0x191f0d7e);
        if (!_0x91bba551._0x4bb02775(_0x43e85e60, _0x734d04a5, _0xb29f304a, _0x2e8eebc8))
            return false;
        int _0x0130fe3d = _0x91bba551._0x1b82a742(_0x43e85e60, _0x734d04a5);
        int _0x1f3bdfbf = _0x91bba551._0x1b82a742(_0xb29f304a, _0x2e8eebc8);
        if (_0x0130fe3d == _0x1f3bdfbf)
            return false;
        if (!_0xdfdf0b34.IsMirror(_0x0130fe3d) && !_0xdfdf0b34.IsMirror(_0x1f3bdfbf))
            return false;
        _0x91bba551._0x87e02085(_0x43e85e60, _0x734d04a5, _0xb29f304a, _0x2e8eebc8);
        return true;
    }

    public bool _0xca26e228
    {
        get
        {
            return this._0x0f494037;
        }
    }

    private int _0xce7453c7(int _0x6add5422, int _0x2bdddbf9)
    {
        int _0x485160d6 = _0x6add5422 + 1;
        int _0x573bcd06 = _0x2bdddbf9 + 1;
        if (_0x485160d6 < 0 || _0x573bcd06 < 0 || _0x485160d6 >= _0xdfdf0b34.Cols + 2 || _0x573bcd06 >= _0xdfdf0b34.Rows + 2)
            return -1;
        return _0x573bcd06 * (_0xdfdf0b34.Cols + 2) + _0x485160d6;
    }

    private const int RouteAttempts = 40;
    /// <summary>
    /// Drops a few loose mirrors on cells NO beam crosses. They leave the solution
    /// intact (a beam never reaches them) but give the player more legal swaps and
    /// stop the board reading as 33 identical dull stones. After the shuffle they can
    /// drift into a beam path, which is honest puzzle content: reversing the shuffle
    /// still restores the recorded solution.
    /// </summary>
    private void _0x9723c4b6(_0xdfdf0b34 _0x6cdb163b, int _0x77a784a0)
    {
        int _0x5228a00d = _0xdfdf0b34.Cols * _0xdfdf0b34.Rows;
        bool[] _0x42f03679 = new bool[_0x5228a00d];
        for (int _0x6853bed8 = 0; _0x6853bed8 < _0x6cdb163b._0xf9ecab52; _0x6853bed8++)
        {
            this._0x2c101042._0x859c0a79(_0x6cdb163b, _0x6853bed8);
            for (int _0xe2ddd38d = 0; _0xe2ddd38d < this._0x2c101042._0x51799421.Count; _0xe2ddd38d++)
            {
                _0xfa8fa6c6.Segment _0x6b74be6f = this._0x2c101042._0x51799421[_0xe2ddd38d];
                _0x42f03679[_0x6b74be6f.Y * _0xdfdf0b34.Cols + _0x6b74be6f.X] = true;
            }
        }

        int _0x6a091c2b = 0;
        int _0xaaa991f2 = 240;
        while (_0x6a091c2b < _0x77a784a0 && _0xaaa991f2-- > 0)
        {
            int _0xe442cb9a = this._0xc8e2344f(_0xdfdf0b34.Cols);
            int _0x4a318e73 = this._0xc8e2344f(_0xdfdf0b34.Rows);
            int _0xcf7a6f0a = _0x4a318e73 * _0xdfdf0b34.Cols + _0xe442cb9a;
            if (_0x42f03679[_0xcf7a6f0a] || _0x6cdb163b._0x1b82a742(_0xe442cb9a, _0x4a318e73) != _0xdfdf0b34.CellInert)
                continue;
            int _0xacdd28ff = this._0xc8e2344f(2) == 0 ? _0xdfdf0b34.CellSlash : _0xdfdf0b34.CellBack;
            _0x6cdb163b._0xac68cb14(_0xe442cb9a, _0x4a318e73, _0xacdd28ff);
            if (_0xfa8fa6c6.AllBeamsLit(_0x6cdb163b, this._0x2c101042))
            {
                _0x42f03679[_0xcf7a6f0a] = true;
                _0x6a091c2b++;
            }
            else
            {
                _0x6cdb163b._0xac68cb14(_0xe442cb9a, _0x4a318e73, _0xdfdf0b34.CellInert);
            }
        }
    }

    private const int MinTurns = 2;
    private readonly _0xfa8fa6c6 _0x2c101042 = new _0xfa8fa6c6();
    private int _0xae77b8e4;
    private int _0xc8e2344f(int _0x83aed0b7)
    {
        if (_0x83aed0b7 <= 1)
            return 0;
        return (int)(this._0x4c241025() % (uint)_0x83aed0b7);
    }

    private bool _0xe92c871f(_0xdfdf0b34 _0x6ba29a05, int _0xe8f3834b, bool[] _0x67405949, bool[] _0x8c0abac0)
    {
        int _0x7db974c0 = _0xdfdf0b34.Cols * _0xdfdf0b34.Rows;
        for (int _0xca4b8bc3 = 0; _0xca4b8bc3 < RouteAttempts; _0xca4b8bc3++)
        {
            int _0xd00bca47 = this._0xc8e2344f(4);
            int _0x1b47303c = this._0xc8e2344f(_0xd00bca47 == _0xdfdf0b34.DirRight || _0xd00bca47 == _0xdfdf0b34.DirLeft ? _0xdfdf0b34.Rows : _0xdfdf0b34.Cols);
            int _0x586325db;
            int _0x5dd5d2a7;
            if (_0xd00bca47 == _0xdfdf0b34.DirRight)
            {
                _0x586325db = 0;
                _0x5dd5d2a7 = _0x1b47303c;
            }
            else if (_0xd00bca47 == _0xdfdf0b34.DirLeft)
            {
                _0x586325db = _0xdfdf0b34.Cols - 1;
                _0x5dd5d2a7 = _0x1b47303c;
            }
            else if (_0xd00bca47 == _0xdfdf0b34.DirUp)
            {
                _0x586325db = _0x1b47303c;
                _0x5dd5d2a7 = 0;
            }
            else
            {
                _0x586325db = _0x1b47303c;
                _0x5dd5d2a7 = _0xdfdf0b34.Rows - 1;
            }

            int _0xa6654bd6 = _0x586325db - _0xdfdf0b34.DeltaX(_0xd00bca47);
            int _0x4e25ad75 = _0x5dd5d2a7 - _0xdfdf0b34.DeltaY(_0xd00bca47);
            if (this._0x8a0101de(_0x8c0abac0, _0xa6654bd6, _0x4e25ad75))
                continue;
            int[] _0x02fad2a3 = new int[_0x7db974c0];
            bool[] _0xbdf86828 = new bool[_0x7db974c0];
            for (int _0xb7763824 = 0; _0xb7763824 < _0x7db974c0; _0xb7763824++)
                _0x02fad2a3[_0xb7763824] = -1;
            int _0x399dc2b0 = 0;
            int _0x12f6e921 = MinTurns + this._0xc8e2344f(3);
            int _0x5c3f5095 = _0x586325db;
            int _0x544e1ab1 = _0x5dd5d2a7;
            int _0x950f3603 = _0xd00bca47;
            bool _0xe91d364b = false;
            bool _0xffa1fe8e = false;
            int _0xae327880 = _0x7db974c0 * 4 + 4;
            while (_0xae327880-- > 0)
            {
                if (!_0xdfdf0b34.Inside(_0x5c3f5095, _0x544e1ab1))
                {
                    _0xe91d364b = true;
                    break;
                }

                int _0x07623c89 = _0x544e1ab1 * _0xdfdf0b34.Cols + _0x5c3f5095;
                int _0x69c685c8 = _0x02fad2a3[_0x07623c89] >= 0 ? _0x02fad2a3[_0x07623c89] : _0x6ba29a05._0x1b82a742(_0x5c3f5095, _0x544e1ab1);
                if (_0x69c685c8 == _0xdfdf0b34.CellOnyx)
                {
                    _0xffa1fe8e = true;
                    break;
                }

                if (_0xdfdf0b34.IsMirror(_0x69c685c8))
                {
                    _0x950f3603 = _0xdfdf0b34.Deflect(_0x69c685c8, _0x950f3603);
                    _0x399dc2b0++;
                }
                else
                {
                    bool _0xa37b94c6 = !_0x67405949[_0x07623c89] && !_0xbdf86828[_0x07623c89] && _0x69c685c8 == _0xdfdf0b34.CellInert;
                    bool _0x6ef0c85d = _0x399dc2b0 < _0x12f6e921 && this._0xc8e2344f(100) < 55;
                    if (_0xa37b94c6 && _0x6ef0c85d)
                    {
                        int _0xaa759c2c = this._0xc8e2344f(2) == 0 ? _0xdfdf0b34.CellSlash : _0xdfdf0b34.CellBack;
                        _0x02fad2a3[_0x07623c89] = _0xaa759c2c;
                        _0x950f3603 = _0xdfdf0b34.Deflect(_0xaa759c2c, _0x950f3603);
                        _0x399dc2b0++;
                    }
                    else
                    {
                        _0xbdf86828[_0x07623c89] = true;
                    }
                }

                _0x5c3f5095 += _0xdfdf0b34.DeltaX(_0x950f3603);
                _0x544e1ab1 += _0xdfdf0b34.DeltaY(_0x950f3603);
            }

            if (_0xffa1fe8e || !_0xe91d364b || _0x399dc2b0 < MinTurns)
                continue;
            if (this._0x8a0101de(_0x8c0abac0, _0x5c3f5095, _0x544e1ab1))
                continue;
            // Commit, then prove every beam routed so far still reaches its facet -
            // a later route may legally pass through an earlier route's mirror.
            int[] _0x1a4fbcdd = _0x6ba29a05._0x7652d916();
            for (int _0xa52da705 = 0; _0xa52da705 < _0x7db974c0; _0xa52da705++)
                if (_0x02fad2a3[_0xa52da705] >= 0)
                    _0x6ba29a05._0xac68cb14(_0xa52da705 % _0xdfdf0b34.Cols, _0xa52da705 / _0xdfdf0b34.Cols, _0x02fad2a3[_0xa52da705]);
            _0x6ba29a05._0x76eb1f72(_0xe8f3834b, _0x586325db, _0x5dd5d2a7, _0xd00bca47, _0x5c3f5095, _0x544e1ab1);
            bool _0x5a507177 = true;
            for (int _0xd7587187 = 0; _0xd7587187 <= _0xe8f3834b && _0x5a507177; _0xd7587187++)
            {
                this._0x2c101042._0x859c0a79(_0x6ba29a05, _0xd7587187);
                _0x5a507177 = this._0x2c101042._0xa82f55f0(_0x6ba29a05, _0xd7587187);
            }

            if (!_0x5a507177)
            {
                _0x6ba29a05._0x371305df(_0x1a4fbcdd);
                continue;
            }

            for (int _0xb5399654 = 0; _0xb5399654 < _0x7db974c0; _0xb5399654++)
                if (_0xbdf86828[_0xb5399654])
                    _0x67405949[_0xb5399654] = true;
            this._0x22d51819(_0x8c0abac0, _0xa6654bd6, _0x4e25ad75);
            this._0x22d51819(_0x8c0abac0, _0x5c3f5095, _0x544e1ab1);
            return true;
        }

        return false;
    }

    private void _0x22d51819(bool[] _0x135c51d1, int _0x2746d99c, int _0x0c4f4187)
    {
        int _0x0d57c6b7 = this._0xce7453c7(_0x2746d99c, _0x0c4f4187);
        if (_0x0d57c6b7 >= 0)
            _0x135c51d1[_0x0d57c6b7] = true;
    }

    private uint _0x7c93272c;
    private int _0x52323128;
    public static int DepthFor(int _0xb305c23c)
    {
        if (_0xb305c23c <= 0)
            return 1;
        if (_0xb305c23c <= 1)
            return 2;
        if (_0xb305c23c <= 2)
            return 3;
        if (_0xb305c23c <= 3)
            return 4;
        if (_0xb305c23c <= 5)
            return 5;
        if (_0xb305c23c <= 8)
            return 6;
        return 7;
    }

    // ── fallback (only if construction somehow cannot close) ────────────────
    private void _0x5a6ee170(_0xdfdf0b34 _0x845c662f)
    {
        _0x845c662f._0x7b27b60d();
        _0x845c662f._0x1f217b91(2);
        _0x845c662f._0xac68cb14(3, 3, _0xdfdf0b34.CellSlash);
        _0x845c662f._0xac68cb14(4, 1, _0xdfdf0b34.CellBack);
        _0x845c662f._0x76eb1f72(0, 0, 3, _0xdfdf0b34.DirRight, 3, _0xdfdf0b34.Rows);
        _0x845c662f._0x76eb1f72(1, 0, 1, _0xdfdf0b34.DirRight, 4, -1);
    }

    private int[] _0x547e5370;
    // ── layout ──────────────────────────────────────────────────────────────
    private bool _0xc14a42a7(_0xdfdf0b34 _0x1ccdb92b, int _0x39b5d5bd, int _0xac4106ce)
    {
        _0x1ccdb92b._0x7b27b60d();
        int _0xda9ad962 = _0xdfdf0b34.Cols * _0xdfdf0b34.Rows;
        bool[] _0x2442b980 = new bool[_0xda9ad962];
        bool[] _0x735dbb30 = new bool[(_0xdfdf0b34.Cols + 2) * (_0xdfdf0b34.Rows + 2)];
        // Blockers go in the middle band so they never sit on an edge lane and make
        // half the entry points useless.
        int _0xf0927215 = 0;
        int _0x98ab9163 = 200;
        while (_0xf0927215 < _0xac4106ce && _0x98ab9163-- > 0)
        {
            int _0xe2c3a3eb = 1 + this._0xc8e2344f(_0xdfdf0b34.Cols - 2);
            int _0xed47a8cc = 1 + this._0xc8e2344f(_0xdfdf0b34.Rows - 2);
            if (_0x1ccdb92b._0x1b82a742(_0xe2c3a3eb, _0xed47a8cc) != _0xdfdf0b34.CellInert)
                continue;
            _0x1ccdb92b._0xac68cb14(_0xe2c3a3eb, _0xed47a8cc, _0xdfdf0b34.CellOnyx);
            _0xf0927215++;
        }

        for (int _0x02579e4a = 0; _0x02579e4a < _0x39b5d5bd; _0x02579e4a++)
            if (!this._0xe92c871f(_0x1ccdb92b, _0x02579e4a, _0x2442b980, _0x735dbb30))
                return false;
        return _0xfa8fa6c6.AllBeamsLit(_0x1ccdb92b, this._0x2c101042);
    }

    /// <summary>The solved layout this scheme was shuffled away from.</summary>
    public int[] _0x132550d1
    {
        get
        {
            return this._0x547e5370;
        }
    }

    public static int ColoursFor(int _0xc33b651b)
    {
        return _0xc33b651b <= 0 ? 2 : 3;
    }

    public static int BlockersFor(int _0x752e0ca9)
    {
        if (_0x752e0ca9 <= 1)
            return 0;
        if (_0x752e0ca9 <= 3)
            return 1;
        if (_0x752e0ca9 <= 5)
            return 2;
        if (_0x752e0ca9 <= 8)
            return 3;
        return 4;
    }

    // ── deterministic random ────────────────────────────────────────────────
    private void _0x62985078(int _0x947e635c)
    {
        uint _0xc22cd959 = (uint)_0x947e635c;
        this._0x7c93272c = _0xc22cd959 == 0u ? 2463534242u : _0xc22cd959;
    }

    public static int MovesFor(int _0x6b7666b2)
    {
        return DepthFor(_0x6b7666b2) + 2 + _0x6b7666b2 / 2;
    }

    private const int MaxSchemes = 12;
    public static int _0x65132f1c
    {
        get
        {
            return MaxSchemes;
        }
    }

    // ── shuffle ─────────────────────────────────────────────────────────────
    private void _0x6f012ee4(_0xdfdf0b34 _0xbff02ae6, int _0xc1733f57)
    {
        int _0xe3297425 = 0;
        int _0x5d4260a8 = 600;
        while (_0xe3297425 < _0xc1733f57 && _0x5d4260a8-- > 0)
            if (this._0xce80aa19(_0xbff02ae6))
                _0xe3297425++;
        // Never hand the player a board that is already solved.
        _0x5d4260a8 = 200;
        while (_0x5d4260a8-- > 0 && _0xfa8fa6c6.AllBeamsLit(_0xbff02ae6, this._0x2c101042))
            this._0xce80aa19(_0xbff02ae6);
    }

    private bool _0x8a0101de(bool[] _0x4ca90bda, int _0xe7be0012, int _0x64cde158)
    {
        int _0xdb17b006 = this._0xce7453c7(_0xe7be0012, _0x64cde158);
        return _0xdb17b006 < 0 || _0x4ca90bda[_0xdb17b006];
    }

    public int _0x99d70463
    {
        get
        {
            return this._0x52323128;
        }
    }
}