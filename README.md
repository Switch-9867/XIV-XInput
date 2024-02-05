# Cross(X) Input Dalamud Plugin

This plugin allows you to bind keys to other keys using the low level windows api to send key inputs for minimal input delay.

## Repo
`https://raw.githubusercontent.com/Switch-9867/DalamudRepo/main/repo.json`

## Reference Virtual Key Codes 
| Name                               | Description                                              |
|------------------------------------|----------------------------------------------------------|
| A                                  | A key.                                                    |
| ACCEPT                             | IME accept.                                               |
| ADD                                | Add key.                                                  |
| APPS                               | Applications key (Natural keyboard).                     |
| ATTN                               | Attn key.                                                 |
| B                                  | B key.                                                    |
| BACK                               | BACKSPACE key.                                           |
| BROWSER_BACK                       | Browser Back key.                                        |
| BROWSER_FAVORITES                  | Browser Favorites key.                                   |
| BROWSER_FORWARD                    | Browser Forward key.                                     |
| BROWSER_HOME                       | Browser Start and Home key.                              |
| BROWSER_REFRESH                    | Browser Refresh key.                                     |
| BROWSER_SEARCH                     | Browser Search key.                                      |
| BROWSER_STOP                       | Browser Stop key.                                        |
| C                                  | C key.                                                    |
| CANCEL                             | Control-break processing.                                |
| CAPITAL                            | CAPS LOCK key.                                           |
| CLEAR                              | CLEAR key.                                                |
| CONTROL                            | CONTROL key.                                             |
| CONVERT                            | IME convert.                                             |
| CRSEL                              | CrSel key.                                               |
| D                                  | D key.                                                    |
| DECIMAL                            | Decimal key.                                             |
| DELETE                             | DEL key.                                                  |
| DIVIDE                             | Divide key.                                              |
| DOWN                               | DOWN ARROW key.                                          |
| E                                  | E key.                                                    |
| END                                | END key.                                                  |
| EREOF                              | Erase EOF key.                                           |
| ESCAPE                             | ESC key.                                                  |
| EXECUTE                            | EXECUTE key.                                             |
| EXSEL                              | ExSel key.                                               |
| F                                  | F key.                                                    |
| F1                                 | F1 Key.                                                  |
| F10                                | F10 Key.                                                 |
| F11                                | F11 Key.                                                 |
| F12                                | F12 Key.                                                 |
| F13                                | F13 Key.                                                 |
| F14                                | F14 Key.                                                 |
| F15                                | F15 Key.                                                 |
| F16                                | F16 Key.                                                 |
| F17                                | F17 Key.                                                 |
| F18                                | F18 Key.                                                 |
| F19                                | F19 Key.                                                 |
| F2                                 | F2 Key.                                                  |
| F20                                | F20 Key.                                                 |
| F21                                | F21 Key.                                                 |
| F22                                | F22 Key.                                                 |
| F23                                | F23 Key.                                                 |
| F24                                | F24 Key.                                                 |
| F3                                 | F3 Key.                                                  |
| F4                                 | F4 Key.                                                  |
| F5                                 | F5 Key.                                                  |
| F6                                 | F6 Key.                                                  |
| F7                                 | F7 Key.                                                  |
| F8                                 | F8 Key.                                                  |
| F9                                 | F9 Key.                                                  |
| FINAL                              | IME final mode.                                          |
| G                                  | G key.                                                    |
| H                                  | H key.                                                    |
| HANGEUL                            | IME Hangeul mode (maintained for compatibility; use User32.VirtualKey.HANGUL). |
| HANGUL                             | IME Hangul mode.                                         |
| HANJA                              | IME Hanja mode.                                          |
| HELP                               | HELP key.                                                 |
| HOME                               | HOME key.                                                 |
| I                                  | I key.                                                    |
| ICO_00                             | OEM specific.                                            |
| ICO_CLEAR                          | OEM specific.                                            |
| ICO_HELP                           | OEM specific.                                            |
| INSERT                             | INS key.                                                  |
| J                                  | J key.                                                    |
| JUNJA                              | IME Junja mode.                                          |
| K                                  | K key.                                                    |
| KANA                               | IME Kana mode.                                           |
| KANJI                              | IME Kanji mode.                                          |
| KEY_0                              | 0 key.                                                   |
| KEY_1                              | 1 key.                                                   |
| KEY_2                              | 2 key.                                                   |
| KEY_3                              | 3 key.                                                   |
| KEY_4                              | 4 key.                                                   |
| KEY_5                              | 5 key.                                                   |
| KEY_6                              | 6 key.                                                   |
| KEY_7                              | 7 key.                                                   |
| KEY_8                              | 8 key.                                                   |
| KEY_9                              | 9 key.                                                   |
| L                                  | L key.                                                    |
| LAUNCH_APP1                        | Start Application 1 key.                                 |
| LAUNCH_APP2                        | Start Application 2 key.                                 |
| LAUNCH_MAIL                        | Start Mail key.                                          |
| LAUNCH_MEDIA_SELECT                | Select Media key.                                        |
| LBUTTON                            | Left mouse button.                                       |
| LCONTROL                           | Left CONTROL key.                                        |
| LEFT                               | LEFT ARROW key.                                          |
| LMENU                              | Left MENU key.                                           |
| LSHIFT                             | Left SHIFT key.                                          |
| LWIN                               | Left Windows key.                                        |
| M                                  | M key.                                                    |
| MBUTTON                            | Middle mouse button (three-button mouse).                |
| MEDIA_NEXT_TRACK                   | Next Track media key.                                    |
| MEDIA_PLAY_PAUSE                   | Play/Pause media key.                                    |
| MEDIA_PREV_TRACK                   | Previous Track media key.                                |
| MEDIA_STOP                         | Stop media key.                                          |
| MENU                               | ALT key.                                                  |
| MODECHANGE                         | Mode change key.                                         |
| MULTIPLY                           | Multiply key.                                            |
| N                                  | N key.                                                    |
| NEXT                               | Next key.                                                |
| NONAME                             | No name key.                                             |
| NUMLOCK                            | NUM LOCK key.                                            |
| NUMPAD0                            | Numeric keypad 0 key.                                    |
| NUMPAD1                            | Numeric keypad 1 key.                                    |
| NUMPAD2                            | Numeric keypad 2 key.                                    |
| NUMPAD3                            | Numeric keypad 3 key.                                    |
| NUMPAD4                            | Numeric keypad 4 key.                                    |
| NUMPAD5                            | Numeric keypad 5 key.                                    |
| NUMPAD6                            | Numeric keypad 6 key.                                    |
| NUMPAD7                            | Numeric keypad 7 key.                                    |
| NUMPAD8                            | Numeric keypad 8 key.                                    |
| NUMPAD9                            | Numeric keypad 9 key.                                    |
| O                                  | O key.                                                    |
| OEM_1                              | Used for miscellaneous characters; it can vary by keyboard. |
| OEM_102                            | Either the angle bracket key or the backslash key on the RT 102-key keyboard. |
| OEM_2                              | Used for miscellaneous characters; it can vary by keyboard. |
| OEM_3                              | Used for miscellaneous characters; it can vary by keyboard. |
| OEM_4                              | Used for miscellaneous characters; it can vary by keyboard. |
| OEM_5                              | Used for miscellaneous characters; it can vary by keyboard. |
| OEM_6                              | Used for miscellaneous characters; it can vary by keyboard. |
| OEM_7                              | Used for miscellaneous characters; it can vary by keyboard. |
| OEM_8                              | Used for miscellaneous characters; it can vary by keyboard. |
| OEM_ATTN                           | Attn key.                                                |
| OEM_AUTO                           | Auto key.                                                |
| OEM_AX                             | AX key.                                                  |
| OEM_BACKTAB                        | Back Tab key.                                            |
| OEM_CLEAR                          | CLEAR key.                                               |
| OEM_COMMA                          | Comma key.                                               |
| OEM_COPY                           | Copy key.                                                |
| OEM_CUSEL                          | CUSEL key.                                               |
| OEM_ENLW                           | Enlarge Window key.                                      |
| OEM_FINISH                         | Finish key.                                              |
| OEM_FJ_LOYA                        | Loya key on Fujitsu Japan keyboards.                     |
| OEM_FJ_MASSHOU                     | Masshou key on Fujitsu Japan keyboards.                  |
| OEM_FJ_ROYA                        | Roya key on Fujitsu Japan keyboards.                     |
| OEM_FJ_TOUROKU                     | Touroku key on Fujitsu Japan keyboards.                  |
| OEM_JUMP                           | Jump key.                                                |
| OEM_MINUS                          | Minus key.                                               |
| OEM_PA1                            | PA1 key.                                                 |
| OEM_PA2                            | PA2 key.                                                 |
| OEM_PA3                            | PA3 key.                                                 |
| OEM_PERIOD                         | Period key.                                              |
| OEM_PLUS                           | Plus key.                                                |
| OEM_RESET                          | Reset key.                                               |
| OEM_WSCTRL                         | WSCTRL key.                                              |
| P                                  | P key.                                                    |
| PA1                                | PA1 key.                                                 |
| PA2                                | PA2 key.                                                 |
| PA3                                | PA3 key.                                                 |
| PACKED                             | Used to pass Unicode characters as if they were keystrokes. |
| PAINT                              | Paint key.                                               |
| PRINT                              | PRINT key.                                               |
| PRINTSCREEN                        | PRINT SCREEN key.                                        |
| PROCESSKEY                         | IME PROCESS key.                                         |
| Q                                  | Q key.                                                    |
| R                                  | R key.                                                    |
| RBUTTON                            | Right mouse button.                                      |
| RCONTROL                           | Right CONTROL key.                                       |
| RETURN                             | ENTER key.                                               |
| RIGHT                              | RIGHT ARROW key.                                         |
| RMENU                              | Right MENU key.                                          |
| RSHIFT                             | Right SHIFT key.                                         |
| RWIN                               | Right Windows key.                                       |
| S                                  | S key.                                                    |
| SCROLL                             | SCROLL LOCK key.                                         |
| SELECT                             | SELECT key.                                              |
| SELECTMEDIA                        | Select Media key.                                        |
| SEPARATOR                          | Separator key.                                           |
| SHIFT                              | SHIFT key.                                               |
| SNAPSHOT                           | PRINT SCREEN key.                                        |
| SPACE                              | SPACEBAR.                                                |
| SUBTRACT                           | Subtract key.                                            |
| T                                  | T key.                                                    |
| TAB                                | TAB key.                                                  |
| U                                  | U key.                                                    |
| UP                                 | UP ARROW key.                                            |
| V                                  | V key.                                                    |
| VOLUME_DOWN                        | Volume Down media key.                                   |
| VOLUME_MUTE                        | Volume Mute media key.                                   |
| VOLUME_UP                          | Volume Up media key.                                     |
| W                                  | W key.                                                    |
| X                                  | X key.                                                    |
| XBUTTON1                           | X1 mouse button.                                         |
| XBUTTON2                           | X2 mouse button.                                         |
| Y                                  | Y key.                                                    |
| Z                                  | Z key.                                                    |
| ZOOM                               | Zoom key.                                                |
Table was taken from [here](https://goatcorp.github.io/Dalamud/api/Dalamud.Game.ClientState.Keys.VirtualKey.html)
