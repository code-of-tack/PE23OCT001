class ToDoList:
    def __init__(self):
        self.tasks = []

    def add_task(self, task):
        """Add a task to the to-do list"""
        self.tasks.append(task)
        print(f"Task '{task}' added to the to-do list.")

    def edit_task(self, index, new_task):
        """Edit a task in the to-do list"""
        if 0 <= index < len(self.tasks):
            self.tasks[index] = new_task
            print(f"Task at index {index} edited to '{new_task}'.")
        else:
            print("Invalid index. Please provide a valid index.")

    def remove_task(self, index):
        """Remove a task from the to-do list"""
        if 0 <= index < len(self.tasks):
            task = self.tasks.pop(index)
            print(f"Task '{task}' removed from the to-do list.")
        else:
            print("Invalid index. Please provide a valid index.")

    def display_tasks(self):
        """Display all tasks in the to-do list"""
        print("To-Do List:")
        for i, task in enumerate(self.tasks):
            print(f"{i}. {task}")
