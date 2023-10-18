function simulateError() {
  try {
    // Intentionally throw an error
    nonExistentFunction();
  } catch (error) {
    // Handle the error and log a custom message
    console.error('An error occurred:', error.message);
  }
}

// Call the function to simulate the error
simulateError();
