import { Container } from "@mui/material";
import { makeStyles } from "@mui/styles";
import React from "react";

const useStyles = makeStyles({
  box: {
    display: "flex",
    flexDirection: "column",
    alignItems: "center",
    marginTop: "20px",
  },
  container: {
    position: "absolute",
    left: "50%",
    top: "50%",
    transform: "translate(-50%,-50%)",
  },
});

const CenteredComponent = (props) => {
    const classes = useStyles();
  return (
    <Container component="main" maxWidth="xs" className={classes.container}>
      {props.children}
    </Container>
  );
};

export default CenteredComponent;
