import React, { useState } from 'react';
import './ContactPage.css';

const ContactPage = () => {
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');
  const [concern, setConcern] = useState('');

  const handleNameChange = (e) => {
    setName(e.target.value);
  };

  const handleEmailChange = (e) => {
    setEmail(e.target.value);
  };

  const handleConcernChange = (e) => {
    setConcern(e.target.value);
  };

  const handleSubmit = () => {
    // In a real-world application, you can handle the form submission logic here
    console.log('Name:', name);
    console.log('Email:', email);
    console.log('Concern:', concern);
  };

  return (
    <div className="ContactPage">
      {/* Navbar */}
      <nav className="navbar">
        <span className="back-button" onClick={() => alert('Go back here!')}>
          ⬅
        </span>
        <span className="home-button" onClick={() => alert('Go to home!')}>
          🏠
        </span>
      </nav>

      <div className="contact-form">
        <h2>Contact Us</h2>
        <div className="form-group">
          <label htmlFor="name">Name</label>
          <input
            type="text"
            id="name"
            value={name}
            onChange={handleNameChange}
          />
        </div>
        <div className="form-group">
          <label htmlFor="email">Email</label>
          <input
            type="email"
            id="email"
            value={email}
            onChange={handleEmailChange}
          />
        </div>
        <div className="form-group">
          <label htmlFor="concern">Concern</label>
          <textarea
            id="concern"
            value={concern}
            onChange={handleConcernChange}
            rows={4}
            cols={50}
          />
        </div>
        <button onClick={handleSubmit}>Submit</button>
      </div>

      {/* Footer */}
      <footer className="footer">
        <a href="https://www.instagram.com/" target="_blank" rel="noopener noreferrer">
          <i className="fab fa-instagram"></i>
        </a>
        <a href="https://twitter.com/" target="_blank" rel="noopener noreferrer">
          <i className="fab fa-twitter"></i>
        </a>
      </footer>
    </div>
  );
};

export default ContactPage;
