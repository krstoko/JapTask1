import React from "react";
import { Routes, Route, Navigate } from "react-router-dom";
import SignIn from "./Components/Authorization/SignIn";
import Categories from "./Components/Categories/Categories";
import RecipeAdd from "./Components/Recipes/RecipeAdd/RecipeAdd";
import Recipe from "./Components/Recipes/RecipeDetails/Recipe";
import Recipes from "./Components/Recipes/RecipeList/Recipes";
const MainRouter = () => {
  return (
    <React.Fragment>
      <Routes>
        <Route path="/" element={<Navigate replace to="/signIn" />} />
        <Route path="signIn" element={<SignIn />} />
        <Route path="categories" element={<Categories />} />
        <Route path="recipes/:categorie" element={<Recipes />} />
        <Route path="recipe/:id" element={<Recipe />} />
        <Route path="recipe/add" element={<RecipeAdd />} />
      </Routes>
    </React.Fragment>
  );
};

export default MainRouter;
