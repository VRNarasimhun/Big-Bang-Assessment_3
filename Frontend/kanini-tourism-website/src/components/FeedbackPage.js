import React, { useState } from 'react';
import './FeedbackPage.css';

const Star = ({ selected, onClick }) => (
  <span className={selected ? 'star selected' : 'star'} onClick={onClick}>
    ★
  </span>
);

const StarRating = ({ totalStars, rating, onRatingChange }) => {
  const handleStarClick = (starIdx) => {
    onRatingChange(starIdx + 1);
  };

  return (
    <div className="star-rating">
      {[...Array(totalStars)].map((_, idx) => (
        <Star
          key={idx}
          selected={idx < rating}
          onClick={() => handleStarClick(idx)}
        />
      ))}
    </div>
  );
};

const FeedbackPage = () => {
  const [feedback, setFeedback] = useState('');
  const [rating, setRating] = useState(0);

  const handleFeedbackChange = (e) => {
    setFeedback(e.target.value);
  };

  const handleRatingChange = (newRating) => {
    setRating(newRating);
  };

  const handleSubmit = () => {
    // In a real-world application, you can handle the submission logic here
    console.log('Feedback:', feedback);
    console.log('Rating:', rating);
  };

  return (
    <div 

    className="FeedbackPage">

      <h2>Feedback Page</h2>
      <div className="feedback-box">
        <label htmlFor="feedback">Your Feedback:</label>
        <textarea
          id="feedback"
          value={feedback}
          onChange={handleFeedbackChange}
          rows={4}
          cols={50}
        />
      </div>
      <div className="rating-box">
        <label>Rate the Website:</label>
        <StarRating totalStars={5} rating={rating} onRatingChange={handleRatingChange} />
      </div>
      <button onClick={handleSubmit}>Submit Feedback</button>
    </div>
  );
};

export default FeedbackPage;
