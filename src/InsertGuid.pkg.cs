using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace InsertGuid
{
    using Luminous.Framework.VisualStudio.Packages;
    using Commands;

    using static PackageGuids;
    using static Vsix;

    [InstalledProductRegistration("110", "112", Version, IconResourceID = 400)]
    [Guid(InsertGuidPackageString)]

    public sealed class InsertGuidPackage : PackageBase
    {
        public InsertGuidPackage() : base(InsertGuidCommandSet, Name, Description)
        { }

        protected override void Initialize()
        {
            base.Initialize();

            InsertGuidCommand.Instantiate(this);
        }
    }
}
