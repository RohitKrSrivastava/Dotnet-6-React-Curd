import axios from "axios";
const apiUrl = process.env.REACT_APP_END_POINT + "/Employee/";

export const reducer = (state, action) => {
  switch (action.type) {
    case "FETCH_EMPLOYEES_SUCCESS":
      return {
        ...state,
        employees: action.payload,
        error: null,
      };
    case "FETCH_EMPLOYEES_FAILURE":
      return {
        ...state,
        employees: [],
        error: action.payload,
      };
    case "REMOVE_EMPLOYEE_SUCCESS":
      return {
        ...state,
        employees: state.employees.filter(
          (employee) => employee.id !== action.payload
        ),
        error: null,
      };
    case "REMOVE_EMPLOYEE_FAILURE":
      return {
        ...state,
        error: action.payload,
      };
    case "ADD_EMPLOYEE_SUCCESS":
      return {
        ...state,
        employees: [...state.employees, action.payload],
        error: null,
      };
    case "ADD_EMPLOYEE_FAILURE":
      return {
        ...state,
        error: action.payload,
      };
    case "EDIT_EMPLOYEE_SUCCESS":
      const updatedEmployee = action.payload;

      const updatedEmployees = state.employees.map((employee) => {
        if (employee.id === updatedEmployee.id) {
          return updatedEmployee;
        }
        return employee;
      });

      return {
        ...state,
        employees: updatedEmployees,
        error: null,
      };
    case "EDIT_EMPLOYEE_FAILURE":
      return {
        ...state,
        error: action.payload,
      };
    default:
      return state;
  }
};

export const fetchEmployees = async (dispatch) => {
  try {
    const get_URL = apiUrl + 'allEmployeeList';
    const response = await axios.get(
      get_URL
    );
    const employees = response.data;
    
    dispatch({
      type: "FETCH_EMPLOYEES_SUCCESS",
      payload: employees,
    });
  } catch (error) {
    dispatch({
      type: "FETCH_EMPLOYEES_FAILURE",
      payload: error.message,
    });
  }
};

export const removeEmployee = async (dispatch, empId) => {
  try {
    const remove_URL = apiUrl + `removeEmployee/${empId}`;

    const response = await axios.delete(
      remove_URL
    );
    const result = response.data;

    dispatch({
      type: "REMOVE_EMPLOYEE_SUCCESS",
      payload: result ? empId : null,
    });
  } catch (error) {
    dispatch({
      type: "REMOVE_EMPLOYEE_FAILURE",
      payload: error.message,
    });
  }
};

export const addEmployee = async (dispatch, employee) => {
  
  try {
    const get_URL = apiUrl + 'addEmployeeDetails';
    const response = await axios.post(
      get_URL,
      employee
    );

    employee.id = response.data;

    dispatch({
      type: "ADD_EMPLOYEE_SUCCESS",
      payload: response.data ? employee: null
    });
  } catch (error) {
    dispatch({
      type: "ADD_EMPLOYEE_FAILURE",
      payload: error.message,
    });
  }
};

export const editEmployee = async (dispatch, employee) => {

  const edit_URL = apiUrl + 'updateEmployeeDetails';
  try {
    await axios.put(
      edit_URL,
      employee
    );

    dispatch({
      type: "EDIT_EMPLOYEE_SUCCESS",
      payload: employee,
    });
  } catch (error) {
    dispatch({
      type: "EDIT_EMPLOYEE_FAILURE",
      payload: error.message,
    });
  }
};
