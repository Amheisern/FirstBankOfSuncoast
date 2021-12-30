# FirstBankOfSuncoast

P: user needs to be able to add and subtract from a given sum. User cannot be allowed to take those given sums less that zero. the addition and subtraction of the sum or transaction should be stored in a single list.  
E:
D:
A:
C: \***\*\*\*\*\*\*\***\_\_\_\_\***\*\*\*\*\*\*\*** Assignments**\*\***\*\*\*\***\*\***\_\_\_\_**\*\***\*\*\*\***\*\***
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
