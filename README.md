# Sales Order Creation
A basic application to add, update, delete items from an order list. Data is saved into a MSSQL database when submitted.

# Database
- The script to generate 'SalesOrder' db is in the 'database' folder.

# Logic
- Clicking on the add button for either one of the items creates a new order.
- When each item's add button is clicked, that item's quantity will increase in the order.
- The trash icon on every row will delete that row's item from the order.
- The pay button saves the order to the database table 'SalesOrder'.
- The delete sale button deletes the entire order.
- If all items are removed from the order, the entire order is also deleted.
- Order numbers are unique and based on the current date/timestamp.

# What's missing?
- Unable to edit the quantity and price in the order (as an input field).
- Unable to input customer's name and save it into the database.
