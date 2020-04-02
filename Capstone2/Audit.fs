module Capstone2.Audit

open Capstone2.Domain

type AuditFunc = Account -> string -> unit

let consoleAudit account message =
    printfn "Account: %A: %s" account.Id message

let auditAs (operationName: string) (audit: AuditFunc) (operation: OperationFunc) (amount: balance) (account: Account): Account =
    audit account (sprintf "Performing a %s operation for $%M" operationName amount)
    let newAccount = operation amount account
    audit account (sprintf "Transaction accepted! Balance is now $%M" newAccount.Balance)
    newAccount
