// Learn more about F# at http://fsharp.org

open System
open System.IO

let fileInputPath = @"D:\Visual Studio Project\FuncProg\FuncProg\File\master.txt"
let fileOutPath = @"D:\Visual Studio Project\FuncProg\FuncProg\File\out.txt"
(*
[<EntryPoint>]
//Лаба 1
//8. Для заданного списка слов найти слова, не содержащие буквы Е
let lab1 (main) =
     let words = ["HELLO"; "HOW"; "ARE"; "YOU"; "PeTeR"]        
     words |> List.iter( fun i -> if  i.Contains('E') = false then printf "%s\n" i)        
     0
*)
(*
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
*)
(*
[<EntryPoint>]
// Лаба 3
//14. В массиве A найти сумму элементов, расположенных между минимальным и максимальным элементами массива.
//Пример: для массива A[5]: 3 1 2 4 5 сумма получается равной 6.
let lab3 (main) =
       let mutable arr = [| 3; 1; 2; 4; 5; 1 |]

       let size = Array.length arr - 1
       let mutable indexOfMax = 0
       let mutable indexOfMin = 0
       let mutable sumBtwMaxMin = 0
       
       for i = 1 to size do
           if arr.[indexOfMax] < arr.[i] then
               indexOfMax <- i
               
       for i = 1 to size do
           if arr.[indexOfMin] > arr.[i] then
               indexOfMin <- i

       if indexOfMin > indexOfMax then
            for i = indexOfMax to indexOfMin - 1 do
                sumBtwMaxMin <- sumBtwMaxMin + i
       else     
            for i = indexOfMin to indexOfMax - 1 do
                sumBtwMaxMin <- sumBtwMaxMin + i

       printf "%d" (sumBtwMaxMin)
       0
*)