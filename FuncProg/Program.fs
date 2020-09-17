// Learn more about F# at http://fsharp.org

open System
open System.IO

let fileInputPath = @"D:\Visual Studio Project\FuncProg\FuncProg\File\master.txt"
let fileOutPath = @"D:\Visual Studio Project\FuncProg\FuncProg\File\out.txt"

//Лаба 1
//8. Для заданного списка слов найти слова, не содержащие буквы Е
let lab1 (main) =
     let words = ["HELLO"; "HOW"; "ARE"; "YOU"; "PeTeR"]        
     words |> List.iter( fun i -> if  i.Contains('E') = false then printf "%s\n" i)        
     0
[<EntryPoint>]
//Лаба 2
//11. В данном текстовом файле выделить каждое второе слово и найти самую часто встречающуюся в них букв
let lab2(main) =
    let readLines filePath = File.ReadLines(filePath)
                                |> Seq.map(fun l -> l.Split ' ')
                                |> Seq.concat
    let text = readLines(fileInputPath)

    let  mutable lst = []
    text |> Seq.iteri(fun i s ->  if i % 2 = 0 then lst <- s :: lst)

    let mostFrequentChar = text
                            |> Seq.map(fun s -> s |> Seq.toList)
                            |> Seq.concat
                            |> Seq.countBy(fun c -> c)
                            |> Seq.maxBy (fun g -> snd g )  
    File.WriteAllLines(fileOutPath, lst)
    printf "%c %d\n" (fst mostFrequentChar ) (snd mostFrequentChar)        
    0       