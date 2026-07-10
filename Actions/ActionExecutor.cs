using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TrikiControl.Actions;

public sealed class ActionExecutor
{
    [DllImport("user32.dll")]
    private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

    private const uint KEYEVENTF_KEYUP = 0x0002;

    private const byte VK_VOLUME_MUTE = 0xAD;
    private const byte VK_VOLUME_DOWN = 0xAE;
    private const byte VK_VOLUME_UP = 0xAF;
    private const byte VK_MEDIA_NEXT_TRACK = 0xB0;
    private const byte VK_MEDIA_PREV_TRACK = 0xB1;
    private const byte VK_MEDIA_PLAY_PAUSE = 0xB3;

  private const byte VK_UP = 0x26;
  private const byte VK_DOWN = 0x28;
  private const byte VK_LEFT = 0x25;
  private const byte VK_RIGHT = 0x27;


    public void Execute(ActionMapping mapping, double value = 0)
    {
        switch (mapping.Action)
        {
            case ActionType.VolumeUp:
                PressKey(VK_VOLUME_UP, 3);
                break;

            case ActionType.VolumeDown:
                PressKey(VK_VOLUME_DOWN, 3);
                break;

            case ActionType.Mute:
                PressKey(VK_VOLUME_MUTE);
                break;

            case ActionType.PlayPause:
                PressKey(VK_MEDIA_PLAY_PAUSE);
                break;

            case ActionType.NextTrack:
                PressKey(VK_MEDIA_NEXT_TRACK);
                break;

            case ActionType.PreviousTrack:
                PressKey(VK_MEDIA_PREV_TRACK);
                break;

          case ActionType.UpArrow:
                PressKey(VK_UP, 3);
                break;

          case ActionType.DownArrow:
                PressKey(VK_DOWN, 3);
                break;

          case ActionType.LeftArrow:
                PressKey(VK_LEFT, 3);
                break;

          case ActionType.RightArrow:
                PressKey(VK_RIGHT, 3);
                break;


            case ActionType.LaunchApp:
                if (!string.IsNullOrWhiteSpace(mapping.Value))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = mapping.Value,
                        UseShellExecute = true
                    });
                }
                break;
        }
    }

    private static void PressKey(byte key, int count = 1)
    {
        for (var i = 0; i < count; i++)
        {
            keybd_event(key, 0, 0, UIntPtr.Zero);
            keybd_event(key, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
        }
    }
}