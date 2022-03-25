namespace LanguageReview

    module Functions = 

        let func1 x = 
            x * x 

        func1 12

        12 |> func1 

        let func02 () = printfn "Print Mensagem"

        let func2 = 
            (fun x -> printfn $"{x}")  

        func2 "Imprimindo minha mensagem teste"

        let func3 x y = 
            x * y

        
        let func4 = func3 12 12

        func4

        let func5 (x, y) = 
            x * y

        let func6 () = 
            (fun x -> x * x)     

        func6() 55

        let func7 f x = 
            f x 

        func7 (fun x -> x * x) 6     

        func5 (6,7)           


        let qtdePct = 10
        let qtdePctAv = 20
        let qtdeUtilizada = 10

        let total qtdePct qtdePctAv = qtdePct + qtdePctAv

        let bloqueio =
            let limite = (fun qtdePct qtdePctAv -> qtdePct + qtdePctAv) qtdePct qtdePctAv
            let quantidade = (fun qtde -> qtde) qtdeUtilizada

            if quantidade > limite then "bloqueado" else "Liberado"



