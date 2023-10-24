describe('Form submission test', () => {
  it('should successfully submit the form with valid data', () => {
    // Visit the web page containing the form
    cy.visit('url of the website');

    // Fill out the form with valid data
    cy.get('#name').type('Abhinav Yadav');
    cy.get('#email').type('abhii@gmail.com');
    cy.get('#message').type('This is a test message for project earlybird.');

    // Submit the form
    cy.get('#submitButton').click();

    // Verify that the form submission was successful
    cy.on('window:alert', (alertText) => {
      expect(alertText).to.equal('Form submitted successfully!');
    });
  });
});
