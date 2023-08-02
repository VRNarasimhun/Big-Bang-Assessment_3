import React from 'react';
import './LandingPage.css';
import DatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css';

const LandingPage = () => {
  return (
    <div className="LandingPage">
      {/* Navbar */}
      <nav className="navbar">
        <div className="navbar-left">
          <img src="/path/to/your-logo.png" alt="Trip Logo" />
        </div>
        <div className="navbar-right">
          <a href="#registration">Registration</a>
          <a href="#login">Login</a>
          <a href="#contact">Contact Us</a>
          <a href="#feedback">Feedback</a>
        </div>
      </nav>

      {/* Center of the page */}
      <div className="ContainerPage">     
        <div className="center">
        <input type="text" placeholder="Search" />
        <DatePicker
          selected={new Date()}
          onChange={(date) => console.log(date)}
          dateFormat="MM/dd/yyyy"
        />
      </div>
      </div>

      {/* Footer */}
      <footer className="footer">
        <div className="footer-links">
          <a href="#twitter">Twitter</a>
          <a href="#instagram">Instagram</a>
          <a href="#facebook">Facebook</a>
        </div>
      </footer>
    </div>
  );
}

export default LandingPage;
