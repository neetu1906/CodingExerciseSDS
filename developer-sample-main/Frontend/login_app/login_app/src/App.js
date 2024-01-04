import React, { useState } from "react";
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';

const App = () => {
    const [loginAttempts, setLoginAttempts] = useState([]);

    const handleLogin = ({ login, password }) => {
        // Here, you'd normally handle authentication
        // For this example, we're just storing the attempt
        setLoginAttempts([...loginAttempts, { login, password, timestamp: new Date() }]);
    };

    return (
        <div className="App">
            <LoginForm onSubmit={handleLogin} />
            <LoginAttemptList attempts={loginAttempts} />
        </div>
    );
};

export default App;
