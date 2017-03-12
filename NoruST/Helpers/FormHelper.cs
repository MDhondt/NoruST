using System.Windows.Forms;

namespace NoruST
{
    /// <summary>
    /// <para>Helpers.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 13, 2016</para>
    /// </summary>
    internal static class FormHelper
    {
        /// <summary>
        /// Show the <see cref="Form"/>. This method will prevent the existence of multiple instances of the <see cref="Form"/> at a time.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="Form"/>.</typeparam>
        /// <param name="form">The <see cref="Form"/> that should be shown.</param>
        /// <returns>The instance of the shown <see cref="Form"/>.</returns>
        /// <remarks>If the Forms are shown on a weird place or on a second monitor, check the comments in the code.</remarks>
        public static T ShowForm<T>(this T form) where T : Form, new()
        {
            // Check if the Form already exists. Create it if not.
            if (form == null || form.IsDisposed)
                form = new T();

            // Check if the Form is already visible.
            if (form.Visible == false)
                // Show the Form if it isn't.
                // ----- If the Forms are shown on a weird place or on a second monitor, uncomment the line below ('form.Show(...);') and comment the line below that ('form.Show();').
                // form.Show(new WindowImplementation(new IntPtr(Globals.ThisAddIn.Application.Windows[1].Hwnd)));
                form.Show();
            else
                // Refresh if it is.
                form.Refresh();

            // Bring the Form to the front.
            form.BringToFront();

            // Return the Form.
            return form;
        }
    }
}