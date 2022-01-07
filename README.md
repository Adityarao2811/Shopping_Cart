# Shopping_Cart
Create a basic happy flow shopping cart implementation.
1) Create ICart interface which has declarations of methods AddToCart, RemoveFromCart, DisplayCart, ClearCart and Checkout.
2) Implement the ICart interface in Cart class.
3) Store inventory in a text file and show it to the user.
4) User experience : 
	a) User is asked to enter his name and email id.
	b) User is shown the inventory list.
	c) User is given 7 options : add to cart, remove from cart, view cart, clear cart, checkout, view inventory list again, exit
	b) For add and remove operations, user should enter both item code and quantity. Every request should be validated before it is processed.
	c) After every choice user enters, after it is processed, a confirmation/success message should be shown to the user.
5) After user checks out, a comfirmation message with the summary of his cart has to be displayed.
6) In phase 2, we can integrate SMTP and send an order confirmation mail to user's email id.