# One-Tap Task — .NET MAUI Demo App

A minimal .NET MAUI application that demonstrates how to manage UI state and instantly reflect changes in the interface using XAML + C#.

This project was designed as a live demo app for .NET Conf 2025 Zambia, focusing on fundamentals rather than complexity.

---

## Purpose

The goal of this app is to show how quickly you can build a clean, cross-platform application with .NET MAUI using:

- Declarative UI with XAML
- Simple state management in C#
- Instant UI updates based on user interaction
- A single shared codebase for multiple platforms

No advanced frameworks. No external dependencies. Just core MAUI.

---

## What the App Does

- Displays a single task
- Shows the task’s current status: Pending or Completed
- Allows the user to toggle the task state with one tap
- Updates text, color, and button label instantly

This keeps the logic simple while clearly demonstrating how UI and state work together.

---

## App Structure (High Level)

- FocusMate/MainPage.xaml
  - Defines the UI layout (labels, button, spacing) with a light background and centered vertical stack.
- FocusMate/MainPage.xaml.cs
  - Holds the task state and handles button click logic through OnToggleClicked.

Everything lives in one page to keep the learning curve low and the demo fast.

---

## Tech Stack

- .NET MAUI
- XAML for UI
- C# for logic
- Runs on:
  - Android
  - Windows

---

## How to Run

1. Open the solution in Visual Studio 2022 or later
2. Restore and build the solution
3. Select a target platform (Android Emulator or Windows)
4. Press Run

---

## Demo Preview

(Optional: Add a screenshot or GIF here)

---

## Development

- UI: Centered VerticalStackLayout with TaskLabel, StatusLabel, and ToggleButton in MainPage.xaml.
- Logic: File-scoped namespace and a simple isCompleted boolean in MainPage.xaml.cs that updates the labels and button.
- Accessibility: Labels are straightforward and high-contrast colors indicate status (red for pending, green for completed).

---

## Why This App Matters

This app is intentionally small, but it highlights the core value of .NET MAUI:

- One project
- One UI definition
- One codebase
- Multiple platforms

It’s a practical starting point for beginners and a clean teaching example for live presentations.

---

## Roadmap (Not Implemented)

- Multiple tasks (list view)
- MVVM pattern
- Local storage/persistence
- Animations
- Dark mode customization

---

## Contributing

Issues and PRs are welcome. For PRs:

- Keep commits focused and descriptive
- Prefer small, reviewable changes
- Update documentation and screenshots if UI/UX changes

---

## License

MIT License — free to use, modify, and learn from.
