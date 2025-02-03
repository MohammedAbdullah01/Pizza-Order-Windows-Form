## Pizza Order Form

This project is a Windows Forms Application that provides a user-friendly interface for ordering pizza. Users can customize their pizza by selecting size, crust type, toppings, and order type (Eat In or Take Out). The form dynamically updates the order summary and total price based on user selections.

### Features
- **Select Pizza Size**: Small, Medium, or Large
- **Choose Crust Type**: Thin or Thick Crust
- **Add Toppings**: Extra Cheese, Mushrooms, Green Peppers, Olives, Onion, Tomatoes
- **Select Order Type**: Eat In or Take Out
- **Dynamic Price Calculation**: Updates the total price based on selections
- **Order Confirmation**: Displays confirmation dialog before placing an order
- **Reset Form**: Resets all selections to default values

### Code Overview
The main functionality of the application is implemented in the `FormPizzaOrder` class.

#### **Event Handlers**
- `Form1_Load`: Initializes the form and updates the order summary.
- `radSmall_CheckedChanged`, `radMeduim_CheckedChanged`, `radLarg_CheckedChanged`: Updates the selected pizza size.
- `radThinCrust_CheckedChanged`, `radThinkCrust_CheckedChanged`: Updates the selected crust type.
- `chkExtraChees_CheckedChanged`, `chkMushrooms_CheckedChanged`, `chkTomatoes_CheckedChanged`, `chkOnion_CheckedChanged`, `chkOlives_CheckedChanged`, `chkGreenPeppers_CheckedChanged`: Updates the selected toppings.
- `radEatIn_CheckedChanged`, `radTakeOut_CheckedChanged`: Updates the order type (Eat In or Take Out).
- `btnOrderPizza_Click`: Displays a confirmation dialog before placing an order.
- `btnRestForm_Click`: Resets the form to default values.

#### **Helper Methods**
- `RestetForm()`: Resets all selections and enables the form for new orders.
- `UpdateOrderSummary()`: Initializes the default order selections.
- `UpdateSize()`, `UpdateCrustType()`, `UpdateToppings()`, `UpdateWhereToEat()`: Updates the UI labels and total price when user selections change.
- `GetSelectedSizePrice()`, `GetSelectedCrustTypePrice()`, `GetSelectedWhereToEatPrice()`, `CalculateToppingsPrice()`: Retrieves the price for each selection.
- `calculateTotalPrice()`: Computes the total cost of the order.
- `UpdateTotalPrice()`: Updates the displayed total price.

### Usage
1. Select the desired **pizza size**.
2. Choose a **crust type**.
3. Add **toppings** as desired.
4. Select **order type** (Eat In or Take Out).
5. Click **Order Pizza** to confirm the order.
6. To reset selections, click **Reset Form**.

### Notes
- The form uses `Tag` properties to store prices for different options.
- Price calculations are updated in real-time as selections change.
- Order confirmation ensures that accidental purchases are avoided.

### Technologies Used
- **C#** (Windows Forms Application)
- **.NET Framework**

### Author
This project was created as part of a learning exercise to practice Windows Forms application development in C#.

