﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAPI.Const
{
    public enum WM : int
    {
        // Window Message
        WM_ACTIVATE = 0x0006,
        WM_ACTIVATEAPP = 0x001C,
        WM_AFXFIRST = 0x0360,
        WM_AFXLAST = 0x037F,
        WM_APP = 0x8000,
        WM_ASKCBFORMATNAME = 0x030C,
        WM_CANCELJOURNAL = 0x004B,
        WM_CANCELMODE = 0x001F,
        WM_CAPTURECHANGED = 0x0215,
        WM_CHANGECBCHAIN = 0x030D,
        WM_CHANGEUISTATE = 0x0127,
        WM_CHAR = 0x0102,
        WM_CHARTOITEM = 0x002F,
        WM_CHILDACTIVATE = 0x0022,
        WM_CLEAR = 0x0303,
        WM_CLOSE = 0x0010,
        WM_COMMAND = 0x0111,
        WM_COMPACTING = 0x0041,
        WM_COMPAREITEM = 0x0039,
        WM_CONTEXTMENU = 0x007B,
        WM_COPY = 0x0301,
        WM_COPYDATA = 0x004A,
        WM_CREATE = 0x0001,
        WM_CTLCOLORBTN = 0x0135,
        WM_CTLCOLORDLG = 0x0136,
        WM_CTLCOLOREDIT = 0x0133,
        WM_CTLCOLORLISTBOX = 0x0134,
        WM_CTLCOLORMSGBOX = 0x0132,
        WM_CTLCOLORSCROLLBAR = 0x0137,
        WM_CTLCOLORSTATIC = 0x0138,
        WM_CUT = 0x0300,
        WM_DEADCHAR = 0x0103,
        WM_DELETEITEM = 0x002D,
        WM_DESTROY = 0x0002,
        WM_DESTROYCLIPBOARD = 0x0307,
        WM_DEVICECHANGE = 0x0219,
        WM_DEVMODECHANGE = 0x001B,
        WM_DISPLAYCHANGE = 0x007E,
        WM_DRAWCLIPBOARD = 0x0308,
        WM_DRAWITEM = 0x002B,
        WM_DROPFILES = 0x0233,
        WM_ENABLE = 0x000A,
        WM_ENDSESSION = 0x0016,
        WM_ENTERIDLE = 0x0121,
        WM_ENTERMENULOOP = 0x0211,
        WM_ENTERSIZEMOVE = 0x0231,
        WM_ERASEBKGND = 0x0014,
        WM_EXITMENULOOP = 0x0212,
        WM_EXITSIZEMOVE = 0x0232,
        WM_FONTCHANGE = 0x001D,
        WM_GETDLGCODE = 0x0087,
        WM_GETFONT = 0x0031,
        WM_GETHOTKEY = 0x0033,
        WM_GETICON = 0x007F,
        WM_GETMINMAXINFO = 0x0024,
        WM_GETOBJECT = 0x003D,
        WM_GETTEXT = 0x000D,
        WM_GETTEXTLENGTH = 0x000E,
        WM_HANDHELDFIRST = 0x0358,
        WM_HANDHELDLAST = 0x035F,
        WM_HELP = 0x0053,
        WM_HOTKEY = 0x0312,
        WM_HSCROLL = 0x0114,
        WM_HSCROLLCLIPBOARD = 0x030E,
        WM_ICONERASEBKGND = 0x0027,
        WM_IME_CHAR = 0x0286,
        WM_IME_COMPOSITION = 0x010F,
        WM_IME_COMPOSITIONFULL = 0x0284,
        WM_IME_CONTROL = 0x0283,
        WM_IME_ENDCOMPOSITION = 0x010E,
        WM_IME_KEYDOWN = 0x0290,
        WM_IME_KEYLAST = 0x010F,
        WM_IME_KEYUP = 0x0291,
        WM_IME_NOTIFY = 0x0282,
        WM_IME_REQUEST = 0x0288,
        WM_IME_SELECT = 0x0285,
        WM_IME_SETCONTEXT = 0x0281,
        WM_IME_STARTCOMPOSITION = 0x010D,
        WM_INITDIALOG = 0x0110,
        WM_INITMENU = 0x0116,
        WM_INITMENUPOPUP = 0x0117,
        WM_INPUTLANGCHANGE = 0x0051,
        WM_INPUTLANGCHANGEREQUEST = 0x0050,
        WM_KEYDOWN = 0x0100,
        WM_KEYFIRST = 0x0100,
        WM_KEYLAST = 0x0108,
        WM_KEYUP = 0x0101,
        WM_KILLFOCUS = 0x0008,
        WM_LBUTTONDBLCLK = 0x0203,
        WM_LBUTTONDOWN = 0x0201,
        WM_LBUTTONUP = 0x0202,
        WM_MBUTTONDBLCLK = 0x0209,
        WM_MBUTTONDOWN = 0x0207,
        WM_MBUTTONUP = 0x0208,
        WM_MDIACTIVATE = 0x0222,
        WM_MDICASCADE = 0x0227,
        WM_MDICREATE = 0x0220,
        WM_MDIDESTROY = 0x0221,
        WM_MDIGETACTIVE = 0x0229,
        WM_MDIICONARRANGE = 0x0228,
        WM_MDIMAXIMIZE = 0x0225,
        WM_MDINEXT = 0x0224,
        WM_MDIREFRESHMENU = 0x0234,
        WM_MDIRESTORE = 0x0223,
        WM_MDISETMENU = 0x0230,
        WM_MDITILE = 0x0226,
        WM_MEASUREITEM = 0x002C,
        WM_MENUCHAR = 0x0120,
        WM_MENUCOMMAND = 0x0126,
        WM_MENUDRAG = 0x0123,
        WM_MENUGETOBJECT = 0x0124,
        WM_MENURBUTTONUP = 0x0122,
        WM_MENUSELECT = 0x011F,
        WM_MOUSEACTIVATE = 0x0021,
        WM_MOUSEFIRST = 0x0200,
        WM_MOUSEHOVER = 0x02A1,
        WM_MOUSELAST = 0x020D,
        WM_MOUSELEAVE = 0x02A3,
        WM_MOUSEMOVE = 0x0200,
        WM_MOUSEWHEEL = 0x020A,
        WM_MOUSEHWHEEL = 0x020E,
        WM_MOVE = 0x0003,
        WM_MOVING = 0x0216,
        WM_NCACTIVATE = 0x0086,
        WM_NCCALCSIZE = 0x0083,
        WM_NCCREATE = 0x0081,
        WM_NCDESTROY = 0x0082,
        WM_NCHITTEST = 0x0084,
        WM_NCLBUTTONDBLCLK = 0x00A3,
        WM_NCLBUTTONDOWN = 0x00A1,
        WM_NCLBUTTONUP = 0x00A2,
        WM_NCMBUTTONDBLCLK = 0x00A9,
        WM_NCMBUTTONDOWN = 0x00A7,
        WM_NCMBUTTONUP = 0x00A8,
        WM_NCMOUSEHOVER = 0x02A0,
        WM_NCMOUSELEAVE = 0x02A2,
        WM_NCMOUSEMOVE = 0x00A0,
        WM_NCPAINT = 0x0085,
        WM_NCRBUTTONDBLCLK = 0x00A6,
        WM_NCRBUTTONDOWN = 0x00A4,
        WM_NCRBUTTONUP = 0x00A5,
        WM_NCXBUTTONDBLCLK = 0x00AD,
        WM_NCXBUTTONDOWN = 0x00AB,
        WM_NCXBUTTONUP = 0x00AC,
        WM_NCUAHDRAWCAPTION = 0x00AE,
        WM_NCUAHDRAWFRAME = 0x00AF,
        WM_NEXTDLGCTL = 0x0028,
        WM_NEXTMENU = 0x0213,
        WM_NOTIFY = 0x004E,
        WM_NOTIFYFORMAT = 0x0055,
        WM_NULL = 0x0000,
        WM_PAINT = 0x000F,
        WM_PAINTCLIPBOARD = 0x0309,
        WM_PAINTICON = 0x0026,
        WM_PALETTECHANGED = 0x0311,
        WM_PALETTEISCHANGING = 0x0310,
        WM_PARENTNOTIFY = 0x0210,
        WM_PASTE = 0x0302,
        WM_PENWINFIRST = 0x0380,
        WM_PENWINLAST = 0x038F,
        WM_POWER = 0x0048,
        WM_POWERBROADCAST = 0x0218,
        WM_PRINT = 0x0317,
        WM_PRINTCLIENT = 0x0318,
        WM_QUERYDRAGICON = 0x0037,
        WM_QUERYENDSESSION = 0x0011,
        WM_QUERYNEWPALETTE = 0x030F,
        WM_QUERYOPEN = 0x0013,
        WM_QUEUESYNC = 0x0023,
        WM_QUIT = 0x0012,
        WM_RBUTTONDBLCLK = 0x0206,
        WM_RBUTTONDOWN = 0x0204,
        WM_RBUTTONUP = 0x0205,
        WM_RENDERALLFORMATS = 0x0306,
        WM_RENDERFORMAT = 0x0305,
        WM_SETCURSOR = 0x0020,
        WM_SETFOCUS = 0x0007,
        WM_SETFONT = 0x0030,
        WM_SETHOTKEY = 0x0032,
        WM_SETICON = 0x0080,
        WM_SETREDRAW = 0x000B,
        WM_SETTEXT = 0x000C,
        WM_SETTINGCHANGE = 0x001A,
        WM_SHOWWINDOW = 0x0018,
        WM_SIZE = 0x0005,
        WM_SIZECLIPBOARD = 0x030B,
        WM_SIZING = 0x0214,
        WM_SPOOLERSTATUS = 0x002A,
        WM_STYLECHANGED = 0x007D,
        WM_STYLECHANGING = 0x007C,
        WM_SYNCPAINT = 0x0088,
        WM_SYSCHAR = 0x0106,
        WM_SYSCOLORCHANGE = 0x0015,
        WM_SYSCOMMAND = 0x0112,
        WM_SYSDEADCHAR = 0x0107,
        WM_SYSKEYDOWN = 0x0104,
        WM_SYSKEYUP = 0x0105,
        WM_TCARD = 0x0052,
        WM_TIMECHANGE = 0x001E,
        WM_TIMER = 0x0113,
        WM_UNDO = 0x0304,
        WM_UNINITMENUPOPUP = 0x0125,
        WM_USER = 0x0400,
        WM_USERCHANGED = 0x0054,
        WM_VKEYTOITEM = 0x002E,
        WM_VSCROLL = 0x0115,
        WM_VSCROLLCLIPBOARD = 0x030A,
        WM_WINDOWPOSCHANGED = 0x0047,
        WM_WINDOWPOSCHANGING = 0x0046,
        WM_WININICHANGE = 0x001A,
        WM_XBUTTONDBLCLK = 0x020D,
        WM_XBUTTONDOWN = 0x020B,
        WM_XBUTTONUP = 0x020C,
        WM_TOUCH = 0x240,

        WM_DWMCOMPOSITIONCHANGED = 0x031E,
        WM_DWMNCRENDERINGCHANGED = 0x031F,
        WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320,
        WM_DWMWINDOWMAXIMIZEDCHANGE = 0x0321,


        WM_NCPOINTERUPDATE = 0x0241,
        WM_NCPOINTERDOWN = 0x0242,
        WM_NCPOINTERUP = 0x0243,
        WM_POINTERUPDATE = 0x0245,
        WM_POINTERDOWN = 0x0246,
        WM_POINTERUP = 0x0247,
        WM_POINTERENTER = 0x0249,
        WM_POINTERLEAVE = 0x024A,
        WM_POINTERACTIVATE = 0x024B,
        WM_POINTERCAPTURECHANGED = 0x024C,
        WM_TOUCHHITTESTING = 0x024D,
        WM_POINTERWHEEL = 0x024E,
        WM_POINTERHWHEEL = 0x024F,

        // ステータスバー
        SB_GETPARTS = 0x0406,
        SB_GETTEXT = 0x0402,
        SB_SETPARTS = 0x0404,
        SB_SETTEXT = 0x0401,
        SB_SIMPLE = 0x0409,

        // LVM
        LVM_FIRST = 0x1000,
        LVM_SETUNICODEFORMAT = 0x2005,
        LVM_GETUNICODEFORMAT = 0x2006,
        LVM_GETBKCOLOR = (LVM_FIRST + 0),
        LVM_SETBKCOLOR = (LVM_FIRST + 1),
        LVM_GETIMAGELIST = (LVM_FIRST + 2),
        LVM_SETIMAGELIST = (LVM_FIRST + 3),
        LVM_GETITEMCOUNT = (LVM_FIRST + 4),
        LVM_GETITEMA = (LVM_FIRST + 5),
        LVM_GETITEMW = (LVM_FIRST + 75),
        LVM_GETITEM = LVM_GETITEMW,
        LVM_SETITEMA = (LVM_FIRST + 6),
        LVM_SETITEMW = (LVM_FIRST + 76),
        LVM_SETITEM = LVM_SETITEMW,
        LVM_INSERTITEMA = (LVM_FIRST + 7),
        LVM_INSERTITEMW = (LVM_FIRST + 77),
        LVM_INSERTITEM = LVM_INSERTITEMW,
        LVM_DELETEITEM = (LVM_FIRST + 8),
        LVM_DELETEALLITEMS = (LVM_FIRST + 9),
        LVM_GETCALLBACKMASK = (LVM_FIRST + 10),
        LVM_SETCALLBACKMASK = (LVM_FIRST + 11),
        LVM_GETNEXTITEM = (LVM_FIRST + 12),
        LVM_FINDITEMA = (LVM_FIRST + 13),
        LVM_FINDITEMW = (LVM_FIRST + 83),
        LVM_GETITEMRECT = (LVM_FIRST + 14),
        LVM_SETITEMPOSITION = (LVM_FIRST + 15),
        LVM_GETITEMPOSITION = (LVM_FIRST + 16),
        LVM_GETSTRINGWIDTHA = (LVM_FIRST + 17),
        LVM_GETSTRINGWIDTHW = (LVM_FIRST + 87),
        LVM_HITTEST = (LVM_FIRST + 18),
        LVM_ENSUREVISIBLE = (LVM_FIRST + 19),
        LVM_SCROLL = (LVM_FIRST + 20),
        LVM_REDRAWITEMS = (LVM_FIRST + 21),
        LVM_ARRANGE = (LVM_FIRST + 22),
        LVM_EDITLABELA = (LVM_FIRST + 23),
        LVM_EDITLABELW = (LVM_FIRST + 118),
        LVM_EDITLABEL = LVM_EDITLABELW,
        LVM_GETEDITCONTROL = (LVM_FIRST + 24),
        LVM_GETCOLUMNA = (LVM_FIRST + 25),
        LVM_GETCOLUMNW = (LVM_FIRST + 95),
        LVM_SETCOLUMNA = (LVM_FIRST + 26),
        LVM_SETCOLUMNW = (LVM_FIRST + 96),
        LVM_INSERTCOLUMNA = (LVM_FIRST + 27),
        LVM_INSERTCOLUMNW = (LVM_FIRST + 97),
        LVM_DELETECOLUMN = (LVM_FIRST + 28),
        LVM_GETCOLUMNWIDTH = (LVM_FIRST + 29),
        LVM_SETCOLUMNWIDTH = (LVM_FIRST + 30),
        LVM_GETHEADER = (LVM_FIRST + 31),
        LVM_CREATEDRAGIMAGE = (LVM_FIRST + 33),
        LVM_GETVIEWRECT = (LVM_FIRST + 34),
        LVM_GETTEXTCOLOR = (LVM_FIRST + 35),
        LVM_SETTEXTCOLOR = (LVM_FIRST + 36),
        LVM_GETTEXTBKCOLOR = (LVM_FIRST + 37),
        LVM_SETTEXTBKCOLOR = (LVM_FIRST + 38),
        LVM_GETTOPINDEX = (LVM_FIRST + 39),
        LVM_GETCOUNTPERPAGE = (LVM_FIRST + 40),
        LVM_GETORIGIN = (LVM_FIRST + 41),
        LVM_UPDATE = (LVM_FIRST + 42),
        LVM_SETITEMSTATE = (LVM_FIRST + 43),
        LVM_GETITEMSTATE = (LVM_FIRST + 44),
        LVM_GETITEMTEXTA = (LVM_FIRST + 45),
        LVM_GETITEMTEXTW = (LVM_FIRST + 115),
        LVM_SETITEMTEXTA = (LVM_FIRST + 46),
        LVM_SETITEMTEXTW = (LVM_FIRST + 116),
        LVM_SETITEMCOUNT = (LVM_FIRST + 47),
        LVM_SORTITEMS = (LVM_FIRST + 48),
        LVM_SETITEMPOSITION32 = (LVM_FIRST + 49),
        LVM_GETSELECTEDCOUNT = (LVM_FIRST + 50),
        LVM_GETITEMSPACING = (LVM_FIRST + 51),
        LVM_GETISEARCHSTRINGA = (LVM_FIRST + 52),
        LVM_GETISEARCHSTRINGW = (LVM_FIRST + 117),
        LVM_GETISEARCHSTRING = LVM_GETISEARCHSTRINGW,
        LVM_SETICONSPACING = (LVM_FIRST + 53),
        LVM_SETEXTENDEDLISTVIEWSTYLE = (LVM_FIRST + 54),
        LVM_GETEXTENDEDLISTVIEWSTYLE = (LVM_FIRST + 55),
        LVM_GETSUBITEMRECT = (LVM_FIRST + 56),
        LVM_SUBITEMHITTEST = (LVM_FIRST + 57),
        LVM_SETCOLUMNORDERARRAY = (LVM_FIRST + 58),
        LVM_GETCOLUMNORDERARRAY = (LVM_FIRST + 59),
        LVM_SETHOTITEM = (LVM_FIRST + 60),
        LVM_GETHOTITEM = (LVM_FIRST + 61),
        LVM_SETHOTCURSOR = (LVM_FIRST + 62),
        LVM_GETHOTCURSOR = (LVM_FIRST + 63),
        LVM_APPROXIMATEVIEWRECT = (LVM_FIRST + 64),
        LVM_SETWORKAREAS = (LVM_FIRST + 65),
        LVM_GETWORKAREAS = (LVM_FIRST + 70),
        LVM_GETNUMBEROFWORKAREAS = (LVM_FIRST + 73),
        LVM_GETSELECTIONMARK = (LVM_FIRST + 66),
        LVM_SETSELECTIONMARK = (LVM_FIRST + 67),
        LVM_SETHOVERTIME = (LVM_FIRST + 71),
        LVM_GETHOVERTIME = (LVM_FIRST + 72),
        LVM_SETTOOLTIPS = (LVM_FIRST + 74),
        LVM_GETTOOLTIPS = (LVM_FIRST + 78),
        LVM_SORTITEMSEX = (LVM_FIRST + 81),
        LVM_SETBKIMAGEA = (LVM_FIRST + 68),
        LVM_SETBKIMAGEW = (LVM_FIRST + 138),
        LVM_GETBKIMAGEA = (LVM_FIRST + 69),
        LVM_GETBKIMAGEW = (LVM_FIRST + 139),
        LVM_SETSELECTEDCOLUMN = (LVM_FIRST + 140),
        LVM_SETVIEW = (LVM_FIRST + 142),
        LVM_GETVIEW = (LVM_FIRST + 143),
        LVM_INSERTGROUP = (LVM_FIRST + 145),
        LVM_SETGROUPINFO = (LVM_FIRST + 147),
        LVM_GETGROUPINFO = (LVM_FIRST + 149),
        LVM_REMOVEGROUP = (LVM_FIRST + 150),
        LVM_MOVEGROUP = (LVM_FIRST + 151),
        LVM_GETGROUPCOUNT = (LVM_FIRST + 152),
        LVM_GETGROUPINFOBYINDEX = (LVM_FIRST + 153),
        LVM_MOVEITEMTOGROUP = (LVM_FIRST + 154),
        LVM_GETGROUPRECT = (LVM_FIRST + 98),
        LVM_SETGROUPMETRICS = (LVM_FIRST + 155),
        LVM_GETGROUPMETRICS = (LVM_FIRST + 156),
        LVM_ENABLEGROUPVIEW = (LVM_FIRST + 157),
        LVM_SORTGROUPS = (LVM_FIRST + 158),
        LVM_INSERTGROUPSORTED = (LVM_FIRST + 159),
        LVM_REMOVEALLGROUPS = (LVM_FIRST + 160),
        LVM_HASGROUP = (LVM_FIRST + 161),
        LVM_GETGROUPSTATE = (LVM_FIRST + 92),
        LVM_GETFOCUSEDGROUP = (LVM_FIRST + 93),
        LVM_SETTILEVIEWINFO = (LVM_FIRST + 162),
        LVM_GETTILEVIEWINFO = (LVM_FIRST + 163),
        LVM_SETTILEINFO = (LVM_FIRST + 164),
        LVM_GETTILEINFO = (LVM_FIRST + 165),
        LVM_SETINSERTMARK = (LVM_FIRST + 166),
        LVM_GETINSERTMARK = (LVM_FIRST + 167),
        LVM_INSERTMARKHITTEST = (LVM_FIRST + 168),
        LVM_GETINSERTMARKRECT = (LVM_FIRST + 169),
        LVM_SETINSERTMARKCOLOR = (LVM_FIRST + 170),
        LVM_GETINSERTMARKCOLOR = (LVM_FIRST + 171),
        LVM_GETSELECTEDCOLUMN = (LVM_FIRST + 174),
        LVM_ISGROUPVIEWENABLED = (LVM_FIRST + 175),
        LVM_GETOUTLINECOLOR = (LVM_FIRST + 176),
        LVM_SETOUTLINECOLOR = (LVM_FIRST + 177),
        LVM_CANCELEDITLABEL = (LVM_FIRST + 179),
        LVM_MAPINDEXTOID = (LVM_FIRST + 180),
        LVM_MAPIDTOINDEX = (LVM_FIRST + 181),
        LVM_ISITEMVISIBLE = (LVM_FIRST + 182),
        LVM_GETACCVERSION = (LVM_FIRST + 193),
        LVM_GETEMPTYTEXT = (LVM_FIRST + 204),
        LVM_GETFOOTERRECT = (LVM_FIRST + 205),
        LVM_GETFOOTERINFO = (LVM_FIRST + 206),
        LVM_GETFOOTERITEMRECT = (LVM_FIRST + 207),
        LVM_GETFOOTERITEM = (LVM_FIRST + 208),
        LVM_GETITEMINDEXRECT = (LVM_FIRST + 209),
        LVM_SETITEMINDEXSTATE = (LVM_FIRST + 210),
        LVM_GETNEXTITEMINDEX = (LVM_FIRST + 211),
        LVM_SETPRESERVEALPHA = (LVM_FIRST + 212),
        LVM_SETBKIMAGE = LVM_SETBKIMAGEW,
        LVM_GETBKIMAGE = LVM_GETBKIMAGEW,

        // TVM
        TVM_DELETEITEM = 0x1101,
        TVM_EXPAND = 0x1102,
        TVM_GETBKCOLOR = 0x111F,
        TVM_GETCOUNT = 0x1105,
        TVM_GETITEM = 0x110C,
        TVM_GETNEXTITEM = 0x110A,
        TVM_GETTEXTCOLOR = 0x1120,
        TVM_GETVISIBLECOUNT = 0x1110,
        TVM_INSERTITEM = 0x1100,
        TVM_SETIMAGELIST = 0x1109,
        TVM_SETITEM = 0x110D,
        TVM_SORTCHILDREN = 0x1113,

        // TCM
        TCM_FIRST = 0x1300,
        TCM_GETIMAGELIST = (TCM_FIRST + 2),
        TCM_SETIMAGELIST = (TCM_FIRST + 3),
        TCM_GETITEMCOUNT = (TCM_FIRST + 4),
        TCM_GETITEMA = (TCM_FIRST + 5),
        TCM_GETITEMW = (TCM_FIRST + 60),
        TCM_SETITEMA = (TCM_FIRST + 6),
        TCM_SETITEMW = (TCM_FIRST + 61),
        TCM_INSERTITEMA = (TCM_FIRST + 7),
        TCM_INSERTITEMW = (TCM_FIRST + 62),
        TCM_DELETEITEM = (TCM_FIRST + 8),
        TCM_DELETEALLITEMS = (TCM_FIRST + 9),
        TCM_GETITEMRECT = (TCM_FIRST + 10),
        TCM_GETCURSEL = (TCM_FIRST + 11),
        TCM_SETCURSEL = (TCM_FIRST + 12),
        TCM_HITTEST = (TCM_FIRST + 13),
        TCM_SETITEMEXTRA = (TCM_FIRST + 14),
        TCM_ADJUSTRECT = (TCM_FIRST + 40),
        TCM_SETITEMSIZE = (TCM_FIRST + 41),
        TCM_REMOVEIMAGE = (TCM_FIRST + 42),
        TCM_SETPADDING = (TCM_FIRST + 43),
        TCM_GETROWCOUNT = (TCM_FIRST + 44),
        TCM_GETCURFOCUS = (TCM_FIRST + 47),
        TCM_SETCURFOCUS = (TCM_FIRST + 48),
        TCM_SETMINTABWIDTH = (TCM_FIRST + 49),
        TCM_DESELECTALL = (TCM_FIRST + 50),
        TCM_HIGHLIGHTITEM = (TCM_FIRST + 51),
        TCM_SETEXTENDEDSTYLE = (TCM_FIRST + 52),
        TCM_GETEXTENDEDSTYLE = (TCM_FIRST + 53),

        // UDM
        UDM_GETPOS = 0x0468,
        UDM_GETPOS32 = 0x0472,
        UDM_SETBUDDY = 0x0469,
        UDM_SETPOS = 0x0467,
        UDM_SETPOS32 = 0x0471,
        UDM_SETRANGE = 0x0465,
        UDM_SETRANGE32 = 0x046F,

        // TB
        TB_ADDBITMAP = 0x0413,
        TB_ADDBUTTONS = 0x0414,
        TB_ADDSTRING = 0x041C,
        TB_AUTOSIZE = 0x0421,
        TB_BUTTONSTRUCTSIZE = 0x041E,
        TB_CHECKBUTTON = 0x0402,
        TB_COMMANDTOINDEX = 0x0419,
        TB_DELETEBUTTON = 0x0416,
        TB_ENABLEBUTTON = 0x0401,
        TB_GETSTATE = 0x0412,
        TB_HIDEBUTTON = 0x0404,
        TB_INSERTBUTTON = 0x0415,
        TB_LOADIMAGES = 0x0432,
        TB_SETBITMAPSIZE = 0x0420,
        TB_SETDISABLEDIMAGELIST = 0x0436,
        TB_SETHOTIMAGELIST = 0x0434,
        TB_SETIMAGELIST = 0x0430,
        TB_SETINDENT = 0x042F,
        TB_SETSTATE = 0x0411,

        // EM
        EM_FIRST = 0x0400,
        EM_EXGETSEL = 0x0400 + 52,
        EM_EXSETSEL = 0x0400 + 55,
        EM_GETCHARFORMAT = 0x0400 + 58,
        EM_SETCHARFORMAT = 0x0400 + 68,
        EM_SETOPTIONS = 0x0400 + 77,
        EM_GETOPTIONS = 0x0400 + 78,
        EM_GETTEXTEX = 0x0400 + 94,
        EM_GETTEXTLENGTHEX = 0x0400 + 95,
        EM_SHOWSCROLLBAR = 0x0400 + 96,
        EM_SETTEXTEX = 0x0400 + 97,
        EM_GETSCROLLPOS = 0x0400 + 221,
        EM_SETSCROLLPOS = 0x0400 + 222,


    }
}