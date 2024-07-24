#nullable enable
using GmlCore.Interfaces.Bootstrap;

namespace Gml.Web.Api.Dto.Profile;

public class ProfileRestoreDto
{
    public string Name { get; set; } = null!;
    public IBootstrapProgram? BootstrapProgram { get; set; }
}
