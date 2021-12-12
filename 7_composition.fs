let vat n x = if n > 0 && n <= 100 then x * float(n + 100) / 100.0 else x

let unvat n x = if n > 0 && n <= 100 then x / float(n + 100) * 100.0 else x

let rec min f =
  let rec loop i = if f i = 0 then i else loop(i + 1)
  loop 0
