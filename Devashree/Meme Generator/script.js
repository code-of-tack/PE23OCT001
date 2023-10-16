// JavaScript for Meme Generator

let memes = []; // Array to store fetched memes
let currentMemeIndex = -1; // Index of the currently displayed meme

// Function to fetch a new meme from the API
async function fetchMemeFromAPI() {
    try {
        const response = await fetch('https://meme-api.com/gimme/wholesomememes');
        if (!response.ok) {
            throw new Error('Failed to fetch meme from the API');
        }
        const data = await response.json();
        memes.push(data);
        currentMemeIndex = memes.length - 1;
        displayMeme(data.url);
    } catch (error) {
        displayError('Failed to fetch meme. Please try again later.');
    }
}

// Function to display a meme
function displayMeme(url) {
    const memeImage = document.getElementById('memeImage');
    memeImage.setAttribute('src', url);
}

// Event listeners for buttons and forms
document.getElementById('loginBtn').addEventListener('click', function(){
    document.getElementById('loginForm').style.display = 'block';
    document.getElementById('signupForm').style.display = 'none';
});

document.getElementById('signupBtn').addEventListener('click', function(){
    document.getElementById('signupForm').style.display = 'block';
    document.getElementById('loginForm').style.display = 'none';
});

document.getElementById('submitSignupBtn').addEventListener('click', function(event){
    event.preventDefault();
    // Get the form values
    const email = document.getElementById('email').value;
    const phone = document.getElementById('phone').value;

    // Store user details in session storage
    const userDetails = {
        email: email,
        phone: phone
    };
    sessionStorage.setItem('userDetails', JSON.stringify(userDetails));

    // Display a success message
    alert('Sign up successful!');
});

document.getElementById('submitLoginBtn').addEventListener('click', function(event){
    event.preventDefault();
    // Add login functionality here
});

document.getElementById('nextBtn').addEventListener('click', function(){
    fetchMemeFromAPI();
    document.getElementById('previousBtn').disabled = false;
});

document.getElementById('previousBtn').addEventListener('click', function(){
    if (currentMemeIndex > 0) {
        currentMemeIndex--;
        displayMeme(memes[currentMemeIndex].url);
    }
    if (currentMemeIndex === 0) {
        document.getElementById('previousBtn').disabled = true;
    }
});

// API call to fetch the initial meme when the page loads
fetchMemeFromAPI();

// Function to handle error messages
function displayError(message) {
    alert(message);
}
