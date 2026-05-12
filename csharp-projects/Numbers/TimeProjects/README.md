# Console Stopwatch Application (C#)

## 📌 Description
This is a console-based stopwatch application written in C#.  
The program allows the user to control a running stopwatch using keyboard inputs.

---

## 🎮 Controls

| Key | Action |
|-----|--------|
| S   | Start  |
| T   | Stop   |
| R   | Reset  |
| Q   | Quit   |

---

## 🧠 Concepts Learned / Used

### 1️⃣ System.Diagnostics.Stopwatch
- Used to measure elapsed time
- Methods used:
  - `Start()`
  - `Stop()`
  - `Reset()`
  - `Elapsed`

---

### 2️⃣ Console Input Handling
- `Console.KeyAvailable`
  - Checks if a key is pressed without blocking execution
- `Console.ReadKey(true)`
  - Reads key input without displaying it on screen

---

### 3️⃣ Real-Time Console Updates
- `Console.SetCursorPosition(x, y)`
  - Updates the time at a fixed screen position
- `Thread.Sleep(milliseconds)`
  - Prevents CPU overuse and controls refresh rate

---

### 4️⃣ Control Flow
- `while` loop for continuous execution
- `switch-case` for handling multiple key actions
- Boolean flag (`running`) to control program termination

---

## 🧩 Technical Features
- Real-time time tracking
- Interactive keyboard control
- Continuous screen refresh
- Structured event handling

---

## 🚀 How It Works
1. The stopwatch object is created.
2. The program enters a continuous loop.
3. It checks for user key input.
4. Depending on the pressed key:
   - The stopwatch starts, stops, resets, or exits.
5. The elapsed time is displayed and updated every 200 milliseconds.

---

## 📚 Learning Purpose
This project was created to practice:
- Time measurement in C#
- Console interaction
- Keyboard event handling
- Loop control and program state management
