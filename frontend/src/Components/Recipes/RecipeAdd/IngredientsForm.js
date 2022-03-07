import {  Grid } from "@mui/material";
import React, { useState } from "react";
import FormikControl from "../../FormikComponents/FormikControl";
import ButtonReusable from "../../ui-component/ButtonReusable";

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

  const onAddIngredient = (values) => {
    props.newIngredient(values);
  };
  const [error, setError] = useState({ isError: false, message: "" });

  return (
    <Grid container columnSpacing={5} justifyContent="flex-end">
      <Grid item xs={12}>
        <FormikControl
          control="select"
          type="text"
          label="Recipe Name"
          name="ingrediantName"
          options={ingredients}
          errors={error}
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
          errors={error}
        />
      </Grid>
      <Grid item xs={6}>
        <ButtonReusable variant="contained" onClick={onAddIngredient} size="large" fullWidth>
          Add
        </ButtonReusable>
      </Grid>
    </Grid>
  );
};

export default IngredientsForm;
