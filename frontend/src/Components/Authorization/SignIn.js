import { Grid, Typography } from "@mui/material";
import React from "react";
import ButtonReusable from "../ui-component/ButtonReusable";
import ContainerPaper from "../ui-component/ContainerPaper";
import * as Yup from "yup";
import { Formik, Form } from "formik";
import FormikControl from "../FormikComponents/FormikControl";
import { Link } from "react-router-dom";

const SignIn = () => {
  const onSubmit = (values) => {
    console.log(values);
  };

  const initialValues = {
    userName: "",
    password: "",
  };

  const validationSchema = Yup.object({
    userName: Yup.string().required("Username is required"),
    password: Yup.string()
      .min(6, "At least 6 characters required")
      .required("Password is required"),
  });

  return (
    <React.Fragment>
      <ContainerPaper type="centered">
          <Typography component="h1" variant="h5" align="center">
            Sign in
          </Typography>
          <Formik
            initialValues={initialValues}
            validationSchema={validationSchema}
            onSubmit={(values) => {
              onSubmit(values);
            }}
          >
            <Form>
              <FormikControl
                control="input"
                type="text"
                label="Username"
                name="userName"
              />
              <FormikControl
                control="input"
                type="password"
                label="Password"
                name="password"
              />
              <ButtonReusable type="submit" fullWidth variant="contained">
                Sign In
              </ButtonReusable>
              <Grid container justifyContent="flex-end">
                <Grid item>
                  <Link to="/signUp">Don't have an account? Sign Up</Link>
                </Grid>
              </Grid>
            </Form>
          </Formik>
      
      </ContainerPaper>
    </React.Fragment>
  );
};

export default SignIn;
