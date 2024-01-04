import React from "react";
import "./LoginAttemptList.css";

const LoginAttempt = ({ login, timestamp }) => (
    <li>{login} - {timestamp.toLocaleString()}</li>
);

const LoginAttemptList = ({ attempts }) => (
    <div className="Attempt-List-Main">
        <h1>Recent activity</h1>
        <ul className="Attempt-List">
            {attempts.map((attempt, index) => (
                <LoginAttempt key={index} login={attempt.login} timestamp={attempt.timestamp} />
            ))}
        </ul>
    </div>
);

export default LoginAttemptList;
