import React from "react";
import CafeForm from "./CafeForm";

function AddCafe() {
  const employee = {
    name: "",
    email: "",
    phone: "",
    daysWorked: "",
    assignedCafe: "",
    gender: "",
  };

  return <CafeForm initialValues={employee} />;
}

export default AddCafe;
