import React from 'react';
import { BrowserRouter, Routes,Route } from 'react-router-dom';
// import Register from './components/Register';
import LandingPage from './components/LandingPage';

// import { BrowserRouter } from 'react-router-dom';
import Login from './components/Login';
//import TravellerRegistration from './components/TravellerRegistration';
import TravelAgentRegistration from './components/TravelAgentRegistration';
import FeedbackPage from './components/FeedbackPage'
import ContactPage from './components/ContactPage';
import TravellerRegistration from './components/TravellerRegistration';
//import AdminLandingPage from './components/AdminLandingPage';

function App() {
  return (
    

    <BrowserRouter>
      <Routes>
      <Route path="/" element={<LandingPage/>}/>
      <Route path = "login" element = {<Login/>}/>
      <Route path = "contact" element = {<ContactPage/>}/>
      <Route path = "feedback" element = {<FeedbackPage/>}/>
      <Route path='registration' element = {<TravellerRegistration/>}/>
      <Route path='/Agent-registration' element = {<TravelAgentRegistration/>}/>
      </Routes>
    </BrowserRouter>

    
      );
};

export default App;
    
{/* <LandingPage/>
//<Login/>
//<TravellerRegistration/>  
//<TravelAgentRegistration/>
//<FeedbackPage/>
//<ContactPage/>
//<AdminLandingPage/>   */}