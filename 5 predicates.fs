// 16.1
let notDivisible (n, m) =  m % n = 0

// 16.2
let prime n = 
    let rec check i = i > n/2 || (n % i <> 0 && check (i + 1))
    check 2
