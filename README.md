# Horizon

A web app to enhance daily workflow by combining task management, time tracking, and lightweight utilities. Built using Blazor United (.NET 9), this app demonstrates various rendering models (SSR, Server Interactive, WASM).

---

## Features

1. **Task Manager**:
   - Create, edit, and mark tasks as complete.
   - Add deadlines with color-coded priority levels.
   - Daily/weekly task views.

2. **Time Tracker**:
   - A Pomodoro timer for focused work sessions.
   - Historical visualization of time spent on tasks.

3. **Notes & Quick Links**:
   - Simple note-taking with markdown support.
   - Save and manage quick-access links.

4. **Daily Inspiration**:
   - Display a random motivational quote or image via an API (e.g., [ZenQuotes.io](https://zenquotes.io/)).

5. **Weather Widget**:
   - Fetch and display the current weather based on user location.

6. **Customization**:
   - Light/dark mode toggle.
   - Rearrange or hide widgets as needed.

7. **Multi-Rendering Support**:
   - **SSR** for static content like quotes and weather.
   - **Server Interactive Rendering** for task management and time tracking.
   - **WASM** for the Pomodoro timer and live updates.

---

## Milestones

### **1. Initial Setup**
- [X] Set up a Blazor WASM project using .NET 9.
- [X] Create the project structure for SSR, Server Interactive, and WASM rendering.
- [X] Configure basic routing and navigation.

### **2. Task Manager**
- [ ] Implement CRUD operations for tasks.
- [ ] Store tasks in a Postgres database using Entity Framework Core.
- [ ] Add priority levels and group tasks by day/week.
- [ ] Render tasks interactively with Server Interactive Rendering.

### **3. Time Tracker**
- [ ] Build a Pomodoro timer with configurable session lengths.
- [ ] Save session history to the database.
- [ ] Create a basic chart to visualize time tracking data.
- [ ] Use WebAssembly for a seamless timer experience.

### **4. Notes & Quick Links**
- [ ] Add a markdown-enabled notes widget.
- [ ] Implement CRUD operations for quick-access links.
- [ ] Store notes and links in the database.

### **5. Daily Inspiration**
- [ ] Fetch and display a random motivational quote/image from an external API.
- [ ] Use SSR to render the quote or image on initial load.

### **6. Weather Widget**
- [ ] Fetch weather data from an API (e.g., OpenWeatherMap).
- [ ] Display current weather and temperature.
- [ ] Integrate user location using browser geolocation.
- [ ] Render the weather widget with SSR.

### **7. Customization Options**
- [ ] Implement light/dark mode toggle.
- [ ] Allow users to rearrange or hide widgets.
- [ ] Save preferences locally (e.g., browser storage) or in the database.

### **8. Authentication** (Optional)
- [ ] Add basic authentication to personalize the experience.
- [ ] Implement Google OAuth for a more robust login system.

---

## Technology Stack

- **Frontend**: Blazor United (.NET 9)
  - Razor components for modular widgets.
  - SignalR for real-time updates (optional).
- **Backend**: ASP.NET Core API
  - SQLite/PostgreSQL for data storage.
  - External API calls for weather and quotes.
- **Database**: Entity Framework Core
- **Authentication**: Cookie-based or JWT (optional Google OAuth).

---

## Learning Goals

- Explore Blazor United and its rendering models.
- Practice integrating external APIs.
- Build real-time interactive features.
- Improve UI/UX with modular components and customization options.

---

Feel free to expand or adjust the scope of features and milestones based on your timeline and interests!

