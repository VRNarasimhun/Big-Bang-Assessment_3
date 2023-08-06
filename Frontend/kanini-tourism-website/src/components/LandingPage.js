import './LandingPage.css';
import DatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css';
import { Link } from 'react-router-dom';
import React from 'react';


const LandingPage = () => {

  return (
    <div className="LandingPage">
      {/* Navbar */}
      <nav className="navbar">
        <div className="navbar-left">
          <div className = "Company_name"> Make Your Trip</div>
        </div>
        <div className="navbar-right">
          <Link to ="registration">Registration</Link>
          <Link to ="login">Login</Link>
          <Link to="contact">Contact Us</Link>
          <Link to="feedback">Feedback</Link>
        </div>
      </nav>

      {/* Center of the page */}
      <div className="ContainerPage">     
        <div className="center">
        <input className='bar' type="text" placeholder="Search" />
        {/* <label>Date</label> */}
       <input type='date'></input>
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
