describe('Login with Data-Driven Testing', () => {
  it('should log in with each set of credentials', () => {
    testData.forEach((user) => {
      cy.visit('/login');
      cy.get('#username').type(user.username);
      cy.get('#password').type(user.password);
      cy.get('#submit').click();

      // Assert that the user is logged in
      cy.get('.logged-in-user').should('contain', user.username);
    });
  });
});
