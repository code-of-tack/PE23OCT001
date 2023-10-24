describe('Timing Issues Test', () => {
  it('Encounters timing issues during data loading', () => {
    cy.visit('http://www.example.com/async-page');

    // Intercept the data loading request and wait for the response
    cy.intercept('GET', '/data.json').as('dataLoaded');

    // Assert the expected data after the response is received
    cy.wait('@dataLoaded').then(() => {
      cy.get('#dataContainer').should('have.text', 'Expected Data');
    });
  });
});
