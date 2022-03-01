import React from "react";
import { Routes, Route, Navigate } from "react-router-dom";
import SignIn from "./Components/SignIn";
import SignUp from "./Components/SignUp";
const MainRouter = () => {
  return (
    <React.Fragment>
      <Routes>
        <Route path="/" element={<Navigate replace to="/signIn" />} />
        <Route path="signIn" element={<SignIn />} />
        <Route path="signUp" element={<SignUp />} />
      </Routes>
    </React.Fragment>
  );
};

export default MainRouter;
