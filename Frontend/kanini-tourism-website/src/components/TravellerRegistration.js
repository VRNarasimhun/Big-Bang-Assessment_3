import React, { useState } from 'react';
import './TravellerRegistration.css';
import { Link } from 'react-router-dom';


const TravellerRegistration = () => {
  const [name, setName] = useState('');
  const [dateOfBirth, setDateOfBirth] = useState('');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [gender, setGender] = useState('male');
  const [email, setEmail] = useState('');
  const [address, setAddress] = useState('');
  const [otp, setOtp] = useState('');
  const [otpSent, setOtpSent] = useState(false);

  function handleGenerateOtp() {
    // In a real-world application, you would send the OTP to the user's phone number via an API
    const generatedOtp = Math.floor(100000 + Math.random() * 900000);
    setOtp(generatedOtp.toString());
    setOtpSent(true);
  }

  function handleRegister() {
    // In a real-world application, you would handle the registration logic here
    console.log({
      name,
      dateOfBirth,
      phoneNumber,
      gender,
      email,
      address,
      otp
    });
  }

  return (
    <div className="TravellerRegistration">
      <nav className="navbar d-flex justify-content-between">
        <span className="back-symbol">⬅</span>
        <h2>Traveller Registration</h2>
        <Link to ="/Agent-registration" className="agent-registration-link">Agent Registration</Link> 
          
        
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
          <label htmlFor="phoneNumber">Phone Number</label>
          <input
            type="text"
            id="phoneNumber"
            value={phoneNumber}
            onChange={(e) => setPhoneNumber(e.target.value)}
          />
          <button onClick={handleGenerateOtp}>
            {otpSent ? 'Resend OTP' : 'Generate OTP'}
          </button>
        </div>
        {otpSent && (
          <div className="form-group">
            <label htmlFor="otp">OTP</label>
            <input
              type="text"
              id="otp"
              value={otp}
              onChange={(e) => setOtp(e.target.value)}
            />
          </div>
        )}
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
          <label htmlFor="email">Email</label>
          <input
            type="email"
            id="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />
        </div>
        <div className="form-group">
          <label htmlFor="address">Address</label>
          <textarea
            id="address"
            value={address}
            onChange={(e) => setAddress(e.target.value)}
          ></textarea>
        </div>
        <button onClick={handleRegister}>Register</button>
      </div>
    </div>
  );
};

export default TravellerRegistration;
