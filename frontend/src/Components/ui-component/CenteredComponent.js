import { Container } from "@mui/material";
import React from "react";

const CenteredComponent = (props) => {
  const style = {
    position: "absolute",
    left: "50%",
    top: "50%",
    transform: "translate(-50%,-50%)",
  };
  return (
    <Container component="main" maxWidth="xs" sx={style}>
      {props.children}
    </Container>
  );
};

export default CenteredComponent;
