// Plan (pseudocode):
// 1. Add a new partial class file for `Form1` in namespace `Harjoitus_4` so the designer's `Load += Form1_Load;` resolves.
// 2. Implement `private void Form1_Load(object sender, EventArgs e)` with the correct EventHandler signature.
// 3. Keep the handler minimal and safe: initialize or clear the label texts created by the designer.
// 4. Do not modify the designer file; place this in a separate file that compiles with the rest of the project.
// 5. Include necessary using directives for `System` and `System.Windows.Forms`.
//
// This resolves CS0103: The name 'Form1_Load' does not exist in the current context.

using System;
using System.Windows.Forms;

namespace Harjoitus_4
{
    public partial class Form1
    {
        // Wired by the designer: Load += Form1_Load;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Safe minimal initialization for designer-created controls.
            if (VuodetLB != null) VuodetLB.Text = string.Empty;
            if (KuukaudetLB != null) KuukaudetLB.Text = string.Empty;
            if (PaivatLB != null) PaivatLB.Text = string.Empty;
            if (TunnitLB != null) TunnitLB.Text = string.Empty;
            if (MinuutitLB != null) MinuutitLB.Text = string.Empty;
            if (SekunnitLB != null) SekunnitLB.Text = string.Empty;
        }
    }
}