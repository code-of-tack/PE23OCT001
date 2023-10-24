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

def main():
    todo_list = ToDoList()
    while True:
        print("\nSelect an option:")
        print("1. Add a task")
        print("2. Edit a task")
        print("3. Remove a task")
        print("4. Display tasks")
        print("5. Exit")

        choice = input("Enter your choice: ")

        if choice == '1':
            task = input("Enter task to add: ")
            todo_list.add_task(task)

        elif choice == '2':
            index = int(input("Enter index of task to edit: "))
            new_task = input("Enter new task: ")
            todo_list.edit_task(index, new_task)

        elif choice == '3':
            index = int(input("Enter index of task to remove: "))
            todo_list.remove_task(index)

        elif choice == '4':
            todo_list.display_tasks()

        elif choice == '5':
            print("Exiting the to-do list application.")
            break

        else:
            print("Invalid choice. Please select a valid option.")


if __name__ == "__main__":
    main()
