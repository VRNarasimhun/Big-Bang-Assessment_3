import React, { useState } from 'react';
import './TravelAgentRegistration.css';

const TravelAgentRegistration = () => {
  const [name, setName] = useState('');
  const [dateOfBirth, setDateOfBirth] = useState('');
  const [agencyName, setAgencyName] = useState('');
  const [gender, setGender] = useState('male');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [email, setEmail] = useState('');
  const [agencyAddress, setAgencyAddress] = useState('');
  const [gstNumber, setGstNumber] = useState('');

  function handleRegister() {
    // In a real-world application, you would handle the registration logic here
    console.log({
      name,
      dateOfBirth,
      agencyName,
      gender,
      phoneNumber,
      email,
      agencyAddress,
      gstNumber,
    });
  }

  return (
    <div className="TravelAgentRegistration">
      <nav className="navbar">
        <span className="back-symbol">⬅</span>
      <h2>Travel Agent Registration</h2>
      </nav>

      <div className="registration-form">
        <div className="form-group">
          <label htmlFor="name">Name</label>
          <input
            type="text"
            id="name"
            value={name}
            onChange={(e) => setName(e.target.value)}
          />
        </div>
        <div className="form-group">
          <label htmlFor="dateOfBirth">Date of Birth</label>
          <input
            type="date"
            id="dateOfBirth"
            value={dateOfBirth}
            onChange={(e) => setDateOfBirth(e.target.value)}
          />
        </div>
        <div className="form-group">
          <label htmlFor="agencyName">Agency Name</label>
          <input
            type="text"
            id="agencyName"
            value={agencyName}
            onChange={(e) => setAgencyName(e.target.value)}
          />
        </div>
        <div className="form-group">
          <label htmlFor="gender">Gender</label>
          <select
            id="gender"
            value={gender}
            onChange={(e) => setGender(e.target.value)}
          >
            <option value="male">Male</option>
            <option value="female">Female</option>
            <option value="other">Other</option>
          </select>
        </div>
        <div className="form-group">
          <label htmlFor="phoneNumber">Phone Number</label>
          <input
            type="text"
            id="phoneNumber"
            value={phoneNumber}
            onChange={(e) => setPhoneNumber(e.target.value)}
          />
        </div>
        <div className="form-group">
          <label htmlFor="email">Email</label>
          <input
            type="email"
            id="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />
        </div>
        <div className="form-group">
          <label htmlFor="agencyAddress">Agency Address</label>
          <textarea
            id="agencyAddress"
            value={agencyAddress}
            onChange={(e) => setAgencyAddress(e.target.value)}
          ></textarea>
        </div>
        <div className="form-group">
          <label htmlFor="gstNumber">GST Number</label>
          <input
            type="text"
            id="gstNumber"
            value={gstNumber}
            onChange={(e) => setGstNumber(e.target.value)}
          />
        </div>
        <button onClick={handleRegister}>Register</button>
      </div>
    </div>
  );
};

export default TravelAgentRegistration;
