using Microsoft.JSInterop;

namespace SVEC.Pages;

public partial class Form
{
    public int currentCount = 524;

    private void IncrementCount()
    {
        currentCount++;
    }
}