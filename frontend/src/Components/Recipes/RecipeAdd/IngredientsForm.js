import { Grid } from "@mui/material";
import React from "react";
import FormikControl from "../../FormikComponents/FormikControl";
import ButtonReusable from "../../ui-component/ButtonReusable";
import * as Yup from "yup";
import { Form, Formik } from "formik";
const IngredientsForm = (props) => {
  const ingredients = [
    { id: 1, name: "Pizza" },
    { id: 2, name: "Nesto durgo" },
    { id: 3, name: "TRece" },
    { id: 4, name: "Auu" },
    { id: 5, name: "Dadad" },
  ];
  const ingredients2 = [
    { id: 1, name: "Pizza" },
    { id: 2, name: "Nesto durgo" },
    { id: 3, name: "TRece" },
    { id: 4, name: "Auu" },
    { id: 5, name: "Dadad" },
  ];

  const onAddIngredient = (values,resetForm) => {
    props.newIngredient(values);
    resetForm();
  };

  const initialValues = {
    ingrediantName: "",
    measureUnit: "",
    measureQuantity: "",
  };

  const validationSchema = Yup.object({
    ingrediantName: Yup.string().required("Ingredient name is required"),
    measureUnit: Yup.string().required("Measure unit is required"),
    measureQuantity: Yup.string().required("Measure quantity is required"),
  });

  return (
    <Formik
      initialValues={initialValues}
      validationSchema={validationSchema}
      onSubmit={(values,{resetForm}) => {
        onAddIngredient(values,resetForm);
      }}
    >
      <Form>
        <Grid container columnSpacing={5} justifyContent="flex-end">
          <Grid item xs={12}>
            <FormikControl
              control="select"
              type="text"
              label="Recipe Name"
              name="ingrediantName"
              options={ingredients}
            />
          </Grid>
          <Grid item xs={6}>
            <FormikControl
              control="select"
              type="text"
              label="Measure Unit"
              name="measureUnit"
              options={ingredients2}
            />
          </Grid>
          <Grid item xs={6}>
            <FormikControl
              control="input"
              type="number"
              name="measureQuantity"
              label="Measure Quantity"
              InputProps={{ inputProps: { min: "0", max: "10", step: "0.1" } }}
            />
          </Grid>
          <Grid item xs={6}>
            <ButtonReusable
              variant="contained"
              type="submit"
              size="large"
              fullWidth
            >
              Add
            </ButtonReusable>
          </Grid>
        </Grid>
      </Form>
    </Formik>
  );
};

export default IngredientsForm;
