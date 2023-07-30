// LandingPage.js
import React from 'react';
import { Link } from 'react-router-dom';
import './LandingPage.css';
import DatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css';

function LandingPage() {
  return (
    <div className='body'>
      <link rel="stylesheet" href="./fontawesome-free-5.15.3-web/css/all.min.css" />
      <nav>
        {/* ... Your existing navbar code ... */}
      </nav>

      <section>
        <div className="container">
          <h1>Make Your Tour</h1>

          <div className="search-bar">
            <input type="text" placeholder="Enter your destination..." />
            <button>Search</button>
          </div>

          <div className="date-picker">
            <DatePicker
              selected={new Date()} // Set the default selected date (you can customize this as needed)
              onChange={(date) => console.log(date)} // Handle date selection (you can customize this handler)
            />
          </div>

          <p>"Kanini Tourism has launched a MAKE YOUR TRIP website where the customers can easily 
            travel around the world with various options in their hand. Our main motto is 'CUSTOMER SATISFACTION'."</p>
        </div>
      </section>
    </div>
  );
}

export default LandingPage;
