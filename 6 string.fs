// 17.1
let rec pow = function
| (s, 0) -> ""
| (s, 1) -> s
| (s, n) -> s + pow(s, n-1)

// 17.2 
let isIthChar (s: string, n, c) = n >= 0 && n < s.Length && s.[n] = c

// 17.3
let rec occFromIth (s: string, n: int, c: char) =
    let rec loop i count =
        if i >= 0 && i < s.Length then
            if s.[i] = c then loop (i+1) (count+1)
            else loop (i+1) count
        else count
    loop n 0
