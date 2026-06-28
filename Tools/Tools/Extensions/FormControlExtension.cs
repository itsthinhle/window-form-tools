namespace Tools.Extensions;

internal static class FormControlExtension
{
    /// <summary>
    /// Only set the text of the form control when it's empty. This is useful when we want to set a default value for the form control, 
    /// but we don't want to override the user's input if they have already entered something.
    /// </summary>
    /// <param name="formControl"></param>
    /// <param name="text"></param>
    public static void SetTextIfEmpty(this Control formControl, string? text)
    {
        if (string.IsNullOrEmpty(formControl.Text))
        {
            formControl.Text = text ?? "";
        }
    }
}
