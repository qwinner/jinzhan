using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Security.Permissions;
using System.Globalization;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace JinZhan
{
    public enum Authority
    {
        Looker      = 1,
        Manager     = 2,
        Admin       = 3,
    }

    public static class Global
    {
        public static Authority authority = Authority.Looker;

        public static string rbcheck(RadioButton[] rb)
        {
            int tmp;
            for (int i = 0; i < rb.Length; i++)
            {
                if (rb[i].Checked)
                {
                    tmp = i + 1;
                    return tmp.ToString();
                }
            }
            return "-1";
        }


        [DllImport("gdi32.dll")]
        public static extern int CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);

        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hwnd, int hRgn, Boolean bRedraw);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject", CharSet = CharSet.Ansi)]
        public static extern int DeleteObject(int hObject);

        public static void SetFormRoundRectRgn(Form form, int rgnRadius)
        {
            int hRgn = 0;
            hRgn = CreateRoundRectRgn(0, 0, form.Width + 1, form.Height + 1, rgnRadius, rgnRadius);
            SetWindowRgn(form.Handle, hRgn, true);
            DeleteObject(hRgn);
        }
    }

}
