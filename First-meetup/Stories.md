## Business goal:-

PeopleSoft bank is entering the banking business. They want to offer account management features to their customers. The customers should be able to open account, deposit and withdraw money in the account. The company wants to develop a minimum viable product, whose name is "Account Buddy"

Let's take look at the stories:-
#### Open an account ![#c5f015](https://placehold.it/15/c5f015/000000?text=+) `(Story completed)`
  * User specifies his basic details such as name, unique identification number and address.
  * The system registers this information and issues an auto-generated account number to the customer.
  * By default, when the account is registered, the account is in the active state.
  * The rate of interest for senior citizens (age greater than equal to 60) would be 8%.
  * The rate of interest for others would be 7%.

#### Freezing of an account
  * The customer has to perform frequent transactions to keep the account active. 
  * By default, an account without any transaction activity for last 180 days goes into the FROZEN state.
  
#### Deposit money in an active account ![#c5f015](https://placehold.it/15/c5f015/000000?text=+) `(Story completed)`
  * The customer should be able to deposit money in an account.
  * The system should display an updated account balance, once money is deposited.

#### Deposit money in a frozen account ![#c5f015](https://placehold.it/15/c5f015/000000?text=+) `(Story completed)`
  * The customer should be able to deposit money in an account.
  * The account should get unfreezed, once money is deposited.
  * The system should display an updated account balance, once money is deposited.

#### Withdraw money from an active account ![#c5f015](https://placehold.it/15/c5f015/000000?text=+) `(Story completed)`
  * The customer should be able to withdraw from an active account.

#### Withdraw money from an active account with insufficient balance ![#c5f015](https://placehold.it/15/c5f015/000000?text=+) `(Story completed)`
  * The system should notify the customer of the money being withdrawn is less than account balance. (Credit is not supported in first version)
  
#### Withdraw money from a frozen account ![#c5f015](https://placehold.it/15/c5f015/000000?text=+) `(Story completed)`
  * The system should not allow a customer to withdraw money from a frozen account.
