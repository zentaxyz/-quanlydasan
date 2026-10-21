using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace quanlydatsan
{
    public class DateTimePicker30Phut : DateTimePicker
    {
        private DateTime giaTriCu;
        private bool dangDieuChinh;

        public DateTimePicker30Phut()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "HH:mm";
            ShowUpDown = true;
            giaTriCu = Value;
        }

        protected override void OnValueChanged(EventArgs e)
        {
            if (dangDieuChinh)
            {
                giaTriCu = Value;
                base.OnValueChanged(e);
                return;
            }

            DateTime giaTriMoi = Value;
            TimeSpan chenhLech = giaTriMoi - giaTriCu;

            if (chenhLech == TimeSpan.FromMinutes(1) ||
                chenhLech == TimeSpan.FromMinutes(-1) ||
                chenhLech == TimeSpan.FromMinutes(59))
            {
                
                DateTime giaTriDung = giaTriCu.AddMinutes(
                    chenhLech == TimeSpan.FromMinutes(1) ? 30 : -30
                );

                dangDieuChinh = true;
                Value = giaTriDung;
                dangDieuChinh = false;

                giaTriCu = Value;
                return;
            }

            giaTriCu = giaTriMoi;
            base.OnValueChanged(e);
        }
    }
}