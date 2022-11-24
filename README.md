# ASP.NET MVC E-Commerce-App
## E-commerce website with basic features
●Listing products on Home Page and Products Page with details.<br />
●Product details page with list of comments for every product. <br />
●Authenticated user adding comment for products.<br />
●Adding products to shopping cart, organize it and complete order.<br />
●User Register, Login, Logout.<br />
●User Page with lists of comments and orders.<br />
●Admin Panel -> Product, Category CRUD operations and Orders State Control by Admin.<br />
●Private Operations for only Authorized users like view comments of all users and delete them.<br />

## Home Page
In Home Page, there is navigation bar which contains other pages links and user section. Below products that are planned to be list on Home Page not all of them. All of the products are listed in Product Page.

<img src="https://user-images.githubusercontent.com/115007582/203781581-61d3637e-aa79-4779-98fb-0cf7dc60e749.png" width=70% height=70%>

## Products Page
Products are listed with details. 

<img src="https://user-images.githubusercontent.com/115007582/203783175-1e3282d9-6aeb-4460-ae65-ae7151fd93cc.png" width=70% height=70%>

<br /><br />
Products are filtered by category.

<img src="https://user-images.githubusercontent.com/115007582/203783179-8532a893-aa12-4c19-a4af-c0be032a7e9c.png" width=70% height=70%>

## Product Details Page
In this page, every product has name, stock, unique id, description, rating and price informations. Customers can add the product to their shopping cart in this page. And also comments for product are listed with user name and date informations. If user is logged in, he/she can add comment for product. Otherwise there is a Write Comment button that redirect to log in Page. Comments are paged with PagedList and using Ajax, page switchs on the web can exchange data with the server without interfering with the existing web view. User can delete any comment of his/her own on this page, Admin can delete any of them.

<img src="https://user-images.githubusercontent.com/115007582/203783184-b58847ef-288f-44a4-8fb5-6c484b407d91.png" width=70% height=70%>

## Shopping Cart Page


<img src="https://user-images.githubusercontent.com/115007582/203783187-67b9ed1b-e229-49b2-9d7f-ed2ba2b58ee4.png" width=70% height=70%>

<img src="https://user-images.githubusercontent.com/115007582/203783190-63816779-9ef7-418f-b989-9fc3ea514c18.png" width=70% height=70%>

## Admin Panel
In this page, admin operations are positioned in nav-bar as Products, Categories, Orders.
In product and category page, there are CRUD(Create-Update-Delete) operations for only admin users. 
Admin can also list all orders in Orders page and change orders' state as Completed or awaiting approval. 


<img src="https://user-images.githubusercontent.com/115007582/203783194-f332cd7c-e338-4b94-9e4f-0938f9f2a896.png" width=70% height=70%>

<img src="https://user-images.githubusercontent.com/115007582/203783199-92936e93-c422-4ac8-92d5-b8b44b99260b.png" width=70% height=70%>

<img src="https://user-images.githubusercontent.com/115007582/203783207-91d7456d-c3ed-4f7c-9f7b-89c60bac52c4.png" width=70% height=70%>

## User Page 
Users can view their own orders, orders details and comments. 

<img src="https://user-images.githubusercontent.com/115007582/203783201-24597f87-f8c3-4332-90c0-6963e980b484.png" width=70% height=70%>

## Admin Page
Admin can view all orders and all comments. And admin also can delete any comments and change orders' state in orders details page. 

<img src="https://user-images.githubusercontent.com/115007582/203783203-866f38c4-9127-42ee-8eee-e64c136a4288.png" width=70% height=70%>

## About Us Page

<img src="https://user-images.githubusercontent.com/115007582/203831275-35cf94d0-cca7-4b99-981a-8fccee3e4c7c.png" width=70% height=70%>
