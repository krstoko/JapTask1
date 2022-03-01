import React from "react";
import ReusableTextField from "./ReusableTextField";

const FormikControl = (props) => {
  const { control, ...rest } = props;
  switch (control) {
    case "input":
      return <ReusableTextField {...rest} />;
    default:
      return null;
  }
};

export default FormikControl;
