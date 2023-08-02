import React from 'react';
import './AdminLandingPage.css';

const AdminLandingPage = () => {
  return (
    <div className="AdminLandingPage">
      {/* Navbar */}
      <nav className="navbar">
        <span className="back-button" onClick={() => alert('Go back here!')}>
          ⬅
        </span>
      </nav>

      {/* Heading */}
      <h2 className="heading">List of Travel Agents</h2>

      {/* ... (Other content and features for the Admin Landing Page) ... */}
    </div>
  );
};

export default AdminLandingPage;
