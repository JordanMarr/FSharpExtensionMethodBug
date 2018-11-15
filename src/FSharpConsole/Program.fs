open CsharpProjWithExt

[<EntryPoint>]
let main argv = 

    let dir = new System.IO.DirectoryInfo("C:\temp")

    // Intellisense fails when dotting into "dir" fails once "CsharpProjWithExt" is opened.
    // Commenting out the open statement (or commenting out the extension method) restores intellisense.
    let parentName = dir.Parent.FullName

    0
