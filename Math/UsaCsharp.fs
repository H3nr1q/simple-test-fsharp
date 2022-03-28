namespace UsaCsharp

    module Usa = 
        open StringLibrary

        let main argv = 
            let x = new ExportaParaFsharp()

            x.SomeNumber <- 42.0f

            let notes = x.NotesInTheScale()

            notes 

            |> Seq.iter (printf "%s")