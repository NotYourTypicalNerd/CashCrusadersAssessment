Few things to note:
1. The concept of Orderline was new to me. Wasn’t very sure how that ties up to an order so I created a M:M relationship(“Junction table”) between Order and Orderline
2. There was not enough time to create unit tests for this project(only had day left). The second task however has some tests 
3. Styling:
a. Prefer to use fontawesome library and also to use jquery to add “Order Line Items”. However, takes time to add manually do jQuery with a few hours to spare. Decided to instead “post to server”, so to speak.
Concerns:
1. I would not normally create a sales table. The information in there can be inferred from a View/Stored Proc. However, there was explicit instruction to create this table, which sort of threw me off a bit.
Please let me know if there is anything else.
