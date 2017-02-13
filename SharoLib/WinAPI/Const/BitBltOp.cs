﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinAPI.Const
{
    public enum BitBltOp : uint
    {
        SRCCOPY = 13369376u,
        SRCPAINT = 15597702u,
        SRCAND = 8913094u,
        SRCINVERT = 6684742u,
        SRCERASE = 4457256u,
        NOTSRCCOPY = 3342344u,
        NOTSRCERASE = 1114278u,
        MERGECOPY = 12583114u,
        MERGEPAINT = 12255782u,
        PATCOPY = 15728673u,
        PATPAINT = 16452105u,
        PATINVERT = 5898313u,
        DSTINVERT = 5570569u,
        BLACKNESS = 66u,
        WHITENESS = 16711778u,
        NOMIRRORBITMAP = 2147483648u,
        CAPTUREBLT = 1073741824u
    }
}
