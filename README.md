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

# How to Run

1. Clone the code and Build the Solution
2. Go to this folder: ..\..\ATM-Challenge\ATM\ATM\bin\Debug\net5.0

![image](https://user-images.githubusercontent.com/54826498/153210787-095f0f26-dec2-4b43-8f99-263d5a73e3cf.png)

3. Open Terminal Here

![image](https://user-images.githubusercontent.com/54826498/153211641-f22950ac-8021-42ae-8c4d-4868c32bdd73.png)

4.Params to send: (Name, Balance, n1, n5, n10, n20, n50, n100)

Name -> (string) Name of Account

Balance -> (int) The Balance of Account

n1 -> (int) represents how many bills of 1 are inside the ATM

n5 -> (int) represents how many bills of 5 are inside the ATM

n10 -> (int) represents how many bills of 10 are inside the ATM

n20 -> (int) represents how many bills of 20 are inside the ATM

n50 -> (int) represents how many bills of 50 are inside the ATM

n100 -> (int) represents how many bills of 100 are inside the ATM

5. Run the Command:  start ATM.exe (Name, Balance, n1, n5, n10, n20, n50, n100)

   Example: 
   
   start ATM.exe Gabriel 100 10 10 40 20 10 10
   
   ![image](https://user-images.githubusercontent.com/54826498/153214666-cd9d4a7e-8898-49cb-93ea-126161bee631.png)
   
6. Type the amount to Withdraw: 

![image](https://user-images.githubusercontent.com/54826498/153216697-05e1f428-5c69-446e-a8ad-c498bfdaa829.png)


And Done!!
