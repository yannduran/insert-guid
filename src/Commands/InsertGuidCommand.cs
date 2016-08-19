using Microsoft.VisualStudio.Shell;

using static System.Guid;

namespace InsertGuid.Commands
{
    using Luminous.Framework.VisualStudio.Commands;
    using Luminous.Framework.VisualStudio.Packages;

    internal sealed class InsertGuidCommand : DynamicCommand
    {
        //***

        private static int CommandId
            => PackageIds.InsertGuidCommand;

        //===M

        private InsertGuidCommand(PackageBase package) : base(package, CommandId)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new InsertGuidCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
        => ExecuteCommand()
            .ShowProblem()
            .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package.ReplaceSelectedText(() => $"{NewGuid().ToString()}",
                prefix: "", suffix: "",
                problem: "Unable to insert guid");

        //***
    }
}