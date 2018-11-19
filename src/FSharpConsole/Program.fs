open CsharpProjWithExt

[<EntryPoint>]
let main argv = 

    let dir = new System.IO.DirectoryInfo("C:\temp")

    // Intellisense fails when dotting into "dir" when the "CsharpProjWithExt" is opened above.
    // Note that the this project does not reference the System.Windows.Forms assembly,
    // but the imported extension method takes a "System.Windows.Forms.Form" argument.
    // Workarounds to restore intellisense include:
    // 1) Commenting out the "open CsharpProjWithExt" statement
    // 2) Commenting out the extension method
    // 3) Referencing the "System.Windows.Forms" assembly in the F# project.
    let parentName = dir.Parent.FullName

    0
