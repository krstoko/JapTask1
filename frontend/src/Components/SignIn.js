import { Typography } from "@mui/material";
import React from "react";
import Card from "./ui-component/Card";
import ButtonReusable from "./ui-component/Button";
import CenteredComponent from "./ui-component/CenteredComponent";
import * as Yup from "yup";
import { Formik, Form } from "formik";
import FormikControl from "./FormikComponents/FormikControl";
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
      <CenteredComponent>
        <Card>
          <Typography component="h1" variant="h5">
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
              <ButtonReusable
                type="submit"
                fullWidth
                variant="contained"
                sx={{ mt: 3, mb: 2, height: 50 }}
              >
                Sign In
              </ButtonReusable>
              <Link to="/signUp">Don't have an account? Sign Up</Link>
            </Form>
          </Formik>
        </Card>
      </CenteredComponent>
    </React.Fragment>
  );
};

export default SignIn;
