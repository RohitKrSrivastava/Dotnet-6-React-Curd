import React from "react";
import EmployeeForm from "./EmployeeForm";

function AddEmployee() {
  const employee = {
    id : "",
    name: "",
    emailAddress: "",
    phoneNumber: "",
    cafeId: "",
    cafeName: "",
    gender: "",
  };

  return <EmployeeForm initialValues={employee} />;
}

export default AddEmployee;
