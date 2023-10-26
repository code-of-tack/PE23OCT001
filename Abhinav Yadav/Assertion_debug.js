//

describe('Modal Test', () => {
  it('Verifies modal visibility after clicking the button', () => {
    // Click the button to open the modal
    cy.get('#modalButton').click();

    // Assertion to check the visibility of the modal
    cy.get('#modal').should('be.visible');  //changed state form invisible to visible 
  });
});
