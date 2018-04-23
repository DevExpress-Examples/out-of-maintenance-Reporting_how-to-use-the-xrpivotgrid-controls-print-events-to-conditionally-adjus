using System;
using System.Drawing;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraReports.UI;
// ...

namespace XRPivotGridEvents {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrPivotGrid1_PrintCell(object sender, DevExpress.XtraReports.UI.PivotGrid.CustomExportCellEventArgs e) {
            if (e.ColumnIndex == 1 && Convert.ToDouble(e.Value) > 50) {
                e.Brick.BackColor = Color.AliceBlue;
            }
        }

        private void xrPivotGrid1_PrintFieldValue(object sender, DevExpress.XtraReports.UI.PivotGrid.CustomExportFieldValueEventArgs e) {
            if (e.Text != "Condiments") {
                e.Brick.BackColor = Color.Beige;
            }
        }

        private void xrPivotGrid1_PrintHeader(object sender, DevExpress.XtraReports.UI.PivotGrid.CustomExportHeaderEventArgs e) {
            if (e.Caption == "Quantity") {
                e.Brick.BackColor = Color.AliceBlue;
            }
        }

    }
}
