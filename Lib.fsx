let escape =
    String.collect (function
        | '#' | '!' | '(' | ')' | '`' | ':' -> ""
        | ' '  | '/' | '.' -> "-"
        | c -> string c
    )
