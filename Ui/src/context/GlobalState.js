import React, { createContext, useReducer, useEffect } from "react";
import {
  reducer,
  fetchEmployees,
  removeEmployee,
  addEmployee,
  editEmployee,
} from "./EmployeeReducer";

import {
  cafeReducer,
  fetchCafes,
  removeCafe,
  addCafe,
  editCafe,
} from "./CafeReducer";

const initialState = {
  employees: [],
  cafes: [],
};

export const GlobalContext = createContext(initialState);
export const GlobalProvider = ({ children }) => {
  const [state, dispatch] = useReducer(reducer, initialState);
  const [cafeState, cafeDispatch] = useReducer(cafeReducer, initialState);

  useEffect(() => {
    fetchEmployees(dispatch);
    fetchCafes(cafeDispatch);
  }, []);

  const handleRemoveEmployee = (employee) => {
    removeEmployee(dispatch, employee);
  };

  const handleAddEmployee = (employee) => {
    addEmployee(dispatch, employee);
  };

  const handleEditEmployee = (employee) => {
    editEmployee(dispatch, employee);
  };

  const handleRemoveCafe = (cafe) => {
    removeCafe(cafeDispatch, cafe);
  };

  const handleAddCafe = (cafe) => {
    addCafe(cafeDispatch, cafe);
  };

  const handleEditCafe = (cafe) => {
    editCafe(cafeDispatch, cafe);
  };

  return (
    <GlobalContext.Provider
      value={{
        employees: state.employees,
        removeEmployee: handleRemoveEmployee,
        addEmployee: handleAddEmployee,
        editEmployee: handleEditEmployee,
        cafes: cafeState.cafes,
        removeCafe: handleRemoveCafe,
        addCafe : handleAddCafe,
        editCafe: handleEditCafe,
      }}
    >
      {children}
    </GlobalContext.Provider>
  );
};
