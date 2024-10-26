Backend contains 3 projects in folder ShoppingApp:  AuthAPI, ProductAPI, ShoppingCartAPI. 
Using F5 key you'll run each service separatley.

To Run client project: shopping-app open it in VSCode and in terminal use commands: 
yarn install, and yarn serve to run app.

Backend: 
Each project has it's own sqlite database. 
In ProductAPI and AuthAPI databases prefilled with some dummy data.
Each service run on its own url:
	AuthAPI - https://localhost:7001
	ProductAPI - https://localhost:7000
	ShoppingCartAPI - https://localhost:7002

ShoppingCartAPI has relation with services:  ProductAPI, AuthAPI.
In ShoppingCartAPI you can find ProductService it helps to receive list of products from ProductAPI
and use this products to get specific product by ProductId for CartTotal calculations.

CartDto model contains two pieces: CartHeader and CartDetails.


Frontend application: When user click on Shop link in header, he redirected to the products page,
and load products from ProductAPI, hovering on any of product and clicking it redirect to 
product details page and load full data from end point.
Clicking add to cart button adding this product to the cart items.
Shopping cart functionality implemented only on client side, with helping of Vuex accross 
application.


