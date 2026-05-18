# 🚗 Transport WPF Application (Lab 1)

## 📖 Project Overview
This is a WPF desktop application developed in C# that demonstrates Object-Oriented Programming (OOP) principles.

The application simulates different types of transport:
- Bicycle
- Car
- Truck

Each transport type performs calculations such as:
- Fuel consumption
- Travel time
- Extra travel time (method overloading)

---

## 🧠 OOP Concepts Demonstrated

This project includes:

- ✔ Inheritance (Transport → Car, Truck, Bicycle)
- ✔ Interface implementation (`ITransport`)
- ✔ Method Overriding
- ✔ Method Overloading
- ✔ Encapsulation with properties
- ✔ Data validation in setters
- ✔ Polymorphism

---

## 🏗️ Project Structure
Lab1_BAI_01
│
├── Interfaces
│ └── ITransport.cs
│
├── Models
│ ├── Transport.cs
│ ├── Car.cs
│ ├── Truck.cs
│ └── Bicycle.cs
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
└── App.xaml

---

## ▶️ How to Run the Project

### 🔧 Requirements
- Visual Studio 2022 or later
- .NET Desktop Development workload installed

---

### 🚀 Steps to Run

1. Clone or download the repository:
git clone https://github.com/YOUBY-25/Lab1_BAI_01.git

2. Open the project:
- Open `Lab1_BAI_01.sln` in Visual Studio

3. Build the project:
- Press `Ctrl + Shift + B`

4. Run the application:
- Press `F5`

---

## 🧪 How to Use the Application

1. Select transport type:
- Bicycle
- Car
- Truck

2. Enter required data:
- Model name
- Average speed
- Number of passengers
- Distance

3. Click **Calculate**

---

## 📊 Example Input

| Field | Value |
|------|------|
| Type | Car |
| Model | BMW |
| Speed | 100 |
| Passengers | 4 |
| Distance | 200 |
<img width="1916" height="1079" alt="Screenshot 2026-05-18 133110" src="https://github.com/user-attachments/assets/fb935968-1679-4d27-ba4f-e784da37a530" />

---

## 📤 Example Output

- Fuel consumption calculated based on distance
- Travel time calculated using speed
- Extra travel time (+1 hour) using method overloading
- Display of transport information using polymorphism

---

## 📸 Features

- Clean WPF UI
- Real-time calculations
- Multiple transport types
- Input validation
- Object-oriented design

---

## 👨‍💻 Author

Student: AYOUB  
Course: Visual Programming  
Lab: Lab 1 - Transport System (WPF)
