// Plan (pseudocode):
// 1. Provide the missing Form1_Load event handler so the designer's `Load += Form1_Load;` call compiles.
// 2. Keep the partial class declaration (no base class) to match the existing partial Form1 defined elsewhere.
// 3. Implement `private void Form1_Load(object sender, EventArgs e)` with minimal, safe initialization:
//    - Set label texts to empty strings (or a safe default) so the UI shows predictable values.
// 4. Add required using directives for EventArgs and Windows Forms types.
// 5. Do not modify the designer file or other parts of the code.

using System;
using System.Windows.Forms;

namespace Harjoitus_4
{
    public partial class Form1
    {
        // This method resolves CS0103: The name 'Form1_Load' does not exist in the current context
        // It is wired up in the designer: Load += Form1_Load;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Minimal safe initialization for the labels created by the designer.
            // Adjust these defaults as needed by your application logic.
            if (VuodetLB != null) VuodetLB.Text = string.Empty;
            if (KuukaudetLB != null) KuukaudetLB.Text = string.Empty;
            if (PaivatLB != null) PaivatLB.Text = string.Empty;
            if (TunnitLB != null) TunnitLB.Text = string.Empty;
            if (MinuutitLB != null) MinuutitLB.Text = string.Empty;
            if (SekunnitLB != null) SekunnitLB.Text = string.Empty;
        }
    }
}