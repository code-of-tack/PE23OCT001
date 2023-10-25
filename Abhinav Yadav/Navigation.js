describe('Navigation Test', () => {
  beforeEach(() => {
    cy.visit('/home'); // Start at the home page
  });

  it('Navigates to the About page and verifies elements', () => {
    cy.get('a[href="/about"]').click(); // Click the About link
    cy.get('#aboutPage').should('be.visible'); // Verify About page is visible
    cy.get('h1').should('have.text', 'About Us'); // Verify About Us heading
    cy.get('p').should('have.text', 'Learn more about our company and our mission.'); // Verify About page content
  });

  it('Navigates to the Contact page and verifies elements', () => {
    cy.get('a[href="/contact"]').click(); // Click the Contact link
    cy.get('#contactPage').should('be.visible'); // Verify Contact page is visible
    cy.get('h1').should('have.text', 'Contact Us'); // Verify Contact Us heading
    cy.get('p').should('have.text', 'Get in touch with us using the information below.'); // Verify Contact page content
  });
});
