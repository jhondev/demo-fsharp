open System

#load "Domain.fs"
#load "Audit.fs"

open Capstone2.Domain
open Capstone2.Audit

let customer = { Name = "John" }

let account1 =
    { Id = Guid.Empty
      Balance = 90m
      Owner = customer }

// Test out withdraw
let newAccount = account1 |> withdraw 10M
// Test out console auditor
consoleAudit newAccount

// Test auditAs
let account2 =
    { Id = Guid.NewGuid()
      Owner = { Name = "John" }
      Balance = 100M }

let depositWithConsoleAudit = auditAs "deposit" consoleAudit deposit
let withdrawWithConsoleAudit = auditAs "withdraw" consoleAudit withdraw

account2
|> depositWithConsoleAudit 100M
|> withdrawWithConsoleAudit 50M
