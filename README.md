# ATM-Challenge

Console App -> ATM
 
set initial amount with string args
 
Notes of 1, 5, 10, 20, 50, 100
 
Operation: Withdraw -> always return as few notes as possible
 
For example:
 
if the ATM has 10 notes (5), and I ask to withdraw 10, return 2 notes (5)

if the ATM has 10 bills of (1) and 10 bills of (5) and I ask to withdraw 7, it returns 1 bill of (5) and 2 bills of (1)

if the ATM has 1 bill of (100) and 5 bills of (50) and I ask to withdraw 100, it returns 1 bill of (100)

if the ATM has only 1 note of (100) and I ask him to withdraw 50, he does not withdraw

if there is no balance, do not withdraw