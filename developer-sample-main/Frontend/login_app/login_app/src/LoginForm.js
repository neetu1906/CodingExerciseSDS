import React, { useState } from "react";
import './LoginForm.css';

const LoginForm = ({ onSubmit }) => {
    const [login, setLogin] = useState('');
    const [password, setPassword] = useState('');

    const handleSubmit = (event) =>{
        event.preventDefault();
        onSubmit({ login, password });
        setLogin('');
        setPassword('');
    };

    return (
        <form className="form" onSubmit={handleSubmit}>
            <h1>Login</h1>
            <label htmlFor="login">Name</label>
            <input type="text" id="login" value={login} onChange={(e) => setLogin(e.target.value)} />
            <label htmlFor="password">Password</label>
            <input type="password" id="password" value={password} onChange={(e) => setPassword(e.target.value)} />
            <button type="submit">Submit</button>
        </form>
    );
};

export default LoginForm;
