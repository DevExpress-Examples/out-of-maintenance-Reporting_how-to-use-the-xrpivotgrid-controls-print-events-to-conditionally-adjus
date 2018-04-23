using System;
using System.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UI.PivotGrid;
// ...

namespace XRPivotGridEvents {
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrPivotGrid1_PrintCell(object sender, CustomExportCellEventArgs e) {
            if (e.ColumnIndex == 1 && Convert.ToDouble(e.Value) > 50) {
                e.Appearance.BackColor = Color.AliceBlue;
            }
        }

        private void xrPivotGrid1_PrintFieldValue(object sender, CustomExportFieldValueEventArgs e) {
            if (e.Text != "Condiments") {
                e.Appearance.BackColor = Color.Beige;
            }
        }

        private void xrPivotGrid1_PrintHeader(object sender, CustomExportHeaderEventArgs e) {
            if (e.Caption == "Quantity") {
                e.Appearance.BackColor = Color.AliceBlue;
            }
        }

    }
}
