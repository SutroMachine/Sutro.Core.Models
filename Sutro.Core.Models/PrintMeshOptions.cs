using Sutro.Core.Models.Profiles;

namespace Sutro.Core.Models
{
    /// <summary>
    /// Options for PrintMeshAssembly meshes
    /// </summary>
    public class PrintMeshOptions
    {
        public IMaterialProfile MaterialProfile { get; set; }

        public IPartProfile PartProfile { get; set; }

        /// <summary>
        /// Treat the mesh as volume that should contain supports
        /// </summary>
        public bool IsSupport { get; set; } = false;

        /// <summary>
        /// Treat the mesh as volume that should be a void in the part
        /// </summary>
        public bool IsCavity { get; set; } = false;

        /// <summary>
        /// Treat the mesh as a volume that should be removed from the main part mesh.
        /// </summary>
        public bool IsCropRegion { get; set; } = false;

        /// <summary>
        /// Treat the mesh as an open mesh (i.e. deposit material along part boundary and do not fill)
        /// </summary>
        public bool IsOpen { get; set; } = false;

        public double ClearanceXY { get; set; } = 0;
        public double OffsetXY { get; set; } = 0;

        public OpenPathsModes OpenPathMode { get; set; }

        public object Extended { get; set; } = null;

        public PrintMeshOptions DeepCopy()
        {
            return new PrintMeshOptions()
            {
                IsSupport = IsSupport,
                IsCavity = IsCavity,
                IsCropRegion = IsCropRegion,
                IsOpen = IsOpen,
                OpenPathMode = OpenPathMode
            };
        }
    }
}