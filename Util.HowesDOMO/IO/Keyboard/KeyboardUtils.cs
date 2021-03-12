using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.IO
{
    /// <summary>
    /// V 1.0.1 - 2021-02-22 16:37:08
    /// 1 新增Char2Key
    /// 2 新增String2Key
    /// 
    /// V 1.0.0 - 2021-02-04 15:10:02
    /// 1 模拟键盘输入
    /// 2 检查键盘 NumLock / Caspcase 状态
    /// 3 整理常用组合键 ( ShortcutKey )
    /// </summary>
    public class KeyboardUtils
    {

        #region [user32.dll] 模拟键盘输入

        /// <summary>
        /// 调用 user32.dll 的 keybd_event, 模拟键盘输入
        /// https://docs.microsoft.com/zh-cn/windows/win32/api/winuser/nf-winuser-keybd_event
        /// </summary>
        /// <param name="bVk">A virtual-key code. The code must be a value in the range 1 to 254. ( 虚拟键码 参考 https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes ) </param>
        /// <param name="bScan">A hardware scan code for the key. ( 该键的硬件扫描码 )</param>
        /// <param name="dwFlags">Controls various aspects of function operation. This parameter can be one or more of the following values.</param>
        /// <param name="dwExtraInfo">An additional value associated with the key stroke.</param>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        #endregion

        #region [user32.dll] 检查键盘状态
        
        // [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetKeyState", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern short GetKeyState(int keyCode);

        #endregion

        public static int KEYEVENTF_EXTENDEDKEY = 0x0001; // 按下

        public static int KEYEVENTF_KEYUP = 0x0002; // 松开

        #region Virtual-Key Codes

        #region 0x01 - 0x2F

        /// <summary> 
        /// Left mouse button
        /// </summary>
        public const byte VK_LBUTTON = 0x01;

        /// <summary> 
        /// Right mouse button
        /// </summary>
        public const byte VK_RBUTTON = 0x02;

        /// <summary> 
        /// Control-break processing
        /// </summary>
        public const byte VK_CANCEL = 0x03;

        /// <summary> 
        /// Middle mouse button (three-button mouse)
        /// </summary>
        public const byte VK_MBUTTON = 0x04;

        /// <summary> 
        /// X1 mouse button
        /// </summary>
        public const byte VK_XBUTTON1 = 0x05;

        /// <summary> 
        /// X2 mouse button
        /// </summary>
        public const byte VK_XBUTTON2 = 0x06;

        ///// <summary> 
        ///// Undefined
        ///// </summary>
        //public const byte - = 0x07;

        /// <summary> 
        /// BACKSPACE key
        /// </summary>
        public const byte VK_BACK = 0x08;

        /// <summary> 
        /// TAB key
        /// </summary>
        public const byte VK_TAB = 0x09;

        ///// <summary> 
        ///// Reserved
        ///// </summary>
        //public const byte - = 0x0A-0B;

        /// <summary> 
        /// CLEAR key
        /// </summary>
        public const byte VK_CLEAR = 0x0C;

        /// <summary> 
        /// ENTER key
        /// </summary>
        public const byte VK_RETURN = 0x0D;

        ///// <summary> 
        ///// Undefined
        ///// </summary>
        //public const byte - = 0x0E-0F;

        /// <summary> 
        /// SHIFT key
        /// </summary>
        public const byte VK_SHIFT = 0x10;

        /// <summary> 
        /// CTRL key
        /// </summary>
        public const byte VK_CONTROL = 0x11;

        /// <summary> 
        /// ALT key
        /// </summary>
        public const byte VK_MENU = 0x12;

        /// <summary> 
        /// PAUSE key
        /// </summary>
        public const byte VK_PAUSE = 0x13;

        /// <summary> 
        /// CAPS LOCK key
        /// </summary>
        public const byte VK_CAPITAL = 0x14;

        /// <summary> 
        /// IME Kana mode
        /// </summary>
        public const byte VK_KANA = 0x15;

        /// <summary> 
        /// IME Hanguel mode (maintained for compatibility; use VK_HANGUL)
        /// </summary>
        public const byte VK_HANGUEL = 0x15;

        /// <summary> 
        /// IME Hangul mode
        /// </summary>
        public const byte VK_HANGUL = 0x15;

        /// <summary> 
        /// IME On
        /// </summary>
        public const byte VK_IME_ON = 0x16;

        /// <summary> 
        /// IME Junja mode
        /// </summary>
        public const byte VK_JUNJA = 0x17;

        /// <summary> 
        /// IME final mode
        /// </summary>
        public const byte VK_FINAL = 0x18;

        /// <summary> 
        /// IME Hanja mode
        /// </summary>
        public const byte VK_HANJA = 0x19;

        /// <summary> 
        /// IME Kanji mode
        /// </summary>
        public const byte VK_KANJI = 0x19;

        /// <summary> 
        /// IME Off
        /// </summary>
        public const byte VK_IME_OFF = 0x1A;

        /// <summary> 
        /// ESC key
        /// </summary>
        public const byte VK_ESCAPE = 0x1B;

        /// <summary> 
        /// IME convert
        /// </summary>
        public const byte VK_CONVERT = 0x1C;

        /// <summary> 
        /// IME nonconvert
        /// </summary>
        public const byte VK_NONCONVERT = 0x1D;

        /// <summary> 
        /// IME accept
        /// </summary>
        public const byte VK_ACCEPT = 0x1E;

        /// <summary> 
        /// IME mode change request
        /// </summary>
        public const byte VK_MODECHANGE = 0x1F;

        /// <summary> 
        /// SPACEBAR
        /// </summary>
        public const byte VK_SPACE = 0x20;

        /// <summary> 
        /// PAGE UP key
        /// </summary>
        public const byte VK_PRIOR = 0x21;

        /// <summary> 
        /// PAGE DOWN key
        /// </summary>
        public const byte VK_NEXT = 0x22;

        /// <summary> 
        /// END key
        /// </summary>
        public const byte VK_END = 0x23;

        /// <summary> 
        /// HOME key
        /// </summary>
        public const byte VK_HOME = 0x24;

        /// <summary> 
        /// LEFT ARROW key
        /// </summary>
        public const byte VK_LEFT = 0x25;

        /// <summary> 
        /// UP ARROW key
        /// </summary>
        public const byte VK_UP = 0x26;

        /// <summary> 
        /// RIGHT ARROW key
        /// </summary>
        public const byte VK_RIGHT = 0x27;

        /// <summary> 
        /// DOWN ARROW key
        /// </summary>
        public const byte VK_DOWN = 0x28;

        /// <summary> 
        /// SELECT key
        /// </summary>
        public const byte VK_SELECT = 0x29;

        /// <summary> 
        /// PRINT key
        /// </summary>
        public const byte VK_PRINT = 0x2A;

        /// <summary> 
        /// EXECUTE key
        /// </summary>
        public const byte VK_EXECUTE = 0x2B;

        /// <summary> 
        /// PRINT SCREEN key
        /// </summary>
        public const byte VK_SNAPSHOT = 0x2C;

        /// <summary> 
        /// INS key
        /// </summary>
        public const byte VK_INSERT = 0x2D;

        /// <summary> 
        /// DEL key
        /// </summary>
        public const byte VK_DELETE = 0x2E;

        /// <summary> 
        /// HELP key
        /// </summary>
        public const byte VK_HELP = 0x2F;

        #endregion

        #region 0x30 - 0x39 [Number 0-9]

        /// <summary> 
        /// 0 key
        /// </summary>
        public const byte D0 = 0x30;

        /// <summary> 
        /// 1 key
        /// </summary>
        public const byte D1 = 0x31;

        /// <summary> 
        /// 2 key
        /// </summary>
        public const byte D2 = 0x32;

        /// <summary> 
        /// 3 key
        /// </summary>
        public const byte D3 = 0x33;

        /// <summary> 
        /// 4 key
        /// </summary>
        public const byte D4 = 0x34;

        /// <summary> 
        /// 5 key
        /// </summary>
        public const byte D5 = 0x35;

        /// <summary> 
        /// 6 key
        /// </summary>
        public const byte D6 = 0x36;

        /// <summary> 
        /// 7 key
        /// </summary>
        public const byte D7 = 0x37;

        /// <summary> 
        /// 8 key
        /// </summary>
        public const byte D8 = 0x38;

        /// <summary> 
        /// 9 key
        /// </summary>
        public const byte D9 = 0x39;

        #endregion

        #region 0x41 - 0x5A [A-Z]

        /// <summary> 
        /// A key
        /// </summary>
        public const byte A = 0x41;

        /// <summary> 
        /// B key
        /// </summary>
        public const byte B = 0x42;

        /// <summary> 
        /// C key
        /// </summary>
        public const byte C = 0x43;

        /// <summary> 
        /// D key
        /// </summary>
        public const byte D = 0x44;

        /// <summary> 
        /// E key
        /// </summary>
        public const byte E = 0x45;

        /// <summary> 
        /// F key
        /// </summary>
        public const byte F = 0x46;

        /// <summary> 
        /// G key
        /// </summary>
        public const byte G = 0x47;

        /// <summary> 
        /// H key
        /// </summary>
        public const byte H = 0x48;

        /// <summary> 
        /// I key
        /// </summary>
        public const byte I = 0x49;

        /// <summary> 
        /// J key
        /// </summary>
        public const byte J = 0x4A;

        /// <summary> 
        /// K key
        /// </summary>
        public const byte K = 0x4B;

        /// <summary> 
        /// L key
        /// </summary>
        public const byte L = 0x4C;

        /// <summary> 
        /// M key
        /// </summary>
        public const byte M = 0x4D;

        /// <summary> 
        /// N key
        /// </summary>
        public const byte N = 0x4E;

        /// <summary> 
        /// O key
        /// </summary>
        public const byte O = 0x4F;

        /// <summary> 
        /// P key
        /// </summary>
        public const byte P = 0x50;

        /// <summary> 
        /// Q key
        /// </summary>
        public const byte Q = 0x51;

        /// <summary> 
        /// R key
        /// </summary>
        public const byte R = 0x52;

        /// <summary> 
        /// S key
        /// </summary>
        public const byte S = 0x53;

        /// <summary> 
        /// T key
        /// </summary>
        public const byte T = 0x54;

        /// <summary> 
        /// U key
        /// </summary>
        public const byte U = 0x55;

        /// <summary> 
        /// V key
        /// </summary>
        public const byte V = 0x56;

        /// <summary> 
        /// W key
        /// </summary>
        public const byte W = 0x57;

        /// <summary> 
        /// X key
        /// </summary>
        public const byte X = 0x58;

        /// <summary> 
        /// Y key
        /// </summary>
        public const byte Y = 0x59;

        /// <summary> 
        /// Z key
        /// </summary>
        public const byte Z = 0x5A;

        #endregion

        #region 0x5B - 0x5F

        /// <summary> 
        /// Left Windows key (Natural keyboard)
        /// </summary>
        public const byte VK_LWIN = 0x5B;

        /// <summary> 
        /// Right Windows key (Natural keyboard)
        /// </summary>
        public const byte VK_RWIN = 0x5C;

        /// <summary> 
        /// Applications key (Natural keyboard)
        /// </summary>
        public const byte VK_APPS = 0x5D;

        ///// <summary> 
        ///// Reserved
        ///// </summary>
        //public const byte - = 0x5E;

        /// <summary> 
        /// Computer Sleep key
        /// </summary>
        public const byte VK_SLEEP = 0x5F;

        #endregion

        #region 0x60 - 0x69 [NumPad 0-9]

        /// <summary> 
        /// Numeric keypad 0 key
        /// </summary>
        public const byte VK_NUMPAD0 = 0x60;

        /// <summary> 
        /// Numeric keypad 1 key
        /// </summary>
        public const byte VK_NUMPAD1 = 0x61;

        /// <summary> 
        /// Numeric keypad 2 key
        /// </summary>
        public const byte VK_NUMPAD2 = 0x62;

        /// <summary> 
        /// Numeric keypad 3 key
        /// </summary>
        public const byte VK_NUMPAD3 = 0x63;

        /// <summary> 
        /// Numeric keypad 4 key
        /// </summary>
        public const byte VK_NUMPAD4 = 0x64;

        /// <summary> 
        /// Numeric keypad 5 key
        /// </summary>
        public const byte VK_NUMPAD5 = 0x65;

        /// <summary> 
        /// Numeric keypad 6 key
        /// </summary>
        public const byte VK_NUMPAD6 = 0x66;

        /// <summary> 
        /// Numeric keypad 7 key
        /// </summary>
        public const byte VK_NUMPAD7 = 0x67;

        /// <summary> 
        /// Numeric keypad 8 key
        /// </summary>
        public const byte VK_NUMPAD8 = 0x68;

        /// <summary> 
        /// Numeric keypad 9 key
        /// </summary>
        public const byte VK_NUMPAD9 = 0x69;


        #endregion

        #region 0x6A - 0xFE

        /// <summary> 
        /// Multiply key
        /// </summary>
        public const byte VK_MULTIPLY = 0x6A;

        /// <summary> 
        /// Add key
        /// </summary>
        public const byte VK_ADD = 0x6B;

        /// <summary> 
        /// Separator key
        /// </summary>
        public const byte VK_SEPARATOR = 0x6C;

        /// <summary> 
        /// Subtract key
        /// </summary>
        public const byte VK_SUBTRACT = 0x6D;

        /// <summary> 
        /// Decimal key
        /// </summary>
        public const byte VK_DECIMAL = 0x6E;

        /// <summary> 
        /// Divide key
        /// </summary>
        public const byte VK_DIVIDE = 0x6F;

        /// <summary> 
        /// F1 key
        /// </summary>
        public const byte VK_F1 = 0x70;

        /// <summary> 
        /// F2 key
        /// </summary>
        public const byte VK_F2 = 0x71;

        /// <summary> 
        /// F3 key
        /// </summary>
        public const byte VK_F3 = 0x72;

        /// <summary> 
        /// F4 key
        /// </summary>
        public const byte VK_F4 = 0x73;

        /// <summary> 
        /// F5 key
        /// </summary>
        public const byte VK_F5 = 0x74;

        /// <summary> 
        /// F6 key
        /// </summary>
        public const byte VK_F6 = 0x75;

        /// <summary> 
        /// F7 key
        /// </summary>
        public const byte VK_F7 = 0x76;

        /// <summary> 
        /// F8 key
        /// </summary>
        public const byte VK_F8 = 0x77;

        /// <summary> 
        /// F9 key
        /// </summary>
        public const byte VK_F9 = 0x78;

        /// <summary> 
        /// F10 key
        /// </summary>
        public const byte VK_F10 = 0x79;

        /// <summary> 
        /// F11 key
        /// </summary>
        public const byte VK_F11 = 0x7A;

        /// <summary> 
        /// F12 key
        /// </summary>
        public const byte VK_F12 = 0x7B;

        /// <summary> 
        /// F13 key
        /// </summary>
        public const byte VK_F13 = 0x7C;

        /// <summary> 
        /// F14 key
        /// </summary>
        public const byte VK_F14 = 0x7D;

        /// <summary> 
        /// F15 key
        /// </summary>
        public const byte VK_F15 = 0x7E;

        /// <summary> 
        /// F16 key
        /// </summary>
        public const byte VK_F16 = 0x7F;

        /// <summary> 
        /// F17 key
        /// </summary>
        public const byte VK_F17 = 0x80;

        /// <summary> 
        /// F18 key
        /// </summary>
        public const byte VK_F18 = 0x81;

        /// <summary> 
        /// F19 key
        /// </summary>
        public const byte VK_F19 = 0x82;

        /// <summary> 
        /// F20 key
        /// </summary>
        public const byte VK_F20 = 0x83;

        /// <summary> 
        /// F21 key
        /// </summary>
        public const byte VK_F21 = 0x84;

        /// <summary> 
        /// F22 key
        /// </summary>
        public const byte VK_F22 = 0x85;

        /// <summary> 
        /// F23 key
        /// </summary>
        public const byte VK_F23 = 0x86;

        /// <summary> 
        /// F24 key
        /// </summary>
        public const byte VK_F24 = 0x87;

        ///// <summary> 
        ///// Unassigned
        ///// </summary>
        //public const byte - = 0x88-8F;

        /// <summary> 
        /// NUM LOCK key
        /// </summary>
        public const byte VK_NUMLOCK = 0x90;

        /// <summary> 
        /// SCROLL LOCK key
        /// </summary>
        public const byte VK_SCROLL = 0x91;

        ///// <summary> 
        ///// 
        ///// </summary>
        //public const byte  = 0x92 - 96;

        ///// <summary> 
        ///// Unassigned
        ///// </summary>
        //public const byte - = 0x97-9F;

        /// <summary> 
        /// Left SHIFT key
        /// </summary>
        public const byte VK_LSHIFT = 0xA0;

        /// <summary> 
        /// Right SHIFT key
        /// </summary>
        public const byte VK_RSHIFT = 0xA1;

        /// <summary> 
        /// Left CONTROL key
        /// </summary>
        public const byte VK_LCONTROL = 0xA2;

        /// <summary> 
        /// Right CONTROL key
        /// </summary>
        public const byte VK_RCONTROL = 0xA3;

        /// <summary> 
        /// Left MENU key
        /// </summary>
        public const byte VK_LMENU = 0xA4;

        /// <summary> 
        /// Right MENU key
        /// </summary>
        public const byte VK_RMENU = 0xA5;

        /// <summary> 
        /// Browser Back key
        /// </summary>
        public const byte VK_BROWSER_BACK = 0xA6;

        /// <summary> 
        /// Browser Forward key
        /// </summary>
        public const byte VK_BROWSER_FORWARD = 0xA7;

        /// <summary> 
        /// Browser Refresh key
        /// </summary>
        public const byte VK_BROWSER_REFRESH = 0xA8;

        /// <summary> 
        /// Browser Stop key
        /// </summary>
        public const byte VK_BROWSER_STOP = 0xA9;

        /// <summary> 
        /// Browser Search key
        /// </summary>
        public const byte VK_BROWSER_SEARCH = 0xAA;

        /// <summary> 
        /// Browser Favorites key
        /// </summary>
        public const byte VK_BROWSER_FAVORITES = 0xAB;

        /// <summary> 
        /// Browser Start and Home key
        /// </summary>
        public const byte VK_BROWSER_HOME = 0xAC;

        /// <summary> 
        /// Volume Mute key
        /// </summary>
        public const byte VK_VOLUME_MUTE = 0xAD;

        /// <summary> 
        /// Volume Down key
        /// </summary>
        public const byte VK_VOLUME_DOWN = 0xAE;

        /// <summary> 
        /// Volume Up key
        /// </summary>
        public const byte VK_VOLUME_UP = 0xAF;

        /// <summary> 
        /// Next Track key
        /// </summary>
        public const byte VK_MEDIA_NEXT_TRACK = 0xB0;

        /// <summary> 
        /// Previous Track key
        /// </summary>
        public const byte VK_MEDIA_PREV_TRACK = 0xB1;

        /// <summary> 
        /// Stop Media key
        /// </summary>
        public const byte VK_MEDIA_STOP = 0xB2;

        /// <summary> 
        /// Play/Pause Media key
        /// </summary>
        public const byte VK_MEDIA_PLAY_PAUSE = 0xB3;

        /// <summary> 
        /// Start Mail key
        /// </summary>
        public const byte VK_LAUNCH_MAIL = 0xB4;

        /// <summary> 
        /// Select Media key
        /// </summary>
        public const byte VK_LAUNCH_MEDIA_SELECT = 0xB5;

        /// <summary> 
        /// Start Application 1 key
        /// </summary>
        public const byte VK_LAUNCH_APP1 = 0xB6;

        /// <summary> 
        /// Start Application 2 key
        /// </summary>
        public const byte VK_LAUNCH_APP2 = 0xB7;

        ///// <summary> 
        ///// Reserved
        ///// </summary>
        //public const byte - = 0xB8-B9;

        /// <summary> 
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the ';:' key
        /// 分号 冒号
        /// </summary>
        public const byte VK_OEM_1 = 0xBA;

        /// <summary> 
        /// For any country/region, the '+' key
        /// </summary>
        public const byte VK_OEM_PLUS = 0xBB;

        /// <summary> 
        /// For any country/region, the ',' key
        /// </summary>
        public const byte VK_OEM_COMMA = 0xBC;

        /// <summary> 
        /// For any country/region, the '-' key
        /// </summary>
        public const byte VK_OEM_MINUS = 0xBD;

        /// <summary> 
        /// For any country/region, the '.' key
        /// </summary>
        public const byte VK_OEM_PERIOD = 0xBE;

        /// <summary> 
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '/?' key
        /// 正斜杠 问号
        /// </summary>
        public const byte VK_OEM_2 = 0xBF;

        /// <summary> 
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '`~' key
        /// 波浪符
        /// </summary>
        public const byte VK_OEM_3 = 0xC0;

        //        /// <summary> 
        //        /// Reserved
        //        /// </summary>
        //        public const byte - = 0xC1-D7;

        ///// <summary> 
        ///// Unassigned
        ///// </summary>
        //public const byte - = 0xD8-DA;

        /// <summary> 
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '[{' key
        /// [{ 左中括号 左花括号
        /// </summary>
        public const byte VK_OEM_4 = 0xDB;

        /// <summary> 
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '\|' key
        /// 反斜杠 竖线
        /// </summary>
        public const byte VK_OEM_5 = 0xDC;

        /// <summary> 
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the ']}' key
        /// ]} 右中括号 右花括号
        /// </summary>
        public const byte VK_OEM_6 = 0xDD;

        /// <summary> 
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the 'single-quote/double-quote' key
        /// '" 单引号 双引号
        /// </summary>
        public const byte VK_OEM_7 = 0xDE;

        /// <summary> 
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// </summary>
        public const byte VK_OEM_8 = 0xDF;

        ///// <summary> 
        ///// Reserved
        ///// </summary>
        //public const byte - = 0xE0;

        ///// <summary> 
        ///// 
        ///// </summary>
        //public const byte  = 0xE1;

        /// <summary> 
        /// Either the angle bracket key or the backslash key on the RT 102-key keyboard
        /// </summary>
        public const byte VK_OEM_102 = 0xE2;

        ///// <summary> 
        ///// 
        ///// </summary>
        //public const byte  = 0xE3 - E4;

        /// <summary> 
        /// IME PROCESS key
        /// </summary>
        public const byte VK_PROCESSKEY = 0xE5;

        ///// <summary> 
        ///// 
        ///// </summary>
        //public const byte  = 0xE6;

        /// <summary> 
        /// Used to pass Unicode characters as if they were keystrokes. The VK_PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods. For more information, see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN, and WM_KEYUP
        /// </summary>
        public const byte VK_PACKET = 0xE7;

        ///// <summary> 
        ///// Unassigned
        ///// </summary>
        //public const byte - = 0xE8;

        ///// <summary> 
        ///// 
        ///// </summary>
        //public const byte  = 0xE9 - F5;

        /// <summary> 
        /// Attn key
        /// </summary>
        public const byte VK_ATTN = 0xF6;

        /// <summary> 
        /// CrSel key
        /// </summary>
        public const byte VK_CRSEL = 0xF7;

        /// <summary> 
        /// ExSel key
        /// </summary>
        public const byte VK_EXSEL = 0xF8;

        /// <summary> 
        /// Erase EOF key
        /// </summary>
        public const byte VK_EREOF = 0xF9;

        /// <summary> 
        /// Play key
        /// </summary>
        public const byte VK_PLAY = 0xFA;

        /// <summary> 
        /// Zoom key
        /// </summary>
        public const byte VK_ZOOM = 0xFB;

        /// <summary> 
        /// Reserved
        /// </summary>
        public const byte VK_NONAME = 0xFC;

        /// <summary> 
        /// PA1 key
        /// </summary>
        public const byte VK_PA1 = 0xFD;

        /// <summary> 
        /// Clear key
        /// </summary>
        public const byte VK_OEM_CLEAR = 0xFE;

        #endregion

        #endregion

        /// <summary>
        /// 根据keyCode参数, 对该键先进行按下, 然后松开的操作
        /// </summary>
        /// <param name="keyCode"></param>
        /// <param name="delayTimespan">延迟输入时间</param>
        public static void Execute(byte keyCode, TimeSpan? delayTimespan = null)
        {
            if (delayTimespan.HasValue == true && int.TryParse(delayTimespan.Value.TotalMilliseconds.ToString(), out int v) == true)
            {
                System.Threading.Thread.Sleep(v);
            }
            keybd_event(keyCode, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
            keybd_event(keyCode, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        /// <summary>
        /// 测试便于观察按键是否配对 
        /// </summary>
        /// <param name="keyCode"></param>
        public static void ExecuteForTest(byte keyCode)
        {
            Execute(keyCode, TimeSpan.FromMilliseconds(800));
        }

        /// <summary>
        /// 检查键盘状态
        /// </summary>
        /// <param name="keyCode">byte 或 int</param>
        /// <returns>开启true; 关闭on</returns>
        public static bool IsKeyStateOn(byte keyCode)
        {
            return GetKeyState(keyCode) == 1 ? true : false;
        }

        #region String2Key & Char2Key

        public static bool IsDebug = false;


        /// <summary>
        /// 模拟键盘输出string中匹配的char
        /// </summary>
        /// <param name="args"></param>
        /// <param name="delayTimespan"></param>
        public static void String2Key(string args, TimeSpan? delayTimespan = null)
        {
            foreach (char c in args)
            {
                bool isMatch = Char2Key(c, delayTimespan);
                if (IsDebug && isMatch == false) System.Diagnostics.Debug.WriteLine($"{c.ToString().StringShowSpecialSymbol()} is not match");                
            }
        }

        /// <summary>
        /// 模拟键盘输出匹配的char
        /// </summary>
        /// <param name="c">传入char</param>
        /// <param name="delayTimespan">延迟输入时间</param>
        /// <returns>是匹配成功</returns>
        public static bool Char2Key(char c, TimeSpan? delayTimespan = null)
        {
            bool isMatch = true;
            switch (c)
            {
                case 'A': ExecuteUpper(A, delayTimespan); break;
                case 'a': ExecuteLower(A, delayTimespan); break;
                case 'B': ExecuteUpper(B, delayTimespan); break;
                case 'b': ExecuteLower(B, delayTimespan); break;
                case 'C': ExecuteUpper(C, delayTimespan); break;
                case 'c': ExecuteLower(C, delayTimespan); break;
                case 'D': ExecuteUpper(D, delayTimespan); break;
                case 'd': ExecuteLower(D, delayTimespan); break;
                case 'E': ExecuteUpper(E, delayTimespan); break;
                case 'e': ExecuteLower(E, delayTimespan); break;
                case 'F': ExecuteUpper(F, delayTimespan); break;
                case 'f': ExecuteLower(F, delayTimespan); break;
                case 'G': ExecuteUpper(G, delayTimespan); break;
                case 'g': ExecuteLower(G, delayTimespan); break;
                case 'H': ExecuteUpper(H, delayTimespan); break;
                case 'h': ExecuteLower(H, delayTimespan); break;
                case 'I': ExecuteUpper(I, delayTimespan); break;
                case 'i': ExecuteLower(I, delayTimespan); break;
                case 'J': ExecuteUpper(J, delayTimespan); break;
                case 'j': ExecuteLower(J, delayTimespan); break;
                case 'K': ExecuteUpper(K, delayTimespan); break;
                case 'k': ExecuteLower(K, delayTimespan); break;
                case 'L': ExecuteUpper(L, delayTimespan); break;
                case 'l': ExecuteLower(L, delayTimespan); break;
                case 'M': ExecuteUpper(M, delayTimespan); break;
                case 'm': ExecuteLower(M, delayTimespan); break;
                case 'N': ExecuteUpper(N, delayTimespan); break;
                case 'n': ExecuteLower(N, delayTimespan); break;
                case 'O': ExecuteUpper(O, delayTimespan); break;
                case 'o': ExecuteLower(O, delayTimespan); break;
                case 'P': ExecuteUpper(P, delayTimespan); break;
                case 'p': ExecuteLower(P, delayTimespan); break;
                case 'Q': ExecuteUpper(Q, delayTimespan); break;
                case 'q': ExecuteLower(Q, delayTimespan); break;
                case 'R': ExecuteUpper(R, delayTimespan); break;
                case 'r': ExecuteLower(R, delayTimespan); break;
                case 'S': ExecuteUpper(S, delayTimespan); break;
                case 's': ExecuteLower(S, delayTimespan); break;
                case 'T': ExecuteUpper(T, delayTimespan); break;
                case 't': ExecuteLower(T, delayTimespan); break;
                case 'U': ExecuteUpper(U, delayTimespan); break;
                case 'u': ExecuteLower(U, delayTimespan); break;
                case 'V': ExecuteUpper(V, delayTimespan); break;
                case 'v': ExecuteLower(V, delayTimespan); break;
                case 'W': ExecuteUpper(W, delayTimespan); break;
                case 'w': ExecuteLower(W, delayTimespan); break;
                case 'X': ExecuteUpper(X, delayTimespan); break;
                case 'x': ExecuteLower(X, delayTimespan); break;
                case 'Y': ExecuteUpper(Y, delayTimespan); break;
                case 'y': ExecuteLower(Y, delayTimespan); break;
                case 'Z': ExecuteUpper(Z, delayTimespan); break;
                case 'z': ExecuteLower(Z, delayTimespan); break;


                case '!': ExecuteUpper(D1, delayTimespan); break;
                case '1': ExecuteLower(D1, delayTimespan); break;
                case '@': ExecuteUpper(D2, delayTimespan); break;
                case '2': ExecuteLower(D2, delayTimespan); break;
                case '#': ExecuteUpper(D3, delayTimespan); break;
                case '3': ExecuteLower(D3, delayTimespan); break;
                case '$': ExecuteUpper(D4, delayTimespan); break;
                case '4': ExecuteLower(D4, delayTimespan); break;
                case '%': ExecuteUpper(D5, delayTimespan); break;
                case '5': ExecuteLower(D5, delayTimespan); break;
                case '^': ExecuteUpper(D6, delayTimespan); break;
                case '6': ExecuteLower(D6, delayTimespan); break;
                case '&': ExecuteUpper(D7, delayTimespan); break;
                case '7': ExecuteLower(D7, delayTimespan); break;
                case '*': ExecuteUpper(D8, delayTimespan); break;
                case '8': ExecuteLower(D8, delayTimespan); break;
                case '(': ExecuteUpper(D9, delayTimespan); break;
                case '9': ExecuteLower(D9, delayTimespan); break;
                case ')': ExecuteUpper(D0, delayTimespan); break;
                case '0': ExecuteLower(D0, delayTimespan); break;


                case '`': ExecuteUpper(VK_OEM_3, delayTimespan); break;
                case '~': ExecuteLower(VK_OEM_3, delayTimespan); break;
                case '_': ExecuteUpper(VK_OEM_MINUS, delayTimespan); break;
                case '-': ExecuteLower(VK_OEM_MINUS, delayTimespan); break;
                case '+': ExecuteUpper(VK_OEM_PLUS, delayTimespan); break;
                case '=': ExecuteLower(VK_OEM_PLUS, delayTimespan); break;
                case '{': ExecuteUpper(VK_OEM_4, delayTimespan); break;
                case '[': ExecuteLower(VK_OEM_4, delayTimespan); break;
                case '}': ExecuteUpper(VK_OEM_6, delayTimespan); break;
                case ']': ExecuteLower(VK_OEM_6, delayTimespan); break;
                case ':': ExecuteUpper(VK_OEM_1, delayTimespan); break;
                case ';': ExecuteLower(VK_OEM_1, delayTimespan); break;
                case '"': ExecuteUpper(VK_OEM_7, delayTimespan); break;  // 双引号
                case '\'': ExecuteLower(VK_OEM_7, delayTimespan); break; // 单引号
                case '|': ExecuteUpper(VK_OEM_5, delayTimespan); break;
                case '\\': ExecuteLower(VK_OEM_5, delayTimespan); break;
                case '<': ExecuteUpper(VK_OEM_COMMA, delayTimespan); break;
                case ',': ExecuteLower(VK_OEM_COMMA, delayTimespan); break;
                case '>': ExecuteUpper(VK_OEM_PERIOD, delayTimespan); break;
                case '.': ExecuteLower(VK_OEM_PERIOD, delayTimespan); break;
                case '?': ExecuteUpper(VK_OEM_2, delayTimespan); break;
                case '/': ExecuteLower(VK_OEM_2, delayTimespan); break;


                case '\t': ExecuteLower(VK_TAB, delayTimespan); break;
                case ' ': ExecuteLower(VK_SPACE, delayTimespan); break;
                case '\n': ExecuteLower(VK_RETURN, delayTimespan); break; // n 含义换行


                default:
                    isMatch = false;
                    break;
            }

            return isMatch;
        }

        /// <summary>
        /// 输出小写
        /// 1 确保 Caps Lock 在关闭状态
        /// 2 输出 VitualKeyCode 对应键值
        /// </summary>
        /// <param name="args"></param>
        /// <param name="delayTimespan"></param>
        public static void ExecuteLower(byte args, TimeSpan? delayTimespan = null)
        {
            if (delayTimespan.HasValue == true && int.TryParse(delayTimespan.Value.TotalMilliseconds.ToString(), out int v) == true)
            {
                System.Threading.Thread.Sleep(v);
            }

            CapsLockOff();
            Execute(args);
        }

        /// <summary>
        /// 输出大写
        /// 1 确保 Caps Lock 在关闭状态
        /// 2 按住 Shift 输出 VitualKeyCode 对应键值
        /// </summary>
        /// <param name="args"></param>
        /// <param name="delayTimespan"></param>
        public static void ExecuteUpper(byte args, TimeSpan? delayTimespan = null)
        {
            if (delayTimespan.HasValue == true && int.TryParse(delayTimespan.Value.TotalMilliseconds.ToString(), out int v) == true)
            {
                System.Threading.Thread.Sleep(v);
            }

            CapsLockOff();
            Shift_XKey(args);
        }

        private static void Shift_XKey(byte args, TimeSpan? delayTimespan = null)
        {
            if (delayTimespan.HasValue == true && int.TryParse(delayTimespan.Value.TotalMilliseconds.ToString(), out int v) == true)
            {
                System.Threading.Thread.Sleep(v);
            }

            keybd_event(VK_SHIFT, 0, KEYEVENTF_EXTENDEDKEY, 0); // 按下 shift
            keybd_event(args, 0, KEYEVENTF_EXTENDEDKEY, 0); // 按下 X

            keybd_event(VK_SHIFT, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0); // 松开 shift
            keybd_event(args, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0); // 松开 X
        }

        #endregion

        #region 常用键按下松开

        public static void Esc()
        {
            Execute(VK_ESCAPE);
        }

        public static void Tab()
        {
            Execute(VK_TAB);
        }

        public static void Enter()
        {
            Execute(VK_RETURN);
        }

        /// <summary>
        /// Print Screen
        /// </summary>
        public static void PrtScr()
        {
            Execute(VK_SNAPSHOT);
        }

        #endregion

        #region XxxLock ON / OFF

        public static void NumberLockOn()
        {
            if (IsKeyStateOn(VK_NUMLOCK) == false)
            {
                Execute(VK_NUMLOCK);
            }
        }

        public static void NumberLockOff()
        {
            if (IsKeyStateOn(VK_NUMLOCK) == true)
            {
                Execute(VK_NUMLOCK);
            }
        }

        public static void CapsLockOn()
        {
            if (IsKeyStateOn(VK_CAPITAL) == false)
            {
                Execute(VK_CAPITAL);
            }
        }

        public static void CapsLockOff()
        {
            if (IsKeyStateOn(VK_CAPITAL) == true)
            {
                Execute(VK_CAPITAL);
            }
        }

        #endregion

        #region ShortcutKey

        public static void ShortcutKey_CtrlV()
        {
            keybd_event(VK_CONTROL, 0, KEYEVENTF_EXTENDEDKEY, 0); // 按下 ctrl
            keybd_event(V, 0, KEYEVENTF_EXTENDEDKEY, 0); // 按下 V

            keybd_event(VK_CONTROL, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0); // 松开 ctrl
            keybd_event(V, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0); // 松开 V
        }

        public static void ShortcutKey_AtlF4()
        {
            keybd_event(VK_MENU, 0, KEYEVENTF_EXTENDEDKEY, 0); // 按下 ALT
            keybd_event(VK_F4, 0, KEYEVENTF_EXTENDEDKEY, 0); // 按下 F4

            keybd_event(VK_MENU, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0); // 松开 ALT
            keybd_event(VK_F4, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0); // 松开 F4
        }

        public static void ShortcutKey_AtlEnter()
        {
            keybd_event(VK_MENU, 0, KEYEVENTF_EXTENDEDKEY, 0); // 按下 ALT
            keybd_event(VK_RETURN, 0, KEYEVENTF_EXTENDEDKEY, 0); // 按下 Enter

            keybd_event(VK_MENU, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0); // 松开 ALT
            keybd_event(VK_RETURN, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0); // 松开 Enter
        }

        #endregion


    }
}
