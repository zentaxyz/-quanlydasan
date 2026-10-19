using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace quanlydatsan
{
    public class DateTimePicker30Phut : DateTimePicker
    {
        private const int WM_NOTIFY = 0x004E;
        private const int UDN_DELTAPOS = -722;
        [StructLayout(LayoutKind.Sequential)]
        private struct NMHDR
        {
            public IntPtr hwndFrom;
            public IntPtr idFrom;
            public int code;
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct NMUPDOWN
        {
            public NMHDR hdr;
            public int iPos;
            public int iDelta;
        }

        public DateTimePicker30Phut()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "HH:mm";
            ShowUpDown = true;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NOTIFY && m.LParam != IntPtr.Zero)
            {
                NMHDR hdr = Marshal.PtrToStructure<NMHDR>(m.LParam);

                if (hdr.code == UDN_DELTAPOS)
                {
                    NMUPDOWN data =Marshal.PtrToStructure<NMUPDOWN>(m.LParam);Value = Value.AddMinutes(data.iDelta < 0 ? 30 : -30);
                    m.Result = (IntPtr)1;
                    return;
                }
            }

            base.WndProc(ref m);
        }
    }
}