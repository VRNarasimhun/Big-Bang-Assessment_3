import React, { useState } from 'react';
import './Login.css';

const Login = () => {
  const [captcha, setCaptcha] = useState(generateCaptcha());
  const [userAnswer, setUserAnswer] = useState('');
  const [loginMessage, setLoginMessage] = useState('');

  function generateCaptcha() {
    const num1 = Math.floor(Math.random() * 10);
    const num2 = Math.floor(Math.random() * 10);
    return { num1, num2, solution: num1 + num2 };
  }

  function handleReloadCaptcha() {
    setCaptcha(generateCaptcha());
    setUserAnswer('');
  }

  function handleAnswerChange(event) {
    setUserAnswer(event.target.value);
  }

  function handleLogin() {
    if (parseInt(userAnswer) === captcha.solution) {
      setLoginMessage('Login Successful!');
      // Add your actual login logic here
    } else {
      setLoginMessage('Incorrect Captcha Answer. Try Again.');
    }
  }

  return (
    <div className="TravellerLogin">
      <nav className="navbar">
        <span className="back-symbol">⬅</span>
        <h2>Login</h2>
      </nav>
      <div className="login-card">
        <div className="form-group">
          <label htmlFor="username">Username</label>
          <input type="text" id="username" name="username" />
        </div>
        <div className="form-group">
          <label htmlFor="password">Password</label>
          <input type="password" id="password" name="password" />
        </div>

        {/* Captcha */}
        <div className="captcha">
          <p>
            Solve this simple math problem to prove you are not a robot:
            <span className="captcha-equation">
              {captcha.num1} + {captcha.num2} = ?
            </span>
          </p>
          <input
            type="text"
            value={userAnswer}
            onChange={handleAnswerChange}
            placeholder="Enter the answer"
          />
          <button onClick={handleReloadCaptcha}>Reload Captcha</button>
        </div>

        <button onClick={handleLogin}>Login</button>
        <p>{loginMessage}</p>
      </div>
    </div>
  );
};

export default Login;
