describe('Handling Alerts and Modals', () => {
  it('Handles the JavaScript alert correctly', () => {
    // Click the button that triggers the JavaScript alert
    cy.get('#alertButton').click();

    // Listen for the `window:alert` event
    cy.on('window:alert', (text) => {
      // Add a breakpoint here
      expect(text).to.equal('Hello! This is an alert.');
    });
  });
});
