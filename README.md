# FirstBankOfSuncoast

P: user needs to be able to add and subtract from a given sum. User cannot be allowed to take those given sums less that zero. the addition and subtraction of the sum or transaction should be stored in a single list.  
E:user balance in savings and checking starts at 100 dollars.
user adds 100 dollars to check and new checking balance is 100 + 100 = 200
user withdraws 101 dollars from savings the user would be directed to try again since it would lead to a neg. balance
list<>

D:
class Transaction

1. Load transaction CSV (should there be two different csv for saving and checking)
2. Save transaction CSV
3. update account object checking
4. update account object savings
5. Display balance
6. Display transactions (refer to the question at 1.)

---------Account object---------
Name
Date account was created
Checking Balance
Saving Balance

---

Greeting

Menu
(C)hecking
(S)aving
(T)ransfer

Checking/Saving account
Your checking balance is {checkingBalance}
(D)eposit
Please enter how much you would like to deposit
Thank for your patronage
(W)ithdraw
Please enter how much you would like to withdraw
add console readline to list and SUM list
Your new balance is {checkingBalance}
if withdraw amount > balance: display sorry the withdraw amount exceeds your current Balance!
Please type in another number

A:
C:

\***\*\*\*\*\*\*\***\_\_\_\_\***\*\*\*\*\*\*\*** Assignments**\*\***\*\*\*\***\*\***\_\_\_\_**\*\***\*\*\*\***\*\***
Explorer Mode

    The application should store a history of transactions in a SINGLE List<Transaction>. Your task is to design the Transaction class to support both checking and savings as well as deposits and withdraws.
    The application should load past transactions from a file when it first starts.
    As a user I should be able to see the list of transactions designated savings.
    As a user I should be able to see the list of transactions designated checking.
    Never allow withdrawing more money than is available. That is, we cannot allow our checking or savings balances to go negative.
    When prompting for an amount to deposit or withdraw always ensure the amount is positive. The value we store in the Transaction shall be positive as well. (e.g. a Transaction that is a withdraw of 25 both inputs and records a positive 25)
    As a user I should have a menu option to make a deposit transaction for savings.
    As a user I should have a menu option to make a deposit transaction for checking.
    As a user I should have a menu option to make a withdraw transaction for savings.
    As a user I should have a menu option to make a withdraw transaction for checking.
    As a user I should have a menu option to see the balance of my savings and checking.
    The application should, after each transaction, write all the transactions to a file. This is the same file the application loads.

Adventure Mode

    Add the ability to transfer funds from my checking to my saving.
    Add the ability to transfer funds from my savings to my checking.
