import { Grid } from "@mui/material";
import { Form, Formik } from "formik";
import React, { forwardRef, useEffect, useState } from "react";
import { getAllCategories } from "../../../ApiService/CategoriesApi";
import FormikControl from "../../FormikComponents/FormikControl";
import * as Yup from "yup"
const DetailsForm = forwardRef((props,ref) => {
  const [categories, setCategories] = useState([]);
  useEffect(() => {
    getAllCategories()
      .then((res) => {
        const selectCategories = renameObjKey(res.data);
        setCategories(selectCategories);
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
  const initialValues = {
    recipeName: "",
    categoryName: "",
    description: "",
    recipeImgUrl: "",
  };

  const validationSchema = Yup.object({
    recipeName: Yup.string().required("Recipe name is required"),
    categoryName: Yup.string().required("Category is required"),
    description: Yup.string().required("Description is required"),
    recipeImgUrl: Yup.string().required("Image url is required"),
  });
  return (
    <Formik
      initialValues={initialValues}
      validationSchema={validationSchema}
      innerRef={ref}
      onSubmit={(values,{resetForm})=>{
        props.addRecipe(values)
        resetForm();
      }}
    >
      <Form>
        <Grid container columnSpacing={5}>
          <Grid item xs={6}>
            <FormikControl
              control="input"
              type="text"
              label="Recipe Name"
              name="recipeName"
            />
          </Grid>
          <Grid item xs={6}>
            <FormikControl
              control="select"
              name="categoryName"
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
      </Form>
    </Formik>
  );
});

export default DetailsForm;
