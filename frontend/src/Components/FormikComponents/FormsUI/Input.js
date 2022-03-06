import { InputAdornment, TextField } from "@mui/material";
import { useField } from "formik";
import React from "react";

const Input = ({ name, errorProp, ...rest }) => {
  const [field, mata] = useField(name);

  const configTextField = {
    ...field,
    ...rest,
    fullWidth: true,
  };

  if (mata && mata.touched && mata.error) {
    configTextField.error = true;
    configTextField.helperText = mata.error;
  } else if (errorProp.isError) {
    configTextField.error = true;
    configTextField.helperText = errorProp.message;
  }

  return <TextField autoComplete="off" margin="normal" {...configTextField} />;
};

export default Input;
