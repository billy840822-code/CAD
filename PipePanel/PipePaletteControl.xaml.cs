using System.Windows.Controls;
using Autodesk.AutoCAD.ApplicationServices;

namespace PipePanel
{
    public partial class PipePaletteControl : UserControl
    {
        private int _lastDiameterIndex = 0;
        private int _lastSystemIndex = 0;

        public PipePaletteControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (cmbDiameter.Items.Count == 0)
            {
                foreach (var d in PipeData.Diameters)
                    cmbDiameter.Items.Add(d);
            }

            if (cmbSystem.Items.Count == 0)
            {
                foreach (var s in PipeData.Systems)
                    cmbSystem.Items.Add(s);
            }

            cmbDiameter.SelectedIndex = _lastDiameterIndex;
            cmbSystem.SelectedIndex = _lastSystemIndex;
        }

        private void btnApply_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var diameter = cmbDiameter.SelectedItem as string;
            var system = cmbSystem.SelectedItem as string;

            if (diameter == null || system == null)
            {
                txtStatus.Text = "Status: No selection";
                return;
            }

            _lastDiameterIndex = cmbDiameter.SelectedIndex;
            _lastSystemIndex = cmbSystem.SelectedIndex;

            string message = $"\nDiameter: {diameter} | System: {system}\n";

            var doc = Application.DocumentManager.MdiActiveDocument;
            if (doc != null)
                doc.Editor.WriteMessage(message);

            txtStatus.Text = $"Status: Applied";
        }

        private void btnReset_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            cmbDiameter.SelectedIndex = 0;
            cmbSystem.SelectedIndex = 0;
            _lastDiameterIndex = 0;
            _lastSystemIndex = 0;
            txtStatus.Text = "Status: Ready";
        }
    }
}
