import React from "react";
import { Routes, Route, Navigate } from "react-router-dom";
import SignIn from "./Components/Authorization/SignIn";
import SignUp from "./Components/Authorization/SignUp";
import Categories from "./Components/Categories/Categories";
const MainRouter = () => {
  return (
    <React.Fragment>
      <Routes>
        <Route path="/" element={<Navigate replace to="/signIn" />} />
        <Route path="signIn" element={<SignIn />} />
        <Route path="signUp" element={<SignUp />} />
        <Route path="categories" element={<Categories />} />
      </Routes>
    </React.Fragment>
  );
};

export default MainRouter;
