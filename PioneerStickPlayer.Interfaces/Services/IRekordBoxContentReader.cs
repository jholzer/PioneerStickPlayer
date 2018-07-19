using PioneerStickPlayer.Interfaces.Model;

namespace PioneerStickPlayer.Interfaces.Services
{
    public interface IRekordBoxContentReader
    {
        RekordBoxContent ReadContent(string pdbFilePath);
    }
}