Business goal:-

PeopleSoft bank is entering the banking business. They want to offer account management features to their customers. The customers should be able to open account, deposit and withdraw money in the account. The company wants to develop a minimum viable product, whose name is "Account Buddy"

Let's take look at the stories:-
1. Open an account (Story completed)
  a. User specifies his basic details such as name, unique identification number and address.
  b. The system registers this information and issues an auto-generated account number to the customer.
  c. By default, when the account is registered, the account is in the active state.

2. Freezing of an account
  a. The customer has to perform frequent transactions to keep the account active. 
  b. By default, an account without any transaction activity for last 180 days goes into the FROZEN state.
  
3. Deposit money in an active account (Story completed)
  a. The customer should be able to deposit money in an account.
  b. The system should display an updated account balance, once money is deposited.

4. Deposit money in a frozen account
  a. The customer should be able to deposit money in an account.
  b. The account should get unfreezed, once money is deposited.
  c. The system should display an updated account balance, once money is deposited.

5. Withdraw money from an active account
  a. The customer should be able to withdraw from an active account.

6. Withdraw money from an active account with insufficient balance
  a. The system should notify the customer of the money being withdrawn is less than account balance. (Credit is not supported in first version)
  
7. Withdraw money from a frozen account
  a. The system should not allow a customer to withdraw money from a frozen account.
