import { Typography } from "@mui/material";
import React from "react";
import Card from "./ui-component/Card";
import ButtonReusable from "./ui-component/Button";
import CenteredComponent from "./ui-component/CenteredComponent";
import FormikControl from "./FormikComponents/FormikControl";
import * as Yup from "yup";
import { Form, Formik } from "formik";

const SignUp = () => {
  const onSubmit = (values) => {
    console.log(values);
  };

  const initialValues = {
    userName: "",
    password: "",
    confirmPassword: "",
  };

  const validationSchema = Yup.object({
    userName: Yup.string().required("Username is required"),
    password: Yup.string()
      .min(6, "At least 6 characters required")
      .required("Password is required"),
    confirmPassword: Yup.string()
      .oneOf([Yup.ref("password"), null], "Passwords must match")
      .required("Confirm password is required"),
  });

  return (
    <React.Fragment>
      <CenteredComponent>
        <Card>
          <Typography component="h1" variant="h5">
            Sign Up
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
                margin="normal"
              />
              <FormikControl
                control="input"
                type="password"
                label="Password"
                name="password"
                margin="normal"
              />
              <FormikControl
                control="input"
                type="password"
                label="Confirm Password"
                name="confirmPassword"
                margin="normal"
              />
              <ButtonReusable
                type="submit"
                fullWidth
                variant="contained"
                sx={{ mt: 3, mb: 2, height: 50 }}
              >
                Sign In
              </ButtonReusable>
            </Form>
          </Formik>
        </Card>
      </CenteredComponent>
    </React.Fragment>
  );
};

export default SignUp;
