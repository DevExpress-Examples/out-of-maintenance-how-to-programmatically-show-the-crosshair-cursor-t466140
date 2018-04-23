using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace ShowCrosshair {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        
        #region #ShowCrosshair
        private void OnChartMouseUp(object sender, MouseEventArgs e) {
            XYDiagram xyDiagram = chartControl.Diagram as XYDiagram;
            if(xyDiagram == null) return;

            xyDiagram.ShowCrosshair(e.Location);
        }
        #endregion #ShowCrosshair
    }
}
