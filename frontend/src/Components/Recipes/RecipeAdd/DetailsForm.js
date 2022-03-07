import { Grid } from "@mui/material";
import React, { useEffect, useState } from "react";
import { getAllCategories } from "../../../ApiService/CategoriesApi";
import FormikControl from "../../FormikComponents/FormikControl";

const DetailsForm = () => {
  const [categories, setCategories] = useState([]);
  useEffect(() => {
    getAllCategories()
      .then((res) => {
        const selectCategories = renameObjKey(res.data);
        setCategories(selectCategories)
      })
      .catch((err) => console.log(err));
  }, []);

  const renameObjKey = (array) => {
    array = array.map((obj) => {
      obj["name"] = obj["categoryName"];
      delete obj["categoryName"];
      return obj;
    });
    return array;
  };

  const [error, setError] = useState({ isError: false, message: "" });
  return (
    <Grid container columnSpacing={5}>
      <Grid item xs={6}>
        <FormikControl
          control="input"
          type="text"
          label="Recipe Name"
          name="recipeName"
          errors={error}
        />
      </Grid>
      <Grid item xs={6}>
        <FormikControl
          control="select"
          name="categorie"
          label="Recipe Category"
          options={categories}
        />
      </Grid>
      <Grid item xs={12}>
        <FormikControl
          control="input"
          type="text"
          label="Recipe Image Url"
          name="recipeImgUrl"
          errors={error}
        />
      </Grid>
      <Grid item xs={12}>
        <FormikControl
          control="textArea"
          name="description"
          label="Recipe Description"
        />
      </Grid>
    </Grid>
  );
};

export default DetailsForm;
