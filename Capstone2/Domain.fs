module Capstone2.Domain

open System

type Customer =
    { Name: string }
    
type balance = decimal

type Account =
    { Id: Guid
      Balance: balance
      Owner: Customer }

// Deposits an amount into an account
type OperationFunc = balance -> Account -> Account

let deposit (amount:balance) (account: Account) : Account =
    { Id = Guid.Empty
      Balance = account.Balance + amount
      Owner = { Name = "Sam" } }
    
let withdraw (amount:balance) (account: Account) : Account =
    { Id = Guid.Empty
      Balance = account.Balance - amount
      Owner = { Name = "Sam" } }