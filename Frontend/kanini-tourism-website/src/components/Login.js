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

  function handleLogin(event) {
    event.preventDefault();
    if (parseInt(userAnswer) === captcha.solution) {
      setLoginMessage('Login Successful!');
      // Add your actual login logic here
    } else {
      setLoginMessage('Incorrect Captcha Answer. Try Again.');
    }
  }

  return (
    <div className="login-container">
      <form className="login-form" onSubmit={handleLogin}>
        <h2 className="login-heading">Login</h2>
        <input type="text" className="login-input" placeholder="Username" />
        <input type="password" className="login-input" placeholder="Password" />

        {/* Captcha */}
        <div className="captcha">
          <p>
            Prove you're not a robot :
            <span className="captcha-equation">
              {captcha.num1} + {captcha.num2} = 
            </span>
          </p>
          <input
            type="text"
            value={userAnswer}
            onChange={handleAnswerChange}
            className="login-input"
            placeholder="Enter the answer"
          />
          <button
            type="button"
            onClick={handleReloadCaptcha}
            className="captcha-button"
          >
            Reload Captcha
          </button>
        </div>

        <button type="submit" className="login-button">
          Login
        </button>
        <p className="error-message">{loginMessage}</p>
        
      </form>
    </div>
  );
};

export default Login;
