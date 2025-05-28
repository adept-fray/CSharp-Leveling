# Inventory System

## Goals
Class <code>Product</code> with <code>Id</code>, <code>Name</code>, <code>Price</code>, <code>Quantity</code>.

### Steps:
- Add/update/remove products.
- Display product list.
- Calculate total inventory value.

<br/><br/><br/>

## 🧠 Practice Tasks


## 📌 Extra Bonus Task



# 🧾 Inventory System

A simple C# console application to manage a product inventory. It supports adding, updating, removing, displaying products, and calculating the total inventory value.

---

## ✅ Features

- Add, update, and remove products  
- Display product list  
- Calculate total inventory value  

---

## 🚀 Getting Started

### Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6 or later)

### Run the App

```bash
dotnet run
```

### Basic Usage

1. Launch the app  
2. Choose an option from the menu:  
   - Add a new product  
   - Update or remove an existing product  
   - View all products  
   - See total inventory value  
   - Exit the application

---

## 🎯 Practice Tasks

Improve your skills by implementing the following tasks:

### 🧠 Beginner

- [ ] **Input Validation**  
  Use `TryParse` to validate user input for ID, price, and quantity.

- [ ] **Prevent Duplicate IDs**  
  Ensure no two products share the same `Id`.

- [ ] **Auto-Increment Product ID**  
  Automatically assign a unique ID to each product added.

---

### 🛠 Intermediate

- [ ] **Search by Product Name**  
  Let users search for products by keyword (case-insensitive).

- [ ] **Sort Products**  
  Add options to sort by:
  - Name (A–Z)
  - Price (low to high)
  - Quantity (high to low)

- [ ] **Save and Load Inventory**  
  Persist products to a file (CSV or JSON) and load them on startup.

---

### 🚀 Advanced

- [ ] **Category Support**  
  Add a `Category` field to group/filter products.

- [ ] **Low Stock Alerts**  
  Notify if any product's quantity is below a set threshold.

- [ ] **Undo Last Action**  
  Allow undoing the last Add/Update/Remove operation.

---

## 📂 Folder Structure

```
InventorySystem/
├── Program.cs
├── Product.cs
├── Inventory.cs
└── README.md
```

---

## 📖 License

This project is open-source and available under the [MIT License](LICENSE).