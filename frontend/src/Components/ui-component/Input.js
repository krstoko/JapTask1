import { TextField } from "@mui/material";
import React from "react";

const Input = (props) => {
  return (
    <TextField
      type={props.type ? props.type : "text"}
      margin={props.margin}
      fullWidth
      id={props.id}
      label={props.label}
    />
  );
};

export default Input;
